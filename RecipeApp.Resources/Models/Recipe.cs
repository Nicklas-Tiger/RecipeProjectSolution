namespace RecipeApp.Resources.Models;

public class Recipe
{
    public string? RecipeName { get; set; }
    public string? Description { get; set; }
    public List<string> Instructions { get; set; } = [];
    public List<Ingredients> Ingredients { get; set; } = []; 
    public int? CookingTimeInMinutes { get; set; }  
    public bool IsFavorite { get; set; }
    public string? ImagePath { get; set; }
}
