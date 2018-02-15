
namespace Microsoft.SharePoint.Client
{
    public class DocumentLibraryInformationMock
    {


        public override System.String AbsoluteUrl => AbsoluteUrlEx;
        public System.String AbsoluteUrlEx { get; set; }

        public override System.Boolean FromCrossFarm => FromCrossFarmEx;
        public System.Boolean FromCrossFarmEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String ModifiedFriendlyDisplay => ModifiedFriendlyDisplayEx;
        public System.String ModifiedFriendlyDisplayEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

