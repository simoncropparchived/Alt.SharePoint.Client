using FakeItEasy;
using Microsoft.SharePoint.Client;
using Xunit;

public class MockingTests
{
    [Fact]
    public void Run()
    {
        var listItem = A.Fake<ListItem>();
        // set up a call to return a value
        A.CallTo(() => listItem.DisplayName).Returns("Hello");

        Assert.Equal("Hello", listItem.DisplayName);

    }
}