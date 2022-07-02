using GitActions;
using Microsoft.Extensions.Configuration;


var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables()
    .Build();


// github variables
var login = "dandragorn";
var repo = "TestRepo";
var branch = "main";
string targetFile = "test_pic.jpg";
var userToken = configuration["GitUser:userToken"];

string filePath = @"/Users/danperunov/Downloads/test_pic.jpg";

GitUploadFiles uploadTask = new GitUploadFiles();
await uploadTask.UploadFile(login, repo, branch, targetFile, userToken, filePath);

/*try
{
    // try to get the file
}
catch (NotFoundException)
{
    //if file is not found - create it

}*/


Console.ReadKey();