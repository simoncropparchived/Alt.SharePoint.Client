
namespace Microsoft.ProjectServer.Client
{
    public class StageMock
    {


        public override Microsoft.ProjectServer.Client.StrategicImpactBehavior Behavior => BehaviorEx;
        public Microsoft.ProjectServer.Client.StrategicImpactBehavior BehaviorEx { get; set; }

        public override System.Boolean CheckInRequired => CheckInRequiredEx;
        public System.Boolean CheckInRequiredEx { get; set; }

        public override Microsoft.ProjectServer.Client.StageCustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.StageCustomFieldCollection CustomFieldsEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.Phase Phase => PhaseEx;
        public Microsoft.ProjectServer.Client.Phase PhaseEx { get; set; }

        public override Microsoft.ProjectServer.Client.StageDetailPageCollection ProjectDetailPages => ProjectDetailPagesEx;
        public Microsoft.ProjectServer.Client.StageDetailPageCollection ProjectDetailPagesEx { get; set; }

        public override System.String SubmitDescription => SubmitDescriptionEx;
        public System.String SubmitDescriptionEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectDetailPage WorkflowStatusPage => WorkflowStatusPageEx;
        public Microsoft.ProjectServer.Client.ProjectDetailPage WorkflowStatusPageEx { get; set; }

    }
}

