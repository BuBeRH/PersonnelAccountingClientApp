using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using PersonnelAccountingClientApp.Classes.Response;
using PersonnelAccountingClientApp.Classes.Personal;

namespace PersonnelAccountingClientApp.ServerRequests
{
    public class Requests
    {
        private const string ServerAddres = "https://localhost:7183";
        private static readonly HttpClient client = new();

        public static async void RemovePerson(int Id)
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
