using System.Text.Json;

namespace HubMarket_Desktop
{
    public class Fournisseur
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public string pays { get; set; }
        public string adresse { get; set; }
        public int cp { get; set; }
        public static string SerializeProduit(Fournisseur fournisseur)
        {
            string jsonString = JsonSerializer.Serialize(fournisseur);
            return jsonString;
        }
    }
}
