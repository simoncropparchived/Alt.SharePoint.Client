
namespace Microsoft.SharePoint.Client
{
    public class SPDataLeakagePreventionStatusInfoMock
    {


        public override System.Boolean ContainsConfidentialInfo => ContainsConfidentialInfoEx;
        public System.Boolean ContainsConfidentialInfoEx { get; set; }

        public override System.String ContainsConfidentialInfoLearnMoreUrl => ContainsConfidentialInfoLearnMoreUrlEx;
        public System.String ContainsConfidentialInfoLearnMoreUrlEx { get; set; }

        public override System.Boolean ExternalSharingTipsEnabled => ExternalSharingTipsEnabledEx;
        public System.Boolean ExternalSharingTipsEnabledEx { get; set; }

        public override System.String ExternalSharingTipsLearnMoreUrl => ExternalSharingTipsLearnMoreUrlEx;
        public System.String ExternalSharingTipsLearnMoreUrlEx { get; set; }

    }
}

