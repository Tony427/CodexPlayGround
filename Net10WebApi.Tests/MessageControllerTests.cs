using Moq;
using Net10WebApi.Controllers;
using Net10WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Net10WebApi.Tests
{
    public class MessageControllerTests
    {
        [Fact]
        public void Get_ReturnsMessages()
        {
            var mockService = new Mock<IMessageService>();
            mockService.Setup(s => s.GetMessages()).Returns(new List<string> { "a", "b" });
            var controller = new MessageController(mockService.Object);

            var result = controller.Get();
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var messages = Assert.IsAssignableFrom<IEnumerable<string>>(okResult.Value);
            Assert.Contains("a", messages);
            Assert.Contains("b", messages);
        }

        [Fact]
        public void Post_AddsMessage()
        {
            var mockService = new Mock<IMessageService>();
            var controller = new MessageController(mockService.Object);
            var result = controller.Post("test");
            Assert.IsType<CreatedAtActionResult>(result);
            mockService.Verify(s => s.AddMessage("test"), Times.Once);
        }
    }
}
