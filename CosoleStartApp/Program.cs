using GitActions;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

// github variables
var login = "dandragorn";
var repo = "TestRepo";
var branch = "main";
var targetFile = "test_pic.jpg";
var userToken = configuration["GitUser:userToken"];

var filePath = @"/Users/danperunov/Downloads/test_pic.jpg";

var uploadTask = new GitUploadFiles();
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