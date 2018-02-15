
namespace Microsoft.SharePoint.Client.Utilities
{
    public class WebAppUrlsByActionMock : WebAppUrlsByAction
    {


        public override System.String Action => ActionEx;
        public System.String ActionEx { get; set; }

        public override System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.Utilities.WebAppExtUrlPair> UrlsByExt => UrlsByExtEx;
        public System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.Utilities.WebAppExtUrlPair> UrlsByExtEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

