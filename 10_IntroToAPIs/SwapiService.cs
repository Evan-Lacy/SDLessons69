using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    public class SwapiService
    {
        //package provided for us by .NET framework
        private readonly HttpClient _httpClient = new HttpClient();

        private readonly string baseUrl = "https://swapi.dev/api/";

        public async Task<Person> GetPersonAsync(int id)
        {
            //ASync - 
            //await - wait for the response to come back, with a timeout built in
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }
            return null;
        }

        public async Task<Starships> GetStarship(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Starships starship = await response.Content.ReadAsAsync<Starships>();
                return starship;
            }

            return null;
        }

        public async Task<Films> GetFilmsAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                Films person = await response.Content.ReadAsAsync<Films>();
                return person;
            }
            return null;
        }

        public async Task<Vehicles> GetVehiclesAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                Vehicles person = await response.Content.ReadAsAsync<Vehicles>();
                return person;
            }
            return null;
        }

        public async Task<Species> GetSpeciesAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                Species person = await response.Content.ReadAsAsync<Species>();
                return person;
            }
            return null;
        }


    }
}
