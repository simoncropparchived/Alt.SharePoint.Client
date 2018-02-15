
namespace Microsoft.ProjectServer.Client
{
    public class ProjectEngagementMock : ProjectEngagement
    {


        public override System.DateTime ApprovedFinish => ApprovedFinishEx;
        public System.DateTime ApprovedFinishEx { get; set; }

        public override System.Double ApprovedMaxUnits => ApprovedMaxUnitsEx;
        public System.Double ApprovedMaxUnitsEx { get; set; }

        public override System.DateTime ApprovedStart => ApprovedStartEx;
        public System.DateTime ApprovedStartEx { get; set; }

        public override System.String ApprovedWork => ApprovedWorkEx;
        public System.String ApprovedWorkEx { get; set; }

        public override System.TimeSpan ApprovedWorkTimeSpan => ApprovedWorkTimeSpanEx;
        public System.TimeSpan ApprovedWorkTimeSpanEx { get; set; }

        public override System.Boolean HasUnsubmittedChanges => HasUnsubmittedChangesEx;
        public System.Boolean HasUnsubmittedChangesEx { get; set; }

        public override System.DateTime RequestedFinish => RequestedFinishEx;
        public System.DateTime RequestedFinishEx { get; set; }

        public override System.Double RequestedMaxUnits => RequestedMaxUnitsEx;
        public System.Double RequestedMaxUnitsEx { get; set; }

        public override System.DateTime RequestedStart => RequestedStartEx;
        public System.DateTime RequestedStartEx { get; set; }

        public override System.String RequestedWork => RequestedWorkEx;
        public System.String RequestedWorkEx { get; set; }

        public override System.TimeSpan RequestedWorkTimeSpan => RequestedWorkTimeSpanEx;
        public System.TimeSpan RequestedWorkTimeSpanEx { get; set; }

    }
}

