namespace GitActions;

public static class Base64String
{
    public static string GetBase64String(string filePath)
    {
        byte[] fileBytes = File.ReadAllBytes(filePath);
        return Convert.ToBase64String(fileBytes);
    }
}