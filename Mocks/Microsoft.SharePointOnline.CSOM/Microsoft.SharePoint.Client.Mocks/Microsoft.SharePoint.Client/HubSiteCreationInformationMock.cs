
namespace Microsoft.SharePoint.Client
{
    public class HubSiteCreationInformationMock : HubSiteCreationInformation
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String LogoUrl => LogoUrlEx;
        public System.String LogoUrlEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.String SiteUrl => SiteUrlEx;
        public System.String SiteUrlEx { get; set; }

        public override System.String Targets => TargetsEx;
        public System.String TargetsEx { get; set; }

        public override System.Guid TenantInstanceId => TenantInstanceIdEx;
        public System.Guid TenantInstanceIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

