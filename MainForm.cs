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
            CenterToScreen();
            this.Text = "HubMarket";
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
            var credentials = new Credentials
            {
                username = usernameTextBox.Text,
                password = passwordTextBox.Text,
            };

            try
            {
                Request request = new Request("http://s4-8014.nuage-peda.fr/Hubmarket/public/api/login");
                string jsonString = Credentials.SerializeCredentials(credentials);
                string response = request.Post(jsonString, "application/json", "POST");
                JwtToken jwtToken = JsonConvert.DeserializeObject<JwtToken>(response);
                string decodedToken = JwtToken.DecodeToken(jwtToken.Token);
                User user = JsonConvert.DeserializeObject<User>(decodedToken);
                if (user != null)
                {
                    Singleton.GetInstance().SetUser(user);
                    debugLabel.Text = request.GetResponse().StatusCode.ToString();
                }
            }
            catch (Exception ex)
            {
                debugLabel.Text = ex.Message;
            }
            
        }
    }
}
