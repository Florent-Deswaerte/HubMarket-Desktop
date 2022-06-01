using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            CenterToScreen();
        }

        private async void btnCreation_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fournisseur> fournisseurs = new List<Fournisseur>();
                List<Categorie> categories = new List<Categorie>();
                Request request = new Request("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/fournisseurs");
                string jsonResponse = request.Get();
                JObject jsonObject = JObject.Parse(jsonResponse);
                var fournisseurObject = jsonObject.SelectToken($"$.api:members[?(@.libelle == '{fournisseurCreationTextBox.Text}')]");
                if(fournisseurObject == null)
                {
                    MessageBox.Show("Ceci n'est pas un fournisseur valide");
                    return;
                }
                else
                {
                    Fournisseur fournisseur = JsonConvert.DeserializeObject<Fournisseur>(fournisseurObject.ToString());
                    fournisseurs.Add(fournisseur);
                }
                request.SetUrl("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/categories");
                jsonResponse = request.Get();
                jsonObject = JObject.Parse(jsonResponse);
                var categorieObject = jsonObject.SelectToken($"$.api:members[?(@.nom == '{catProduitCreationTextBox.Text}')]");
                if (categorieObject == null)
                {
                    MessageBox.Show("Ceci n'est pas une catégorie valide");
                    return;
                }
                else
                {
                    Categorie categorie = JsonConvert.DeserializeObject<Categorie>(categorieObject.ToString());
                    categories.Add(categorie);
                }
                var produit = new Produit()
                {
                    fournisseur = fournisseurCreationTextBox.Text,
                    nom = nomProduitCreationTextBox.Text,
                    categorie = catProduitCreationTextBox.Text,
                    qty = Int32.Parse(qtyProduitCreationTextBox.Text),
                    description = descProduitCreationTextBox.Text,
                    prix = Decimal.Parse(prixProduitCreationTextBox.Text),
                    imagePath = "http://s4-8014.nuage-peda.fr/Hubmarket/src/Assets/Images/nouilles.jpg",
                };

                try
                {
                    request.SetUrl("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits");
                    string jsonProduit = Produit.SerializeProduit(produit);
                    var jObj = (JObject)JsonConvert.DeserializeObject(jsonProduit);
                    var query = "?" + String.Join("&", jObj.Children().Cast<JProperty>().Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));
                    string response = await request.PostQuery("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits" + query);
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

        private void btnModification_Click(object sender, EventArgs e)
        {
            // Code
        }
    }
}