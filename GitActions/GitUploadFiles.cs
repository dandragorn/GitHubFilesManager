using Abstractions;
using Octokit;

namespace GitActions;

public class GitUploadFiles : IGitUploadFiles
{
    public async Task UploadFile(string login, string repo, string branch, string? targetFile, string userToken,
        string content)
    {
        var gitHubClient = new GitHubClient(new ProductHeaderValue("TestRepo"))
        {
            Credentials = new Credentials(userToken)
        };

        await gitHubClient.Repository.Content.CreateFile(login, repo, targetFile,
            new CreateFileRequest("File creation", content, branch, true));
    }
}