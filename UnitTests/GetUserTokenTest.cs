using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace UnitTests;

public class Tests
{
    private IConfigurationRoot configuration;

    [SetUp]
    public void Setup()
    {
        configuration = new ConfigurationBuilder()
            .AddUserSecrets<Tests>()
            .Build();
    }

    [Test]
    public void GetUserTokenTest()
    {
        var userToken = configuration["GitUser:userToken"];
        Assert.IsNotNull(userToken);
    }
}