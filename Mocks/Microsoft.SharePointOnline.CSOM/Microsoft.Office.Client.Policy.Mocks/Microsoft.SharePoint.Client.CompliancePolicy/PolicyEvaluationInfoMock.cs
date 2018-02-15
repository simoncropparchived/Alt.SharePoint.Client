
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class PolicyEvaluationInfoMock : PolicyEvaluationInfo
    {


        public override System.String[] ApplicablePolicies => ApplicablePoliciesEx;
        public System.String[] ApplicablePoliciesEx { get; set; }

        public override Microsoft.SharePoint.Client.CompliancePolicy.DlpAccessScope DlpAccessScope => DlpAccessScopeEx;
        public Microsoft.SharePoint.Client.CompliancePolicy.DlpAccessScope DlpAccessScopeEx { get; set; }

        public override System.String[] MatchedRules => MatchedRulesEx;
        public System.String[] MatchedRulesEx { get; set; }

        public override System.String[] OverriddenRules => OverriddenRulesEx;
        public System.String[] OverriddenRulesEx { get; set; }

    }
}

