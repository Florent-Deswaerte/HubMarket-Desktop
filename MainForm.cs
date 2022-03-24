using Newtonsoft.Json;
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

namespace HubMarket_Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string decodedToken = JwtToken.DecodeToken("eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImN0eSI6IkpXVCJ9.eyJpYXQiOjE2NDgxMjc4ODMsImV4cCI6MTY0ODEzMzI4Mywicm9sZXMiOlsiUk9MRV9VU0VSIl0sInVzZXJuYW1lIjoiY2xlbWVudC5yaWNoYXJkQGVwc2kuZnIiLCJpZCI6MTAsImFkcmVzc2UiOm51bGwsIm5vbSI6bnVsbCwicHJlbm9tIjpudWxsLCJwaG9uZSI6bnVsbCwicGF5cyI6bnVsbCwidmlsbGUiOm51bGwsInBhbmllciI6bnVsbCwiY29tbWFuZGVzIjpbeyJpZCI6MSwiZGF0ZV9jb21tYW5kZSI6eyJkYXRlIjoiMjAyMi0wMy0xNSAwMDowMDowMC4wMDAwMDAiLCJ0aW1lem9uZV90eXBlIjozLCJ0aW1lem9uZSI6IkV1cm9wZS9CZXJsaW4ifSwiZGF0ZV9hcnJpdmVlIjpudWxsLCJ0b3RhbF9jb21tYW5kZSI6MTUxNSwic3RhdHVzIjpudWxsLCJsQ29tbWFuZGVzIjpbXX1dfQ.r6Y9SvFMYX09TNlayP_ZK362ZG3-35rFgFVP59GOsqkQxeHaSkwns_fpQaRJraE3dS8ehkMgzvaBuXL5HfmmvLqXWcQflXHVZlh8J-eZhmd5SgyCvgACwq6Q36nH6QnbjoepZ4cD7cPc7851OUCZPS9fi-cuwuJivi2yzxsjfKWRf4KTOU6lkTj5-JH3jDofB5Wckvz6eFWzDyLFPPOtauX2LMw0J8tMEjuzh8kt4TPJkEd_UUOwlOm3XZKa5YYcRgxtEUsMixokyQrhH9fC08oqIvKe22v-okBR0yA--xQcrA9qHTEVy2etMBcl4g4RbrsyrO8THJNcfFCgq8vo9Q");

            User user = JsonConvert.DeserializeObject<User>(decodedToken);
            label1.Text = user.Email;
        }
    }
}
