
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyAssociationMock : SPPolicyAssociation
    {


        public override System.Boolean AllowOverride => AllowOverrideEx;
        public System.Boolean AllowOverrideEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.Guid DefaultPolicyDefinitionConfigId => DefaultPolicyDefinitionConfigIdEx;
        public System.Guid DefaultPolicyDefinitionConfigIdEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Identity => IdentityEx;
        public System.Guid IdentityEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 PolicyApplyStatus => PolicyApplyStatusEx;
        public System.Int32 PolicyApplyStatusEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Guid> PolicyDefinitionConfigIds => PolicyDefinitionConfigIdsEx;
        public System.Collections.Generic.IEnumerable`1<System.Guid> PolicyDefinitionConfigIdsEx { get; set; }

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

