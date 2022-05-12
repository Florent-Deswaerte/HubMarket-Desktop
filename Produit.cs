using System.Collections.Generic;
using System.Text.Json;

namespace HubMarket_Desktop
{
    public class Produit
    {
        public List<Fournisseur> fournisseur { get; set; }
        public string nom { get; set; }
        public List<Categorie> categorie { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public decimal prix { get; set; }

        public static string SerializeProduit(Produit produit)
        {
            string jsonString = JsonSerializer.Serialize(produit);
            return jsonString;
        }
    }
}