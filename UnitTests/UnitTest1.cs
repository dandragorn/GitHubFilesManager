using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Octokit;

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
    public void Test1()
    {
        var userToken = configuration["GitUser:userToken"];
        Assert.AreEqual("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",userToken);
    }
}