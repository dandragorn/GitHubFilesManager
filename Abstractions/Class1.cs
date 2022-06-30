namespace Abstractions;

public interface IGitFilesManager
{
    Task UploadFile(string filePath, string userToken);
}