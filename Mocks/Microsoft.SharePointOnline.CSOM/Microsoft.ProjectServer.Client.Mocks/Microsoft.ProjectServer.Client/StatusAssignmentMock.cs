
namespace Microsoft.ProjectServer.Client
{
    public class StatusAssignmentMock : StatusAssignment
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override System.DateTime ActualFinish => ActualFinishEx;
        public System.DateTime ActualFinishEx { get; set; }

        public override System.String ActualOvertime => ActualOvertimeEx;
        public System.String ActualOvertimeEx { get; set; }

        public override System.TimeSpan ActualOvertimeTimeSpan => ActualOvertimeTimeSpanEx;
        public System.TimeSpan ActualOvertimeTimeSpanEx { get; set; }

        public override System.DateTime ActualStart => ActualStartEx;
        public System.DateTime ActualStartEx { get; set; }

        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.TimeSpan ActualWorkTimeSpan => ActualWorkTimeSpanEx;
        public System.TimeSpan ActualWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusApprovalType ApprovalStatus => ApprovalStatusEx;
        public Microsoft.ProjectServer.Client.StatusApprovalType ApprovalStatusEx { get; set; }

        public override System.String Comments => CommentsEx;
        public System.String CommentsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusAssignmentHistoryLineCollection History => HistoryEx;
        public Microsoft.ProjectServer.Client.StatusAssignmentHistoryLineCollection HistoryEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsConfirmed => IsConfirmedEx;
        public System.Boolean IsConfirmedEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Overtime => OvertimeEx;
        public System.String OvertimeEx { get; set; }

        public override System.TimeSpan OvertimeTimeSpan => OvertimeTimeSpanEx;
        public System.TimeSpan OvertimeTimeSpanEx { get; set; }

        public override System.Int16 PercentComplete => PercentCompleteEx;
        public System.Int16 PercentCompleteEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedProject Project => ProjectEx;
        public Microsoft.ProjectServer.Client.PublishedProject ProjectEx { get; set; }

        public override System.String RegularWork => RegularWorkEx;
        public System.String RegularWorkEx { get; set; }

        public override System.TimeSpan RegularWorkTimeSpan => RegularWorkTimeSpanEx;
        public System.TimeSpan RegularWorkTimeSpanEx { get; set; }

        public override System.String RemainingOvertime => RemainingOvertimeEx;
        public System.String RemainingOvertimeEx { get; set; }

        public override System.TimeSpan RemainingOvertimeTimeSpan => RemainingOvertimeTimeSpanEx;
        public System.TimeSpan RemainingOvertimeTimeSpanEx { get; set; }

        public override System.String RemainingWork => RemainingWorkEx;
        public System.String RemainingWorkEx { get; set; }

        public override System.TimeSpan RemainingWorkTimeSpan => RemainingWorkTimeSpanEx;
        public System.TimeSpan RemainingWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResource Resource => ResourceEx;
        public Microsoft.ProjectServer.Client.EnterpriseResource ResourceEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusTask Task => TaskEx;
        public Microsoft.ProjectServer.Client.StatusTask TaskEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

    }
}

