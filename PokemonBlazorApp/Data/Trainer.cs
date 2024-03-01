namespace PokemonBlazorApp.Data
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Pokemon Companion { get; set; }
    }
}
