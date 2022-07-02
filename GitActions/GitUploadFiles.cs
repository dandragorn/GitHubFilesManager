using Abstractions;
using Octokit;

namespace GitActions;

public class GitUploadFiles : IGitUploadFiles
{
    public async Task UploadFile(string login, string repo, string branch, string? targetFile, string userToken,
        string filePath)
    {
        var gitHubClient = new GitHubClient(new ProductHeaderValue("TestRepo"));
        gitHubClient.Credentials = new Credentials(userToken);

        string fileString = Base64String.GetBase64String(filePath);

        await gitHubClient.Repository.Content.CreateFile(login, repo, targetFile,
            new CreateFileRequest("File creation", fileString, branch, true));
        
    }
}