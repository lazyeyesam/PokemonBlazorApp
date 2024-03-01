using Microsoft.EntityFrameworkCore;
using PokemonBlazorApp.Data;

namespace PokemonBlazorApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "pokemon.db");
            optionbuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
