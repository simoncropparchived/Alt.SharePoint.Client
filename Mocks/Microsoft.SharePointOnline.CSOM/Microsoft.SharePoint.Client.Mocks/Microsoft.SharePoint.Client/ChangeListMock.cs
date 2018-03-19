
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ChangeListMock : ChangeList
    {


        public override Microsoft.SharePoint.Client.ListTemplateType BaseTemplate => BaseTemplateEx;
        public Microsoft.SharePoint.Client.ListTemplateType BaseTemplateEx { get; set; }

        public override Microsoft.SharePoint.Client.User Creator => CreatorEx;
        public Microsoft.SharePoint.Client.User CreatorEx { get; set; }

        public override System.String Editor => EditorEx;
        public System.String EditorEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.String RootFolderUrl => RootFolderUrlEx;
        public System.String RootFolderUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

