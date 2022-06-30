using System.Text;
using Microsoft.AspNetCore.Identity;
using Octokit;

Console.WriteLine("Input your token: ");
string? inputToken = Console.ReadLine();

var gitHubClient = new GitHubClient(new ProductHeaderValue("MyCoolFilesManager"));
    gitHubClient.Credentials = new Credentials(inputToken);

var login = gitHubClient.User.Current();
Console.WriteLine(login);

string filePath = @"/Users/danperunov/Downloads/2022-06-28 23.29.51.jpg";
//var result = await gitHubClient.Repository.Content.CreateFile()









/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
*/