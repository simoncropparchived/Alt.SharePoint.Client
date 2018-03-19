
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class NavigationNodeMock : NavigationNode
    {


        public override Microsoft.SharePoint.Client.NavigationNodeCollection Children => ChildrenEx;
        public Microsoft.SharePoint.Client.NavigationNodeCollection ChildrenEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.Boolean IsDocLib => IsDocLibEx;
        public System.Boolean IsDocLibEx { get; set; }

        public override System.Boolean IsExternal => IsExternalEx;
        public System.Boolean IsExternalEx { get; set; }

        public override System.Boolean IsVisible => IsVisibleEx;
        public System.Boolean IsVisibleEx { get; set; }

        public override Microsoft.SharePoint.Client.ListTemplateType ListTemplateType => ListTemplateTypeEx;
        public Microsoft.SharePoint.Client.ListTemplateType ListTemplateTypeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

