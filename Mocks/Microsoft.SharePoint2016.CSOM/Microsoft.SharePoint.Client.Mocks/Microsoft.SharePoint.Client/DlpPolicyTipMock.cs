
namespace Microsoft.SharePoint.Client
{
    public class DlpPolicyTipMock : DlpPolicyTip
    {


        public override System.String AppliedActionsText => AppliedActionsTextEx;
        public System.String AppliedActionsTextEx { get; set; }

        public override System.String ComplianceUrl => ComplianceUrlEx;
        public System.String ComplianceUrlEx { get; set; }

        public override System.String GeneralText => GeneralTextEx;
        public System.String GeneralTextEx { get; set; }

        public override System.DateTime LastProcessedTime => LastProcessedTimeEx;
        public System.DateTime LastProcessedTimeEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> MatchedConditionDescriptions => MatchedConditionDescriptionsEx;
        public System.Collections.Generic.IEnumerable<System.String> MatchedConditionDescriptionsEx { get; set; }

        public override Microsoft.SharePoint.Client.RuleOverrideOptions OverrideOptions => OverrideOptionsEx;
        public Microsoft.SharePoint.Client.RuleOverrideOptions OverrideOptionsEx { get; set; }

    }
}

