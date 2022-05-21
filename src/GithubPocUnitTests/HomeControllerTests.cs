using GithubPoc.Controllers;
using NUnit.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace GithubPocUnitTests;

public class Tests
{
    [Test]
    public void Index_ShouldReturnViewResult()
    {
        var logger = new LoggerFactory().CreateLogger<HomeController>();
        var controller = new HomeController(logger);
        var response = controller.Index();
        Assert.AreEqual(typeof(ViewResult), response.GetType());
    }
}