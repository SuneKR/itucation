using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebAPIDemo.Models;

namespace WebAPIDemo.ExternalCall
{
    public class ExternalClient : IExternalData
    {
        private readonly HttpClient _httpClient;
        public ExternalClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
        }
        [HttpGet] public async Task<Person> GetById(int id)
        {
            var response = await _httpClient.GetStringAsync($"people/{ id }");
            JObject dict = JObject.Parse(response);
            Person newPerson = new Person { Id = id, Name = (string)dict["name"], Height = (int)dict["height"] };
            return newPerson;
        }
    }
}
