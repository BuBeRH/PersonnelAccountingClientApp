using System.Text.Json.Serialization;
using PersonnelAccountingClientApp.Classes.Personal;

namespace PersonnelAccountingClientApp.Classes.Response
{
    public class Jperson
    {
        [JsonPropertyName("Person")]
        public Person Person { get; set; } = new();
    }
}
