
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalPermissionRequestMock : SPOWebAppServicePrincipalPermissionRequest
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Resource => ResourceEx;
        public System.String ResourceEx { get; set; }

        public override System.String ResourceId => ResourceIdEx;
        public System.String ResourceIdEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

    }
}

