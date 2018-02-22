
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FolderMock : Folder
    {


        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.ContentTypeId> ContentTypeOrder => ContentTypeOrderEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.ContentTypeId> ContentTypeOrderEx { get; set; }

        public override System.Boolean Exists => ExistsEx;
        public System.Boolean ExistsEx { get; set; }

        public override Microsoft.SharePoint.Client.FileCollection Files => FilesEx;
        public Microsoft.SharePoint.Client.FileCollection FilesEx { get; set; }

        public override System.Boolean IsWOPIEnabled => IsWOPIEnabledEx;
        public System.Boolean IsWOPIEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem ListItemAllFields => ListItemAllFieldsEx;
        public Microsoft.SharePoint.Client.ListItem ListItemAllFieldsEx { get; set; }

        public override System.Int32 ItemCount => ItemCountEx;
        public System.Int32 ItemCountEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.Folder ParentFolder => ParentFolderEx;
        public Microsoft.SharePoint.Client.Folder ParentFolderEx { get; set; }

        public override System.String ProgID => ProgIDEx;
        public System.String ProgIDEx { get; set; }

        public override Microsoft.SharePoint.Client.PropertyValues Properties => PropertiesEx;
        public Microsoft.SharePoint.Client.PropertyValues PropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ServerRelativePath => ServerRelativePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ServerRelativePathEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.StorageMetrics StorageMetrics => StorageMetricsEx;
        public Microsoft.SharePoint.Client.StorageMetrics StorageMetricsEx { get; set; }

        public override Microsoft.SharePoint.Client.FolderCollection Folders => FoldersEx;
        public Microsoft.SharePoint.Client.FolderCollection FoldersEx { get; set; }

        public override System.DateTime TimeCreated => TimeCreatedEx;
        public System.DateTime TimeCreatedEx { get; set; }

        public override System.DateTime TimeLastModified => TimeLastModifiedEx;
        public System.DateTime TimeLastModifiedEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.ContentTypeId> UniqueContentTypeOrder => UniqueContentTypeOrderEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.ContentTypeId> UniqueContentTypeOrderEx { get; set; }

        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override System.String WelcomePage => WelcomePageEx;
        public System.String WelcomePageEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeCollection GetListItemChanges(Microsoft.SharePoint.Client.ChangeQuery @query)
        {
            return GetListItemChangesEx;
        }
        public Microsoft.SharePoint.Client.ChangeCollection GetListItemChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.ChangeCollection GetChanges(Microsoft.SharePoint.Client.ChangeQuery @query)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.ChangeCollection GetChangesEx { get; set;}

        public override void Update()
        {
        }

        public override void MoveTo(System.String @newUrl)
        {
        }

        public override void MoveToUsingPath(Microsoft.SharePoint.Client.ResourcePath @newPath)
        {
        }

        public override void AddSubFolder(System.String @leafName)
        {
        }

        public override void AddSubFolderUsingPath(Microsoft.SharePoint.Client.ResourcePath @leafPath)
        {
        }

        public override void DeleteObject()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Recycle()
        {
            return RecycleEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleEx { get; set;}

    }
}

