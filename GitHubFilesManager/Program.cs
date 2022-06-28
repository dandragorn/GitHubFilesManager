using System.Text;
using Octokit;

var gitHubClient = new GitHubClient(new ProductHeaderValue("MyCoolFilesManager"));
gitHubClient.Credentials = new Credentials("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");

var user = await gitHubClient.User.Get("danperunov");

var sb = new StringBuilder("---");
sb.AppendLine();
sb.AppendLine($"date: \"2021-05-01\"");
sb.AppendLine($"title: \"My new fancy post\"");
sb.AppendLine("tags: [csharp, azure, dotnet]");
sb.AppendLine("---");
sb.AppendLine();

sb.AppendLine("# The heading for my first post");
sb.AppendLine();







/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
*/