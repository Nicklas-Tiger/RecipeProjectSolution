using RecipeApp.Resources.Models;
using RecipeApp.Resources.Services;

namespace RecipeApp.Tests;

public class RecipeApp_Tests
{
    private readonly RecipeService _recipeService = new RecipeService();


    [Fact]
    public void AddRecipe_ShouldReturnTrue_WhenRecipeIsAdded()
    {
        // Arrange
        var recipe = new Recipe
        {
            RecipeName = "Falukorv och stuvade makaroner",
            Description = "Pasta med korv",
            Instructions = new List<string>
            {
            "1. Koka upp mjölken.",
            "2. Tillsätt makaroner och salt. Koka under omrörning på svag värme i ca 25 minuter tills makaronerna blir mjuka.",
            "3. Skär korven i skivor och stek dem i oljan i en stekpanna.",
            "4. Skölj och skär ev. upp grönsakerna eller servera dem hela",
            "5. Servera korven med makaroner och grönsaker."
            },
            Ingredients = new List<Ingredients>
            {
                new Ingredients { Name = "Makaroner", Amount = 5, Unit = "dl" },
                new Ingredients { Name = "Falukorv", Amount = 500, Unit = "g" },
                new Ingredients { Name = "Mjölk", Amount = 1, Unit = "liter" },
                new Ingredients { Name = "Salt", Amount = 0.5, Unit = "tsk" },
                new Ingredients { Name = "Olja", Amount = 0.5, Unit = "msk" }
            }
            

        };

        // Act
        _recipeService.AddRecipe(recipe);

        // Assert
        Assert.Contains(recipe, _recipeService.GetAllRecipes());
    }
}
