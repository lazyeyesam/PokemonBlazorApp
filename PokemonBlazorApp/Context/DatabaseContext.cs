using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokemonBlazorApp.Data;

namespace PokemonBlazorApp.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "pokemon_blazor.db");
            optionbuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
