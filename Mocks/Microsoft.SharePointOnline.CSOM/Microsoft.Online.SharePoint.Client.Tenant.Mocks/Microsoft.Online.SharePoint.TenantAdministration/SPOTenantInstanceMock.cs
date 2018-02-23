
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPOTenantInstanceMock : SPOTenantInstance
    {


        public override System.String DataLocation => DataLocationEx;
        public System.String DataLocationEx { get; set; }

        public override System.Boolean IsDefaultDataLocation => IsDefaultDataLocationEx;
        public System.Boolean IsDefaultDataLocationEx { get; set; }

        public override System.String MySiteHostUrl => MySiteHostUrlEx;
        public System.String MySiteHostUrlEx { get; set; }

        public override System.String PortalUrl => PortalUrlEx;
        public System.String PortalUrlEx { get; set; }

        public override System.String RootSiteUrl => RootSiteUrlEx;
        public System.String RootSiteUrlEx { get; set; }

        public override System.String TenantAdminUrl => TenantAdminUrlEx;
        public System.String TenantAdminUrlEx { get; set; }

    }
}

