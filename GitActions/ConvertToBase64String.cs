using Abstractions;

namespace GitActions;

public class ConvertToBase64String : IConvertToBase64String
{
    public string GetBase64String(string filePath)
    {
        var fileBytes = File.ReadAllBytes(filePath);
        return Convert.ToBase64String(fileBytes);
    }
}