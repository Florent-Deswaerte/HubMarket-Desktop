using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace HubMarket_Desktop
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            usernameTextBox.Left = (this.ClientSize.Width - usernameTextBox.Width) / 2;
            passwordTextBox.Left = (this.ClientSize.Width - passwordTextBox.Width) / 2;
            connectButton.Left = (this.ClientSize.Width - connectButton.Width) / 2;
            this.MaximizeBox = false;
            CenterToScreen();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange400, Primary.Orange500,
                Primary.Orange500, Accent.Orange200,
                TextShade.WHITE
            );
        }

        private void Connexion(object sender, EventArgs e)
        {
            var credentials = new Credentials()
            {
                username = usernameTextBox.Text,
                password = passwordTextBox.Text,
            };

            try
            {
                Request request = new Request("https://s4-8014.nuage-peda.fr/Hubmarket/public/api/login");
                string jsonString = Credentials.SerializeCredentials(credentials);
                string response = request.Post(jsonString, "application/json", "POST");
                JwtToken jwtToken = JsonConvert.DeserializeObject<JwtToken>(response);
                string decodedToken = JwtToken.DecodeToken(jwtToken.Token);
                User user = JsonConvert.DeserializeObject<User>(decodedToken);
                if (user != null)
                {
                    try
                    {
                        request.SetUrl($"https://s4-8014.nuage-peda.fr/Hubmarket/public/api/fournisseurs/email/{usernameTextBox.Text}");
                        string jsonResponse = request.Get();
                        JObject jsonObject = JObject.Parse(jsonResponse);
                        Fournisseur fournisseur = jsonObject["api:members"][0].ToObject<Fournisseur>();
                        Singleton.GetInstance().SetFournisseur(fournisseur);
                        Singleton.GetInstance().SetUser(user);
                        Form BaseForm = new BaseForm();
                        BaseForm.Location = this.Location;
                        BaseForm.StartPosition = FormStartPosition.Manual;
                        BaseForm.FormClosing += delegate { this.Show(); };
                        BaseForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vous devez être un fournisseur afin de pouvoir accéder à cet outil");
                    }
                }
            }
            catch (Exception ex)
            {
                debugLabel.Text = ex.Message;
            }
        }
    }
}