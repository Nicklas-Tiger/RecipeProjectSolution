namespace RecipeApp.Resources.Interfaces;

public interface IFileService
{
    public void GetFromFile(string content);
    public void SaveToFile();
}