
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class HubSitePropertiesMock : HubSiteProperties
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid ID => IDEx;
        public System.Guid IDEx { get; set; }

        public override System.String LogoUrl => LogoUrlEx;
        public System.String LogoUrlEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.String SiteUrl => SiteUrlEx;
        public System.String SiteUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override void Update()
        {
        }

    }
}

