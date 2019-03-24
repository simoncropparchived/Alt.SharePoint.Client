# Alt.SharePoint.Client

A clone of the SharePoint client NuGets but with the following changes

 * All public member made virtual.
 * A public parameterless constructor added to all public types.
 * Constructors of public type made public.
 * StrongNamed with a new key
 * Un-sealed

**This results in the public types being mockable for unit testing purposes.**


## Mocking examples


### Custom Mock


```csharp
[Fact]
public void CustomMock()
{
    var listItem = new MockListItem
    {
        DisplayNameEx = "The Display Name"
    };
    Assert.Equal("The Display Name", listItem.DisplayName);
}

class MockListItem : ListItem
{
    public override string DisplayName => DisplayNameEx;

    public string DisplayNameEx { get; set; }
}
```


### FakeItEasy

```csharp
[Fact]
public void FakeItEasy()
{
    var listItem = A.Fake<ListItem>();
    A.CallTo(() => listItem.DisplayName)
        .Returns("The Display Name");
    Assert.Equal("The Display Name", listItem.DisplayName);
}
```


## Source NuGets

 * [Microsoft.SharePoint2013.CSOM](https://www.nuget.org/packages/Microsoft.SharePoint2013.CSOM/)
 * [Microsoft.SharePoint2016.CSOM](https://www.nuget.org/packages/Microsoft.SharePoint2016.CSOM/)
 * [Microsoft.SharePointOnline.CSOM](https://www.nuget.org/packages/Microsoft.SharePointOnline.CSOM/)


## Produce NuGets
 
 * [Alt.SharePoint2013.CSOM](https://www.nuget.org/packages/Alt.SharePoint2013.CSOM/)
 * [Alt.SharePoint2013.CSOM.Min](https://www.nuget.org/packages/Alt.SharePoint2013.CSOM.Min/)
 * [Alt.SharePoint2016.CSOM](https://www.nuget.org/packages/Alt.SharePoint2016.CSOM/)
 * [Alt.SharePoint2016.CSOM.Min](https://www.nuget.org/packages/Alt.SharePoint2016.CSOM.Min/)
 * [Alt.SharePointOnline.CSOM](https://www.nuget.org/packages/Alt.SharePointOnline.CSOM/)
 * [Alt.SharePointOnline.CSOM.Min](https://www.nuget.org/packages/Alt.SharePointOnline.CSOM.Min/)


### Min variants

The *.Min* variants contain only `Microsoft.SharePoint.Client.dll` and `Microsoft.SharePoint.Client.Runtime.dll`.