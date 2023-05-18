using Domain.Models.Recipes;

namespace Domain.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe( int id );

        IReadOnlyList<Recipe> GetUserRecipes( int userId );

        IReadOnlyList<Recipe> GetFavoriteRecipes( int userId );
    }
}
