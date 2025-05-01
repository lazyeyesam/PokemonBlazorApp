using PokemonBlazorApp.Context;

namespace PokemonBlazorApp.Components
{
    public static class RouteExtensions
    {
        public static IEndpointConventionBuilder MapAdditionalResetRoutes(this IEndpointRouteBuilder endpoints)
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var group = endpoints.MapGroup("/");

            group.MapGet("/reset", async (DatabaseContext context, DatabaseSeeder seeder) =>
            {
                // Remove all trainers
                var trainers = context.Trainers.ToList();
                context.Trainers.RemoveRange(trainers);
                await context.SaveChangesAsync();

                // Remove all pokemon
                var pokemon = context.Pokemons.ToList();
                context.Pokemons.RemoveRange(pokemon);
                await context.SaveChangesAsync();

                // Remove all users
                var users = context.Users.ToList();
                context.Users.RemoveRange(users);
                await context.SaveChangesAsync();

                // Seed the database
                await seeder.Seed();

                return TypedResults.LocalRedirect("/Account/Logout");
            });

            return group;
        }
    }
}
