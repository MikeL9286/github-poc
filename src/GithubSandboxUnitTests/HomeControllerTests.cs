using GithubSandbox.Controllers;
using NUnit.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace GithubSandboxUnitTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var logger = new LoggerFactory().CreateLogger<HomeController>();
        var controller = new HomeController(logger);
        var response = controller.Index();
        Assert.AreEqual(typeof(ViewResult), response.GetType());
    }
}