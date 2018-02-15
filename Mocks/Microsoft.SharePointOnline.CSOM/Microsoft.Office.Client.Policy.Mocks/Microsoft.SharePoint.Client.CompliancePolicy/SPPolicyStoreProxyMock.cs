
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyStoreProxyMock
    {


        public override System.String PolicyStoreUrl => PolicyStoreUrlEx;
        public System.String PolicyStoreUrlEx { get; set; }

        public override System.String ReviewCenterUrl => ReviewCenterUrlEx;
        public System.String ReviewCenterUrlEx { get; set; }

    }
}

