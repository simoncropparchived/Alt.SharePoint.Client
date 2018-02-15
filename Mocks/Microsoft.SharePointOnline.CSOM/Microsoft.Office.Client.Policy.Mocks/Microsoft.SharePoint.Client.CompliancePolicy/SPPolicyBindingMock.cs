
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyBindingMock : SPPolicyBinding
    {


        public override System.Int32 BindingType => BindingTypeEx;
        public System.Int32 BindingTypeEx { get; set; }

        public override System.Guid Identity => IdentityEx;
        public System.Guid IdentityEx { get; set; }

        public override System.Boolean IsExempt => IsExemptEx;
        public System.Boolean IsExemptEx { get; set; }

        public override System.Int32 Mode => ModeEx;
        public System.Int32 ModeEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 PolicyApplyStatus => PolicyApplyStatusEx;
        public System.Int32 PolicyApplyStatusEx { get; set; }

        public override System.Guid PolicyAssociationConfigId => PolicyAssociationConfigIdEx;
        public System.Guid PolicyAssociationConfigIdEx { get; set; }

        public override System.Guid PolicyDefinitionConfigId => PolicyDefinitionConfigIdEx;
        public System.Guid PolicyDefinitionConfigIdEx { get; set; }

        public override System.Guid PolicyRuleConfigId => PolicyRuleConfigIdEx;
        public System.Guid PolicyRuleConfigIdEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

        public override System.Int32 Source => SourceEx;
        public System.Int32 SourceEx { get; set; }

        public override System.Guid Version => VersionEx;
        public System.Guid VersionEx { get; set; }

        public override System.DateTime WhenAppliedUTC => WhenAppliedUTCEx;
        public System.DateTime WhenAppliedUTCEx { get; set; }

        public override System.DateTime WhenChangedUTC => WhenChangedUTCEx;
        public System.DateTime WhenChangedUTCEx { get; set; }

        public override System.DateTime WhenCreatedUTC => WhenCreatedUTCEx;
        public System.DateTime WhenCreatedUTCEx { get; set; }

        public override System.Int32 Workload => WorkloadEx;
        public System.Int32 WorkloadEx { get; set; }

    }
}

