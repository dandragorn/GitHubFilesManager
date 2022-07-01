using Abstractions;

namespace GitHubFilesManager;

public class GitFilesManager : IGitFilesManager
{
    public Task UploadFile(string filePath, string userToken)
    {
        throw new NotImplementedException();
    }
}