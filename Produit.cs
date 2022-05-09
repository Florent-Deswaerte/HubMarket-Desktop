using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HubMarket_Desktop
{
    internal class Produit
    {
        public string fournisseur { get; set; }
        public string nom { get; set; }
        public string categorie { get; set; }
        public string qty { get; set; }
        public string prix { get; set; }
        public string description { get; set; }

        public static string SerializeProduit(Produit produit)
        {
            string jsonString = JsonSerializer.Serialize(produit);
            return jsonString;
        }
    }
}