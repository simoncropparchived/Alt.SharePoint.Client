using FakeItEasy;
using Microsoft.SharePoint.Client;
using Xunit;

public class MockingTests
{
    [Fact]
    public void Run()
    {
        var listItem = A.Fake<ListItem>();
var context = A.Fake<ClientContext>();

        new mock
        var item = new ListItem();
        A.CallTo(() => listItem.DisplayName).Returns("Hello");

        Assert.Equal("Hello", listItem.DisplayName);
    }
}