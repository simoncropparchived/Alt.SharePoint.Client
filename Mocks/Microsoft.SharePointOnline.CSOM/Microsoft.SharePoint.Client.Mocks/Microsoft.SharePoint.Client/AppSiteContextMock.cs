
namespace Microsoft.SharePoint.Client
{
    public class AppSiteContextMock : AppSiteContext
    {


        public override System.String SiteUrl => SiteUrlEx;
        public System.String SiteUrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

