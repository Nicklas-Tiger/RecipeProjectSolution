using RecipeApp.Resources.Models;

namespace RecipeApp.Resources.Interfaces;

public interface IRecipeService
{
    void AddRecipe(Recipe recipe);
    void RemoveRecipe(Recipe recipe);
    List<Recipe> GetAllRecipes();
    List<Recipe> SearchRecipes(string keyword);
}