
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPOTenantCdnPolicyMock
    {


        public override Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnPolicyType PolicyType => PolicyTypeEx;
        public Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnPolicyType PolicyTypeEx { get; set; }

        public override System.String PolicyValue => PolicyValueEx;
        public System.String PolicyValueEx { get; set; }

    }
}

