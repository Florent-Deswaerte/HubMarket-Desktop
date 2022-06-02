using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HubMarket_Desktop
{
    public partial class BaseForm : MaterialForm
    {
        public BaseForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Request request = new Request($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits/fournisseur/{Singleton.GetInstance().GetFournisseur().libelle}");
            string jsonResponse = request.Get();
            JObject jsonObject = JObject.Parse(jsonResponse);
            Produit[] produits = jsonObject["api:members"].ToObject<Produit[]>();
            foreach(Produit produit in produits)
            {
                ListViewItem item = new ListViewItem(produit.id.ToString());
                item.SubItems.Add(produit.nom);
                item.SubItems.Add(produit.categories[0].nom);
                item.SubItems.Add(produit.qty.ToString());
                item.SubItems.Add(produit.prix.ToString());
                productsListView.Items.Add(item);
            }
            CenterToScreen();
        }

        private async void btnCreation_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean readyToInsert = false;
                Request request = new Request("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/categories");
                string jsonResponse = request.Get();
                JObject jsonObject = JObject.Parse(jsonResponse);
                var categorieObject = jsonObject.SelectToken($"$.api:members[?(@.nom == '{catProduitCreationTextBox.Text}')]");
                if (categorieObject == null)
                {
                    MessageBox.Show("Ceci n'est pas une catégorie valide");
                }
                var produit = new Produit()
                {
                    fournisseur = Singleton.GetInstance().GetFournisseur().libelle,
                    nom = nomProduitCreationTextBox.Text,
                    categorie = catProduitCreationTextBox.Text,
                    qty = Int32.Parse(qtyProduitCreationTextBox.Text),
                    description = descProduitCreationTextBox.Text,
                    prix = Decimal.Parse(prixProduitCreationTextBox.Text),
                    imagePath = "http://s4-8014.nuage-peda.fr/Hubmarket/src/Assets/Images/nouilles.jpg",
                };
                try
                {
                    if(categorieObject != null) readyToInsert = true;
                    if(readyToInsert == true)
                    {
                        request.SetUrl("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits");
                        string jsonProduit = Produit.SerializeProduit(produit);
                        var jObj = (JObject)JsonConvert.DeserializeObject(jsonProduit);
                        var query = "?" + String.Join("&", jObj.Children().Cast<JProperty>().Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));
                        string response = await request.PostQuery("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits" + query);
                        JObject responseObject = JObject.Parse(response);
                        string responseCode = responseObject["api:responseCode"].ToString();
                        if (responseCode != "201") MessageBox.Show($"Le serveur a répondu avec le code: {responseCode}\nLe produit n'a pas été inséré!");
                        else MessageBox.Show("Le produit a bien été inséré!");
                    }
                    else
                    {
                        MessageBox.Show("Le produit ne peut pas être inséré");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productsListView_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = productsListView.SelectedItems[0];
            Request request = new Request($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits/{firstSelectedItem.Text}");
            string jsonResponse = request.Get();
            JObject jsonObject = JObject.Parse(jsonResponse);
            Produit produit = jsonObject["api:members"][0].ToObject<Produit>();
            modifyProductCatTextField.Text = produit.categories[0].nom;
            modifyProductDescTextField.Text = produit.description;
            modifyProductNameTextField.Text = produit.nom;
            modifyProductQtyTextField.Text = produit.qty.ToString();
            modifyProductPriceTextField.Text = produit.prix.ToString();
            produitIdLabel.Text = produit.id.ToString();
        }

        private async void modifyProductButton_Click(object sender, EventArgs e)
        {
            var produit = new Produit()
            {
                fournisseur = Singleton.GetInstance().GetFournisseur().libelle,
                nom = modifyProductNameTextField.Text,
                categorie = modifyProductCatTextField.Text,
                qty = Int32.Parse(modifyProductQtyTextField.Text),
                description = modifyProductDescTextField.Text,
                prix = Decimal.Parse(modifyProductPriceTextField.Text),
                imagePath = "http://s4-8014.nuage-peda.fr/Hubmarket/src/Assets/Images/nouilles.jpg",
            };
            Request request = new Request();
            string jsonProduit = Produit.SerializeProduit(produit);
            var jObj = (JObject)JsonConvert.DeserializeObject(jsonProduit);
            jObj.Remove("id");
            jObj.Remove("categories");
            jObj.Remove("fournisseurs");
            var query = "?" + String.Join("&", jObj.Children().Cast<JProperty>().Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));
            string response = await request.PatchQuery($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits/{produitIdLabel.Text}" + query);
            JObject responseObject = JObject.Parse(response);
            string responseCode = responseObject["api:responseCode"].ToString();
            this.ReloadListView();
            MessageBox.Show("Le produit a été modifié!");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.ReloadListView();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (produitIdLabel.Text != "")
            {
                Request request = new Request($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits/{produitIdLabel.Text}");
                HttpWebResponse response = request.Delete(request.GetUrl());
                this.ReloadListView();
                MessageBox.Show("Produit supprimé!");
            }
        }

        private void ReloadListView()
        {
            Request request = new Request($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits/fournisseur/{Singleton.GetInstance().GetFournisseur().libelle}");
            string jsonResponse = request.Get();
            JObject jsonObject = JObject.Parse(jsonResponse);
            Produit[] produits = jsonObject["api:members"].ToObject<Produit[]>();
            productsListView.Items.Clear();
            foreach (Produit produit in produits)
            {
                ListViewItem item = new ListViewItem(produit.id.ToString());
                item.SubItems.Add(produit.nom);
                item.SubItems.Add(produit.categories[0].nom);
                item.SubItems.Add(produit.qty.ToString());
                item.SubItems.Add(produit.prix.ToString());
                productsListView.Items.Add(item);
            }
        }
    }
}