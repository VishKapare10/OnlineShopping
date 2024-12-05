
using System.Text.Json.Serialization;
namespace CustomerWebAPI.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string WebSite { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}