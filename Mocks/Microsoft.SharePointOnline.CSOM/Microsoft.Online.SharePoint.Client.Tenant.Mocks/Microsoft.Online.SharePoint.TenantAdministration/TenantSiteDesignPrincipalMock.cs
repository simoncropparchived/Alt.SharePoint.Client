
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantSiteDesignPrincipalMock : TenantSiteDesignPrincipal
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String PrincipalName => PrincipalNameEx;
        public System.String PrincipalNameEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesignPrincipalRights Rights => RightsEx;
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesignPrincipalRights RightsEx { get; set; }

    }
}

