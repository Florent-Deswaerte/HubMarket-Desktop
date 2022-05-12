using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnCreation_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fournisseur> fournisseurs = new List<Fournisseur>();
                List<Categorie> categories = new List<Categorie>();
                Request request = new Request("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/fournisseurs");
                string jsonResponse = request.Get();
                JObject jsonObject = JObject.Parse(jsonResponse);
                var fournisseurObject = jsonObject.SelectToken($"$.api:members[?(@.libelle == '{fournisseurCreationTextBox.Text}')]");
                Fournisseur fournisseur = JsonConvert.DeserializeObject<Fournisseur>(fournisseurObject.ToString());
                fournisseurs.Add(fournisseur);
                request.SetUrl("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/categories");
                jsonResponse = request.Get();
                jsonObject = JObject.Parse(jsonResponse);
                var categorieObject = jsonObject.SelectToken($"$.api:members[?(@.nom == '{catProduitCreationTextBox.Text}')]");
                Categorie categorie = JsonConvert.DeserializeObject<Categorie>(categorieObject.ToString());
                categories.Add(categorie);

                /*var produit = new Produit()
                {
                    fournisseur = fournisseurs,
                    nom = nomProduitCreationTextBox.Text,
                    categorie = categories,
                    qty = Int32.Parse(qtyProduitCreationTextBox.Text),
                    description = descProduitCreationTextBox.Text,
                    prix = Decimal.Parse(prixProduitCreationTextBox.Text),
                };*/

                /* Erreur 500 sur la requête post
                try
                {
                    request.SetUrl("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits");
                    string jsonProduit = Produit.SerializeProduit(produit);
                    MessageBox.Show(jsonProduit);
                    En faite ici la c'est pas bon mais j'ai pas changé, la requête est pas bonne vu que j'envoie le produit comme il est de base alors que
                    l'on doit juste envoyer les infos en brut
                    string response = request.Post(jsonProduit, "application/json", "POST");
                    // MessageBox.Show(response);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
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