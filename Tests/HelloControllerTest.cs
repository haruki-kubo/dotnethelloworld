using Microsoft.AspNetCore.Mvc;
using sampleApp.Controllers;
using System;
using Xunit;

namespace sampleApp.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Get_ReturnsContentResultWithHelloWorld()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            var result = controller.Get() as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("<h1>Hello World!</h1><p>Timestamp: " + DateTime.Now + "</p>", result.Content);
            Assert.NotEqual("<h1>Wrong String</h1>", result.Content);
            Assert.Equal("text/html", result.ContentType);
        }

        
    }
}