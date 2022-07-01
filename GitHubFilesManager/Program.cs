using System.Text;
using Microsoft.AspNetCore.Identity;
using Octokit;


//string filePath = @"/Users/danperunov/Downloads/2022-06-28 23.29.51.jpg";
//var result = await gitHubClient.Repository.Content.CreateFile()
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var userApiKey = builder.Configuration["GitUser:userToken"];
var gitHubClient = new GitHubClient(new ProductHeaderValue("MyCoolFilesManager"));
gitHubClient.Credentials = new Credentials(userApiKey);

//app.MapGet("/", () => "Hello World!");
//app.Run();