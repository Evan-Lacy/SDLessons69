using _10_IntroToAPIs.Model;
using _10_IntroToAPIs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    public class SwapiService
    {
        //package provided for us by .NET framework
        private readonly HttpClient _httpClient = new HttpClient();

        //private readonly string baseUrl = "https://swapi.dev/api/";
        private readonly string baseUrl = "https://us-central1-lateral-incline-114906.cloudfunctions.net/swapi/";

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



        /*==============================================================================*/
        /*===========================Andrew's SWAPI=====================================*/
        /*==============================================================================*/

        public async Task<Planet> GetPlanetAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "planets/" + id);

            if (response.IsSuccessStatusCode)
            {
                Planet planet = await response.Content.ReadAsAsync<Planet>();
                return planet;
            }
            return null;
        }

        public async Task<CharacterWithHomeworld> GetCharacterWithHomeworldAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Character character = await response.Content.ReadAsAsync<Character>();
                CharacterWithHomeworld charWithHome = new CharacterWithHomeworld()
                {
                    Name = character.Name,
                    HomeworldId = character.Homeworld,
                    Gender = character.Gender
                };

                HttpResponseMessage planetResponse = await _httpClient.GetAsync(baseUrl + "planets/" + character.Homeworld);
                if (planetResponse.IsSuccessStatusCode)
                {
                    Planet homeworld = await planetResponse.Content.ReadAsAsync<Planet>();
                    charWithHome.Homeworld = homeworld;
                }
                else
                {
                    charWithHome.Homeworld = null;
                }

                return charWithHome;
            }
            return null;
        }

        //public async Task PostCharacterAsync(Character character)
        //{
        //    string json = JsonConvert.SerializeObject(character);
        //    HttpContent data = new StringContent(json, Encoding.UTF8, "application/json");
        //    HttpResponseMessage response = await _httpClient.PostAsync(baseUrl + "people/", data);
        //    //string result = response.Content.ReadAsStringAsync().Result;
        //    //return result;
        //}

        public async Task<HttpStatusCode> PostCharacterAsync(Character character)
        {
            Dictionary<string, string> characterData = new Dictionary<string, string>
            {
                { "name", character.Name },
                { "gender", character.Gender },
                { "homeworld", character.Homeworld.ToString() }
            };
            HttpContent content = new FormUrlEncodedContent(characterData);
            HttpResponseMessage response = await _httpClient.PostAsync(baseUrl + "people/", content);
            return response.StatusCode;
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Character character = await response.Content.ReadAsAsync<Character>();
                return character;
            }

            return null;
        }


    }
}
