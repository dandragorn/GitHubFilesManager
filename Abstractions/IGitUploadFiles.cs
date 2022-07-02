namespace Abstractions;

public interface IGitUploadFiles
{ 
    public Task UploadFile(string login, string repo, string branch, string? targetFile, string userToken, string filePath);
}