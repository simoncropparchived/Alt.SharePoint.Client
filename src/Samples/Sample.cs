using FakeItEasy;
using Microsoft.SharePoint.Client;
using Xunit;
#pragma warning disable 618

public class Sample
{
    [Fact]
    public void FakeItEasy()
    {
        var listItem = A.Fake<ListItem>();
        A.CallTo(() => listItem.DisplayName)
            .Returns("The Display Name");
        Assert.Equal("The Display Name", listItem.DisplayName);
    }

    [Fact]
    public void CustomMock()
    {
        MockListItem listItem = new
        (
            displayName: "The Display Name"
        );
        Assert.Equal("The Display Name", listItem.DisplayName);
    }

    class MockListItem : ListItem
    {
        public override string DisplayName => DisplayNameEx;

        public MockListItem(string displayName)
        {
            DisplayNameEx = displayName;
        }
        public string DisplayNameEx { get; }
    }
}