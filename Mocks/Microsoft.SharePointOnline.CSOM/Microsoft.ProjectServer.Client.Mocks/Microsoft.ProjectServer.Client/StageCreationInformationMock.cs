
namespace Microsoft.ProjectServer.Client
{
    public class StageCreationInformationMock : StageCreationInformation
    {


        public override Microsoft.ProjectServer.Client.StrategicImpactBehavior Behavior => BehaviorEx;
        public Microsoft.ProjectServer.Client.StrategicImpactBehavior BehaviorEx { get; set; }

        public override System.Boolean CheckInRequired => CheckInRequiredEx;
        public System.Boolean CheckInRequiredEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.StageCustomFieldCreationInformation> CustomFields => CustomFieldsEx;
        public System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.StageCustomFieldCreationInformation> CustomFieldsEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Guid PhaseId => PhaseIdEx;
        public System.Guid PhaseIdEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.StageDetailPageCreationInformation> ProjectDetailPages => ProjectDetailPagesEx;
        public System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.StageDetailPageCreationInformation> ProjectDetailPagesEx { get; set; }

        public override System.String SubmitDescription => SubmitDescriptionEx;
        public System.String SubmitDescriptionEx { get; set; }

        public override System.Guid WorkflowStatusPageId => WorkflowStatusPageIdEx;
        public System.Guid WorkflowStatusPageIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

