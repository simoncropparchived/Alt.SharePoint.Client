
namespace Microsoft.SharePoint.Client
{
    public class ListItemCollectionMock
    {


        public override Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPosition => ListItemCollectionPositionEx;
        public Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPositionEx { get; set; }

    }
}

