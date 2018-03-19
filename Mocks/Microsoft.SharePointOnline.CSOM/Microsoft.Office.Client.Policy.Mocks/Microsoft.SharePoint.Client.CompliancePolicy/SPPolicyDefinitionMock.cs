
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyDefinitionMock : SPPolicyDefinition
    {


        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.String CreatedBy => CreatedByEx;
        public System.String CreatedByEx { get; set; }

        public override System.Guid DefaultPolicyRuleConfigId => DefaultPolicyRuleConfigIdEx;
        public System.Guid DefaultPolicyRuleConfigIdEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean Enabled => EnabledEx;
        public System.Boolean EnabledEx { get; set; }

        public override System.Guid Identity => IdentityEx;
        public System.Guid IdentityEx { get; set; }

        public override System.String LastModifiedBy => LastModifiedByEx;
        public System.String LastModifiedByEx { get; set; }

        public override System.Int32 Mode => ModeEx;
        public System.Int32 ModeEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 Priority => PriorityEx;
        public System.Int32 PriorityEx { get; set; }

        public override System.Int32 Scenario => ScenarioEx;
        public System.Int32 ScenarioEx { get; set; }

        public override System.Int32 Source => SourceEx;
        public System.Int32 SourceEx { get; set; }

        public override System.Guid Version => VersionEx;
        public System.Guid VersionEx { get; set; }

        public override System.DateTime WhenChangedUTC => WhenChangedUTCEx;
        public System.DateTime WhenChangedUTCEx { get; set; }

        public override System.DateTime WhenCreatedUTC => WhenCreatedUTCEx;
        public System.DateTime WhenCreatedUTCEx { get; set; }

    }
}

