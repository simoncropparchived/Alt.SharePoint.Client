
namespace Microsoft.SharePoint.Client
{
    public class ListItemMock : ListItem
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override Microsoft.SharePoint.Client.AttachmentCollection AttachmentFiles => AttachmentFilesEx;
        public Microsoft.SharePoint.Client.AttachmentCollection AttachmentFilesEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentType ContentType => ContentTypeEx;
        public Microsoft.SharePoint.Client.ContentType ContentTypeEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissions => EffectiveBasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUI => EffectiveBasePermissionsForUIEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUIEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsHtml => FieldValuesAsHtmlEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsHtmlEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsText => FieldValuesAsTextEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsTextEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesForEdit => FieldValuesForEditEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesForEditEx { get; set; }

        public override Microsoft.SharePoint.Client.File File => FileEx;
        public Microsoft.SharePoint.Client.File FileEx { get; set; }

        public override Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectType => FileSystemObjectTypeEx;
        public Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Folder Folder => FolderEx;
        public Microsoft.SharePoint.Client.Folder FolderEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override Microsoft.SharePoint.Client.List ParentList => ParentListEx;
        public Microsoft.SharePoint.Client.List ParentListEx { get; set; }

        public override System.String Client_Title => Client_TitleEx;
        public System.String Client_TitleEx { get; set; }

    }
}

