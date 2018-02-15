
namespace Microsoft.SharePoint.Client
{
    public class NavigationNodeCreationInformationMock
    {


        public override System.Boolean AsLastNode => AsLastNodeEx;
        public System.Boolean AsLastNodeEx { get; set; }

        public override System.Boolean IsExternal => IsExternalEx;
        public System.Boolean IsExternalEx { get; set; }

        public override Microsoft.SharePoint.Client.NavigationNode PreviousNode => PreviousNodeEx;
        public Microsoft.SharePoint.Client.NavigationNode PreviousNodeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

