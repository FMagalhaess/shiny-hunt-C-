namespace shiny_hunt.Services
{
    public interface ISpritesServices
    {
        Task<string?> GetPokemonShinySprite(string pokemonName);
    }
}