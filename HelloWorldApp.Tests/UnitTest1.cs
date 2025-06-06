using Xunit;
using HelloWorldApp;

namespace HelloWorldApp.Tests;

public class GreeterTests
{
    [Fact]
    public void SayHello_ReturnsCorrectMessage()
    {
        // Act
        var result = Greeter.SayHello();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
}

