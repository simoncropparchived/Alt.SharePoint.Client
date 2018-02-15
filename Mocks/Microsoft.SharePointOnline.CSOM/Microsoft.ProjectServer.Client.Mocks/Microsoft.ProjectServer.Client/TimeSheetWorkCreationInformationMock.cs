
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetWorkCreationInformationMock
    {


        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.String NonBillableOvertimeWork => NonBillableOvertimeWorkEx;
        public System.String NonBillableOvertimeWorkEx { get; set; }

        public override System.String NonBillableWork => NonBillableWorkEx;
        public System.String NonBillableWorkEx { get; set; }

        public override System.String OvertimeWork => OvertimeWorkEx;
        public System.String OvertimeWorkEx { get; set; }

        public override System.String PlannedWork => PlannedWorkEx;
        public System.String PlannedWorkEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

