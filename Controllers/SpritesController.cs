using Microsoft.AspNetCore.Mvc;
using shiny_hunt.Services;
namespace shiny_hunt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpritesController : ControllerBase
    {
        private readonly ISpritesServices _spritesServices;
        public SpritesController(ISpritesServices spritesServices)
        {
            _spritesServices = spritesServices;
        }
        [HttpGet("shiny/{pokemonName}")]
        public async Task<object?> GetPokemonShinySprite( string pokemonName)
        {
            return await _spritesServices.GetPokemonShinySprite(pokemonName);
        }
    }
}
