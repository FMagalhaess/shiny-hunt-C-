using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace shiny_hunt.Services
{
    public class SpritesServices : ISpritesServices
    {
        private readonly HttpClient _httpClient;

        public SpritesServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string?> GetPokemonShinySprite(string pokemonName)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var frontShiny = JObject.Parse(content)?["sprites"]?["other"]?["showdown"]?["front_shiny"];
                return frontShiny?.ToString();
            }

            return null;
        }
    }
}
