
namespace Microsoft.SharePoint.Client
{
    public class CreatablesInfoMock
    {


        public override System.Boolean CanCreateFolders => CanCreateFoldersEx;
        public System.Boolean CanCreateFoldersEx { get; set; }

        public override System.Boolean CanCreateItems => CanCreateItemsEx;
        public System.Boolean CanCreateItemsEx { get; set; }

        public override System.Boolean CanUploadFiles => CanUploadFilesEx;
        public System.Boolean CanUploadFilesEx { get; set; }

        public override Microsoft.SharePoint.Client.CreatableItemInfoCollection CreatablesCollection => CreatablesCollectionEx;
        public Microsoft.SharePoint.Client.CreatableItemInfoCollection CreatablesCollectionEx { get; set; }

    }
}

