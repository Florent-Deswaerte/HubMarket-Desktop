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

namespace HubMarket_Desktop
{
    public partial class BaseForm : MaterialForm
    {
        public BaseForm()
        {
            InitializeComponent();

            CenterToScreen();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            /*var produit = new Produit
            {
                fournisseur = fournisseurTextBox.Text,
                nom = nomProduitTextBox.Text,
                categorie = catProduitTextBox.Text,
                qty = qtyProduitTextBox.Text,
                prix = prixProduitTextBox.Text,
                description = descriptionProduitTextBox.Text
            };

            try
            {
                Request request = new Request("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/produits");
                string jsonString = Produit.SerializeProduit(produit);
                string response = request.Post(jsonString, "application/json", "POST");
                MessageBox.Show(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }
}