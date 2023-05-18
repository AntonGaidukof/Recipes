using Domain.Models.Recipes;

namespace Domain.Services
{
    public class RecipeService : IRecipeService
    {
        public IReadOnlyList<Recipe> GetFavoriteRecipes( int userId )
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipe( int id )
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Recipe> GetUserRecipes( int userId )
        {
            throw new NotImplementedException();
        }
    }
}
