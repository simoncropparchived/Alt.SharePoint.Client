
namespace Microsoft.SharePoint.Client
{
    public class ListItemCreationInformationUsingPathMock
    {


        public override Microsoft.SharePoint.Client.ResourcePath FolderPath => FolderPathEx;
        public Microsoft.SharePoint.Client.ResourcePath FolderPathEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath LeafName => LeafNameEx;
        public Microsoft.SharePoint.Client.ResourcePath LeafNameEx { get; set; }

        public override Microsoft.SharePoint.Client.FileSystemObjectType UnderlyingObjectType => UnderlyingObjectTypeEx;
        public Microsoft.SharePoint.Client.FileSystemObjectType UnderlyingObjectTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

