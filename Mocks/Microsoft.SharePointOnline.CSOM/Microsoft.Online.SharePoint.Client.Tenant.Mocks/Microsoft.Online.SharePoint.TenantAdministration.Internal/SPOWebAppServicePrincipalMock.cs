
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalMock : SPOWebAppServicePrincipal
    {


        public override System.Boolean AccountEnabled => AccountEnabledEx;
        public System.Boolean AccountEnabledEx { get; set; }

        public override System.String AppId => AppIdEx;
        public System.String AppIdEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrantCollection PermissionGrants => PermissionGrantsEx;
        public Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrantCollection PermissionGrantsEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionRequestCollection PermissionRequests => PermissionRequestsEx;
        public Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionRequestCollection PermissionRequestsEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> ReplyUrls => ReplyUrlsEx;
        public System.Collections.Generic.IEnumerable<System.String> ReplyUrlsEx { get; set; }

        public override void Update()
        {
        }

    }
}

