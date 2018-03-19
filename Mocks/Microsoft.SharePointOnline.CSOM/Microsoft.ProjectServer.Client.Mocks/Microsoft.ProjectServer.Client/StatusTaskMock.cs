
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StatusTaskMock : StatusTask
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.TimeSpan ActualWorkTimeSpan => ActualWorkTimeSpanEx;
        public System.TimeSpan ActualWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override System.DateTime Deadline => DeadlineEx;
        public System.DateTime DeadlineEx { get; set; }

        public override System.String Duration => DurationEx;
        public System.String DurationEx { get; set; }

        public override System.TimeSpan DurationTimeSpan => DurationTimeSpanEx;
        public System.TimeSpan DurationTimeSpanEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Overtime => OvertimeEx;
        public System.String OvertimeEx { get; set; }

        public override System.TimeSpan OvertimeTimeSpan => OvertimeTimeSpanEx;
        public System.TimeSpan OvertimeTimeSpanEx { get; set; }

        public override System.Int16 PercentComplete => PercentCompleteEx;
        public System.Int16 PercentCompleteEx { get; set; }

        public override System.Int16 PercentWorkComplete => PercentWorkCompleteEx;
        public System.Int16 PercentWorkCompleteEx { get; set; }

        public override System.Int16 PhysicalPercentComplete => PhysicalPercentCompleteEx;
        public System.Int16 PhysicalPercentCompleteEx { get; set; }

        public override System.Guid ProjectTaskId => ProjectTaskIdEx;
        public System.Guid ProjectTaskIdEx { get; set; }

        public override System.String RegularWork => RegularWorkEx;
        public System.String RegularWorkEx { get; set; }

        public override System.TimeSpan RegularWorkTimeSpan => RegularWorkTimeSpanEx;
        public System.TimeSpan RegularWorkTimeSpanEx { get; set; }

        public override System.String RemainingDuration => RemainingDurationEx;
        public System.String RemainingDurationEx { get; set; }

        public override System.TimeSpan RemainingDurationTimeSpan => RemainingDurationTimeSpanEx;
        public System.TimeSpan RemainingDurationTimeSpanEx { get; set; }

        public override System.String RemainingOvertime => RemainingOvertimeEx;
        public System.String RemainingOvertimeEx { get; set; }

        public override System.TimeSpan RemainingOvertimeTimeSpan => RemainingOvertimeTimeSpanEx;
        public System.TimeSpan RemainingOvertimeTimeSpanEx { get; set; }

        public override System.String RemainingWork => RemainingWorkEx;
        public System.String RemainingWorkEx { get; set; }

        public override System.TimeSpan RemainingWorkTimeSpan => RemainingWorkTimeSpanEx;
        public System.TimeSpan RemainingWorkTimeSpanEx { get; set; }

        public override System.DateTime Resume => ResumeEx;
        public System.DateTime ResumeEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override Microsoft.SharePoint.Client.User StatusManager => StatusManagerEx;
        public Microsoft.SharePoint.Client.User StatusManagerEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

        public override void RefreshLoad()
        {
        }

    }
}

