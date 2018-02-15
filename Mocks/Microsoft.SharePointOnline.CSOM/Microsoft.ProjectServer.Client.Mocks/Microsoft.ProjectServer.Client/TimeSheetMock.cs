
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetMock
    {


        public override System.String Comments => CommentsEx;
        public System.String CommentsEx { get; set; }

        public override Microsoft.SharePoint.Client.User Creator => CreatorEx;
        public Microsoft.SharePoint.Client.User CreatorEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetEntryMode EntryMode => EntryModeEx;
        public Microsoft.ProjectServer.Client.TimeSheetEntryMode EntryModeEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsControlledByOwner => IsControlledByOwnerEx;
        public System.Boolean IsControlledByOwnerEx { get; set; }

        public override System.Boolean IsProcessed => IsProcessedEx;
        public System.Boolean IsProcessedEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetLineCollection Lines => LinesEx;
        public Microsoft.ProjectServer.Client.TimeSheetLineCollection LinesEx { get; set; }

        public override Microsoft.SharePoint.Client.User Manager => ManagerEx;
        public Microsoft.SharePoint.Client.User ManagerEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetPeriod Period => PeriodEx;
        public Microsoft.ProjectServer.Client.TimeSheetPeriod PeriodEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetStatus Status => StatusEx;
        public Microsoft.ProjectServer.Client.TimeSheetStatus StatusEx { get; set; }

        public override System.String TotalActualWork => TotalActualWorkEx;
        public System.String TotalActualWorkEx { get; set; }

        public override System.TimeSpan TotalActualWorkTimeSpan => TotalActualWorkTimeSpanEx;
        public System.TimeSpan TotalActualWorkTimeSpanEx { get; set; }

        public override System.String TotalNonBillableOvertimeWork => TotalNonBillableOvertimeWorkEx;
        public System.String TotalNonBillableOvertimeWorkEx { get; set; }

        public override System.TimeSpan TotalNonBillableOvertimeWorkTimeSpan => TotalNonBillableOvertimeWorkTimeSpanEx;
        public System.TimeSpan TotalNonBillableOvertimeWorkTimeSpanEx { get; set; }

        public override System.String TotalNonBillableWork => TotalNonBillableWorkEx;
        public System.String TotalNonBillableWorkEx { get; set; }

        public override System.TimeSpan TotalNonBillableWorkTimeSpan => TotalNonBillableWorkTimeSpanEx;
        public System.TimeSpan TotalNonBillableWorkTimeSpanEx { get; set; }

        public override System.String TotalOvertimeWork => TotalOvertimeWorkEx;
        public System.String TotalOvertimeWorkEx { get; set; }

        public override System.TimeSpan TotalOvertimeWorkTimeSpan => TotalOvertimeWorkTimeSpanEx;
        public System.TimeSpan TotalOvertimeWorkTimeSpanEx { get; set; }

        public override System.String TotalWork => TotalWorkEx;
        public System.String TotalWorkEx { get; set; }

        public override System.TimeSpan TotalWorkTimeSpan => TotalWorkTimeSpanEx;
        public System.TimeSpan TotalWorkTimeSpanEx { get; set; }

        public override System.Byte WeekStartsOn => WeekStartsOnEx;
        public System.Byte WeekStartsOnEx { get; set; }

    }
}

