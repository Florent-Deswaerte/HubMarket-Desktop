using System.Text.Json;

namespace HubMarket_Desktop
{
    public class Categorie
    {
        public int id { get; set; }
        public string nom { get; set; }
        public static string SerializeProduit(Categorie categorie)
        {
            string jsonString = JsonSerializer.Serialize(categorie);
            return jsonString;
        }
    }
}
