using PokemonBlazorApp.Data;

namespace PokemonBlazorApp.Components.Shared
{
    public class PokemonImageGrabber
    {
        private const string NOT_FOUND = "img/notfound.png";

        public string GetImageUrl(Pokemon pokemon)
        {
            if (pokemon is null) return NOT_FOUND;

            List<string> parts = [];
            var name = pokemon.Name;

            if (!pokemon.Name.StartsWith("Mega"))
            {
                parts = pokemon.Name.Split("Mega").ToList();
                name = parts[0];
            }
            if (parts.Count > 1)
                name = $"{name}-mega";
            else
            {
                name = name.Replace("'", string.Empty)
                        .Replace("♀", "-f")
                        .Replace("♂", "-m")
                        .Replace(". ", "-")
                        .Replace("Plant Cloak", "")
                        .Replace("Primal Kyogre", "")
                        .Replace("Primal Groudon", "")
                        .Replace("Normal Forme", "")
                        .Replace("Attack Forme", "")
                        .Replace("Defence Forme", "")
                        .Replace("Speed Forme", "")
                        .Replace("Average Size", "")
                        .Replace("Small Size", "")
                        .Replace("Large Size", "")
                        .Replace("Super Size", "")
                        .Replace("Blade Forme", "")
                        .Replace("Shield Forme", "")
                        .Replace("MeowsticMale", "Meowstic-Male")
                        .Replace("MeowsticFemale", "Meowstic-Female")
                        .Replace(" Forme", "")
                        .Replace("Heat Rotom", "")
                        .Replace("Wash Rotom", "")
                        .Replace("Frost Rotom", "")
                        .Replace("Fan Rotom", "")
                        .Replace("Mow Rotom", "")
                        .Replace(" Jr.", "-jr")
                        .Replace("é", "e");
            }
            name = name.Replace("Charizard-mega", "Charizard")
                       .Replace("Mewtwo-mega", "Mewtwo")
                       .Replace("DeoxysDefense", "Deoxys")
                       .Replace("WormadamSandy Cloak", "Wormadam")
                       .Replace("WormadamTrash Cloak", "Wormadam")
                       .Replace("RotomHeat", "Rotom")
                       .Replace("RotomWash", "Rotom")
                       .Replace("RotomFrost", "Rotom")
                       .Replace("RotomFan", "Rotom")
                       .Replace("RotomMow", "Rotom")
                       .Replace("GiratinaAltered", "Giratina-altered")
                       .Replace("GiratinaOrigin", "Giratina-origin")
                       .Replace("ShayminLand", "Shaymin-Land")
                       .Replace("ShayminSky", "Shaymin-Sky")
                       .Replace("DarmanitanStandard Mode", "Darmanitan")
                       .Replace("DarmanitanZen Mode", "Darmanitan")

                       .Replace("TornadusIncarnate", "Thundurus")
                       .Replace("TornadusTherian", "Thundurus")
                       .Replace("ThundurusIncarnate", "Thundurus")
                       .Replace("ThundurusTherian", "Thundurus")

                       .Replace("LandorusIncarnate", "Landorus")
                       .Replace("LandorusTherian", "Landorus")

                       .Replace("KyuremBlack Kyurem", "Kyurem")
                       .Replace("KyuremWhite Kyurem", "Kyurem")
                       .Replace("KeldeoOrdinary", "Keldeo")
                       .Replace("KeldeoResolute", "Keldeo")

                       .Replace("MeloettaAria", "Meloetta")
                       .Replace("MeloettaPirouette", "Meloetta")

                       .Replace("Hoopa Confined", "Hoopa-Confined")
                       .Replace("Hoopa Unbound", "Hoopa-Unbound")

                       .Replace("Tapu Koko", "Tapu-Koko")
                       .Replace("Tapu Lele", "Tapu-Lele")
                       .Replace("Tapu Bulu", "Tapu-Bulu")
                       .Replace("Tapu Fini", "Tapu-Fini")

                       .Replace("MiniorMeteor Form", "Minior-Meteor")
                       .Replace("MiniorCore Form", "Minior-Core")

                       .Replace("MimikyuDisguised Form", "Mimikyu")

                       .Replace("LycanrocMidday Form", "Lycanroc-Midday")
                       .Replace("LycanrocMidnight Form", "Lycanroc-Midnight")
                       .Replace("WishiwashiSolo Form", "Wishiwashi-Solo")
                       .Replace("WishiwashiSchool Form", "Wishiwashi-School")

                       .Replace("OricorioBaile Style", "Oricorio-Baile")
                       .Replace("OricorioPom-Pom Style", "Oricorio-Pom-Pom")
                       .Replace("OricorioPau Style", "Oricorio-Pau")
                       .Replace("OricorioSensu Style", "Oricorio-Sensu")
                       ;
            
            name = name.ToLowerInvariant();

            var imageUrl = $"https://img.pokemondb.net/artwork/large/{name}.jpg";
            return imageUrl;
        }
    }
}
