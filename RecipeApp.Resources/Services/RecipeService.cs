using RecipeApp.Resources.Interfaces;
using RecipeApp.Resources.Models;


namespace RecipeApp.Resources.Services;

public class RecipeService : IRecipeService
{
    private readonly List<Recipe> recipes = []; 

    public void AddRecipe(Recipe recipe)
    {
        if (!recipes.Contains(recipe))
            recipes.Add(recipe);
    }

    public void RemoveRecipe(Recipe recipe)
    {
        if (recipes.Contains(recipe))
            recipes.Remove(recipe);
    }

    public List<Recipe> GetAllRecipes()
    {
        return new List<Recipe>(recipes);
    }

    public List<Recipe> SearchRecipes(string keyword)
    {
        return recipes.Where(r => r.RecipeName?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true
                               || r.Ingredients.Any(i => i.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                      .ToList();
    }
}
