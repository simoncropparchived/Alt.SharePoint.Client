
namespace Microsoft.SharePoint.Client
{
    public class SharingLinkInfoMock
    {


        public override System.Boolean IsActive => IsActiveEx;
        public System.Boolean IsActiveEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingLinkKind LinkKind => LinkKindEx;
        public Microsoft.SharePoint.Client.SharingLinkKind LinkKindEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

