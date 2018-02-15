
namespace Microsoft.SharePoint.Client
{
    public class MountedFolderInfoMock
    {


        public override System.String FolderUrl => FolderUrlEx;
        public System.String FolderUrlEx { get; set; }

        public override System.Boolean HasEditPermission => HasEditPermissionEx;
        public System.Boolean HasEditPermissionEx { get; set; }

        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ListTemplateType ListTemplateType => ListTemplateTypeEx;
        public Microsoft.SharePoint.Client.ListTemplateType ListTemplateTypeEx { get; set; }

        public override System.String ListViewUrl => ListViewUrlEx;
        public System.String ListViewUrlEx { get; set; }

        public override System.String WebUrl => WebUrlEx;
        public System.String WebUrlEx { get; set; }

    }
}

