using Microsoft.AspNetCore.Identity;
using PokemonBlazorApp.Data;
using System.Security.Claims;

namespace PokemonBlazorApp.Components.Account
{
    public static class AccountRouteExtensions
    {
        public static IEndpointConventionBuilder MapAdditionalAccountRoutes(this IEndpointRouteBuilder endpoints) 
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var accountGroup = endpoints.MapGroup("/Account");

            accountGroup.MapGet("/Logout", async (
               ClaimsPrincipal user,
               SignInManager<User> signInManager,
               string? returnUrl) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.LocalRedirect($"~/{returnUrl}");
            });


            return accountGroup;
        }
    }
}
