using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace HubMarket_Desktop
{
    public class User
    {
        [JsonProperty(PropertyName = "roles")]
        public string[] Roles { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "adresse")]
        public string Adresse { get; set; }
        [JsonProperty(PropertyName = "nom")]
        public string Nom { get; set; }
        [JsonProperty(PropertyName = "prenom")]
        public string Prenom { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "pays")]
        public string Pays { get; set; }
        [JsonProperty(PropertyName = "ville")]
        public string Ville { get; set; }

    }
}
