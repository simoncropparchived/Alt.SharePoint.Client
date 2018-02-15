
namespace Microsoft.SharePoint.Client
{
    public class ClientContextMock : ClientContext
    {


        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

        public override Microsoft.SharePoint.Client.Site Site => SiteEx;
        public Microsoft.SharePoint.Client.Site SiteEx { get; set; }

        public override System.Boolean FormDigestHandlingEnabled => FormDigestHandlingEnabledEx;
        public System.Boolean FormDigestHandlingEnabledEx { get; set; }

        public override System.Version ServerVersion => ServerVersionEx;
        public System.Version ServerVersionEx { get; set; }

    }
}

