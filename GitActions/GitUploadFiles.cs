using Abstractions;
using Octokit;

namespace GitActions;

public class GitUploadFiles : IGitUploadFiles
{
    public async Task UploadFile(string login, string repo, string branch, string? targetFile, string userToken,
        string filePath)
    {
        var gitHubClient = new GitHubClient(new ProductHeaderValue("TestRepo"))
        {
            Credentials = new Credentials(userToken)
        };

        ConvertToBase64String filePathToString = new();
        filePathToString.GetBase64String(filePath);
        string? content = filePathToString.ToString();

        await gitHubClient.Repository.Content.CreateFile(login, repo, targetFile,
            new CreateFileRequest("File creation", content, branch, true));
    }
}