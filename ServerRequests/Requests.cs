using System.Text.Json;
using PersonnelAccountingClientApp.Classes.Response;
using PersonnelAccountingClientApp.Classes.Personal;

namespace PersonnelAccountingClientApp.ServerRequests
{
    public class Requests
    {
        private const string ServerAddres = "https://localhost:7183";
        private static readonly HttpClient client = new();

        public static async Task<List<Person>> GetFiltredPerson(string filtred, string param)
        {
            Jpersons? persons = new();
            string uri = ServerAddres + "/getfiltredperson?col=" + System.Net.WebUtility.UrlEncode(filtred) +
                         "&param=" + System.Net.WebUtility.UrlEncode(param);
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                persons = JsonSerializer.Deserialize<Jpersons>(data);
            }
            return persons.Persons;
        }

        public static async void UpdatePerson(Person person)
        {
            Jperson? jperson = new();
            jperson.Person = person;
            string uri = ServerAddres + "/updateperson";
            string json = JsonSerializer.Serialize<Jperson>(jperson);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync(uri, content);

        }

        public static async void AddPerson(Person person)
        {
            Jperson? jperson = new();
            jperson.Person = person;
            string uri = ServerAddres + "/addperson";
            string json = JsonSerializer.Serialize<Jperson>(jperson);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync(uri, content);

        }

        public static async void RemovePerson(long Id)
        {
            string uri = ServerAddres + "/deleteperson?number=" + System.Net.WebUtility.UrlEncode(Id.ToString());
            await client.GetAsync(uri);
        }

        public static async Task<Person> GetPerson(int Id)
        {
            Jperson? person = new();
            string uri = ServerAddres + "/getperson?number=" + System.Net.WebUtility.UrlEncode(Id.ToString());
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                person = JsonSerializer.Deserialize<Jperson>(data);
            }

            return person.Person;
        }

        public static async Task<List<Person>> GetPersons()
        {
            Jpersons? persons = new();
            string uri = ServerAddres + "/getpersons";
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                persons = JsonSerializer.Deserialize<Jpersons>(data);
            }
            return persons.Persons;
        }
    }
}
