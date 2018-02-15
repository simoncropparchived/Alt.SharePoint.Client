
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetWorkMock : TimeSheetWork
    {


        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.TimeSpan ActualWorkTimeSpan => ActualWorkTimeSpanEx;
        public System.TimeSpan ActualWorkTimeSpanEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String NonBillableOvertimeWork => NonBillableOvertimeWorkEx;
        public System.String NonBillableOvertimeWorkEx { get; set; }

        public override System.TimeSpan NonBillableOvertimeWorkTimeSpan => NonBillableOvertimeWorkTimeSpanEx;
        public System.TimeSpan NonBillableOvertimeWorkTimeSpanEx { get; set; }

        public override System.String NonBillableWork => NonBillableWorkEx;
        public System.String NonBillableWorkEx { get; set; }

        public override System.TimeSpan NonBillableWorkTimeSpan => NonBillableWorkTimeSpanEx;
        public System.TimeSpan NonBillableWorkTimeSpanEx { get; set; }

        public override System.String OvertimeWork => OvertimeWorkEx;
        public System.String OvertimeWorkEx { get; set; }

        public override System.TimeSpan OvertimeWorkTimeSpan => OvertimeWorkTimeSpanEx;
        public System.TimeSpan OvertimeWorkTimeSpanEx { get; set; }

        public override System.String PlannedWork => PlannedWorkEx;
        public System.String PlannedWorkEx { get; set; }

        public override System.TimeSpan PlannedWorkTimeSpan => PlannedWorkTimeSpanEx;
        public System.TimeSpan PlannedWorkTimeSpanEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

    }
}

