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

//local path to the file
var filePath = @"/Users/danperunov/Downloads/test_pic.jpg";

//converting file to the string
ConvertToBase64String filePathToString = new();
string content = filePathToString.GetBase64String(filePath);

//uploading file
GitUploadFiles uploadTask = new();
await uploadTask.UploadFile(login, repo, branch, targetFile, userToken, content);

/*try
{
    // try to get the file
}
catch (NotFoundException)
{
    //if file is not found - create it

}*/

Console.ReadKey();