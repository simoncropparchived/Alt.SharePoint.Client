
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalPermissionRequestMock : SPOWebAppServicePrincipalPermissionRequest
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String PackageApproverName => PackageApproverNameEx;
        public System.String PackageApproverNameEx { get; set; }

        public override System.String PackageName => PackageNameEx;
        public System.String PackageNameEx { get; set; }

        public override System.String PackageVersion => PackageVersionEx;
        public System.String PackageVersionEx { get; set; }

        public override System.String Resource => ResourceEx;
        public System.String ResourceEx { get; set; }

        public override System.String ResourceId => ResourceIdEx;
        public System.String ResourceIdEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

        public override System.DateTime TimeRequested => TimeRequestedEx;
        public System.DateTime TimeRequestedEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrant Approve()
        {
            return ApproveEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrant ApproveEx { get; set;}

        public override void Deny()
        {
        }

    }
}

