using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HubMarket_Desktop
{
    public class Credentials
    {
        public string username { get; set; }
        public string password { get; set; }

        public static string SerializeCredentials(Credentials credentials)
        {
            string jsonString = JsonSerializer.Serialize(credentials);
            return jsonString;
        }
    }
}
