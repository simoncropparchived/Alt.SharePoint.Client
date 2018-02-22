
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class SPOUserSessionRevocationResultMock : SPOUserSessionRevocationResult
    {


        public override Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationState State => StateEx;
        public Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationState StateEx { get; set; }

    }
}

