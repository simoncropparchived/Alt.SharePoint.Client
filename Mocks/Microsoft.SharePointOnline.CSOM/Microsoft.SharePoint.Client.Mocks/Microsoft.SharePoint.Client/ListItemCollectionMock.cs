
namespace Microsoft.SharePoint.Client
{
    public class ListItemCollectionMock : ListItemCollection
    {


        public override Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPosition => ListItemCollectionPositionEx;
        public Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPositionEx { get; set; }

    }
}

