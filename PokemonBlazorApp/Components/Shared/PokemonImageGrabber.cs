using PokemonBlazorApp.Data;

namespace PokemonBlazorApp.Components.Shared
{
    public class PokemonImageGrabber
    {
        public string? GetImageUrl(Pokemon pokemon)
        {
            if (pokemon is null) return null;

            var name = pokemon.Name.Split("Mega")[0].Replace("'", string.Empty).ToLowerInvariant();
            var imageUrl = $"https://img.pokemondb.net/artwork/large/{name}.jpg";
            return imageUrl;
        }
    }
}
