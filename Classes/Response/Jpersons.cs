using System.Text.Json.Serialization;
using PersonnelAccountingClientApp.Classes.Personal;

namespace PersonnelAccountingClientApp.Classes.Response
{
    public class Jpersons
    {
        [JsonPropertyName("Persons")]
        public List<Person>? Persons { get; set; }
    }
}
