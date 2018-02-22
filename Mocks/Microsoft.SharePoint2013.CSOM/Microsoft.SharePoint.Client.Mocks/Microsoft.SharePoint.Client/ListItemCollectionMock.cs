
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemCollectionMock : ListItemCollection
    {


        public override Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPosition => ListItemCollectionPositionEx;
        public Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPositionEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem GetById(System.String @id)
        {
            return GetByIdStringEx;
        }
        public Microsoft.SharePoint.Client.ListItem GetByIdStringEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem GetById(System.Int32 @id)
        {
            return GetByIdInt32Ex;
        }
        public Microsoft.SharePoint.Client.ListItem GetByIdInt32Ex { get; set;}

    }
}

