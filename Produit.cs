using System.Collections.Generic;
using System.Text.Json;

namespace HubMarket_Desktop
{
    public class Produit
    {
        public int? id { get; set; }
        public string fournisseur { get; set; }
        public string nom { get; set; }
        public string categorie { get; set; }
        public Categorie[] categories { get; set; }
        public Fournisseur[] fournisseurs { get; set;}
        public int qty { get; set; }
        public string description { get; set; }
        public string prix { get; set; }
        public string imagePath { get; set; }


        public static string SerializeProduit(Produit produit)
        {
            string jsonString = JsonSerializer.Serialize(produit);
            return jsonString;
        }
    }
}