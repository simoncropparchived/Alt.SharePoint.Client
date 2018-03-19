
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TaskMock : Task
    {


        public override System.Double ActualCostWorkPerformed => ActualCostWorkPerformedEx;
        public System.Double ActualCostWorkPerformedEx { get; set; }

        public override System.String ActualDuration => ActualDurationEx;
        public System.String ActualDurationEx { get; set; }

        public override System.TimeSpan ActualDurationTimeSpan => ActualDurationTimeSpanEx;
        public System.TimeSpan ActualDurationTimeSpanEx { get; set; }

        public override System.Double ActualOvertimeCost => ActualOvertimeCostEx;
        public System.Double ActualOvertimeCostEx { get; set; }

        public override System.String ActualOvertimeWork => ActualOvertimeWorkEx;
        public System.String ActualOvertimeWorkEx { get; set; }

        public override System.TimeSpan ActualOvertimeWorkTimeSpan => ActualOvertimeWorkTimeSpanEx;
        public System.TimeSpan ActualOvertimeWorkTimeSpanEx { get; set; }

        public override System.Double BaselineCost => BaselineCostEx;
        public System.Double BaselineCostEx { get; set; }

        public override System.String BaselineDuration => BaselineDurationEx;
        public System.String BaselineDurationEx { get; set; }

        public override System.TimeSpan BaselineDurationTimeSpan => BaselineDurationTimeSpanEx;
        public System.TimeSpan BaselineDurationTimeSpanEx { get; set; }

        public override System.DateTime BaselineFinish => BaselineFinishEx;
        public System.DateTime BaselineFinishEx { get; set; }

        public override System.DateTime BaselineStart => BaselineStartEx;
        public System.DateTime BaselineStartEx { get; set; }

        public override System.String BaselineWork => BaselineWorkEx;
        public System.String BaselineWorkEx { get; set; }

        public override System.TimeSpan BaselineWorkTimeSpan => BaselineWorkTimeSpanEx;
        public System.TimeSpan BaselineWorkTimeSpanEx { get; set; }

        public override System.Double BudgetCost => BudgetCostEx;
        public System.Double BudgetCostEx { get; set; }

        public override System.Double BudgetedCostWorkPerformed => BudgetedCostWorkPerformedEx;
        public System.Double BudgetedCostWorkPerformedEx { get; set; }

        public override System.Double BudgetedCostWorkScheduled => BudgetedCostWorkScheduledEx;
        public System.Double BudgetedCostWorkScheduledEx { get; set; }

        public override System.String Contact => ContactEx;
        public System.String ContactEx { get; set; }

        public override System.Double CostPerformanceIndex => CostPerformanceIndexEx;
        public System.Double CostPerformanceIndexEx { get; set; }

        public override System.Double CostVariance => CostVarianceEx;
        public System.Double CostVarianceEx { get; set; }

        public override System.Double CostVarianceAtCompletion => CostVarianceAtCompletionEx;
        public System.Double CostVarianceAtCompletionEx { get; set; }

        public override System.Int32 CostVariancePercentage => CostVariancePercentageEx;
        public System.Int32 CostVariancePercentageEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.Double CurrentCostVariance => CurrentCostVarianceEx;
        public System.Double CurrentCostVarianceEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override System.String DurationVariance => DurationVarianceEx;
        public System.String DurationVarianceEx { get; set; }

        public override System.TimeSpan DurationVarianceTimeSpan => DurationVarianceTimeSpanEx;
        public System.TimeSpan DurationVarianceTimeSpanEx { get; set; }

        public override System.DateTime EarliestFinish => EarliestFinishEx;
        public System.DateTime EarliestFinishEx { get; set; }

        public override System.DateTime EarliestStart => EarliestStartEx;
        public System.DateTime EarliestStartEx { get; set; }

        public override System.Double EstimateAtCompletion => EstimateAtCompletionEx;
        public System.Double EstimateAtCompletionEx { get; set; }

        public override System.String FinishSlack => FinishSlackEx;
        public System.String FinishSlackEx { get; set; }

        public override System.TimeSpan FinishSlackTimeSpan => FinishSlackTimeSpanEx;
        public System.TimeSpan FinishSlackTimeSpanEx { get; set; }

        public override System.String FinishVariance => FinishVarianceEx;
        public System.String FinishVarianceEx { get; set; }

        public override System.TimeSpan FinishVarianceTimeSpan => FinishVarianceTimeSpanEx;
        public System.TimeSpan FinishVarianceTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.FixedCostAccrual FixedCostAccrual => FixedCostAccrualEx;
        public Microsoft.ProjectServer.Client.FixedCostAccrual FixedCostAccrualEx { get; set; }

        public override System.String FreeSlack => FreeSlackEx;
        public System.String FreeSlackEx { get; set; }

        public override System.TimeSpan FreeSlackTimeSpan => FreeSlackTimeSpanEx;
        public System.TimeSpan FreeSlackTimeSpanEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IgnoreResourceCalendar => IgnoreResourceCalendarEx;
        public System.Boolean IgnoreResourceCalendarEx { get; set; }

        public override System.Boolean IsCritical => IsCriticalEx;
        public System.Boolean IsCriticalEx { get; set; }

        public override System.Boolean IsEffortDriven => IsEffortDrivenEx;
        public System.Boolean IsEffortDrivenEx { get; set; }

        public override System.Boolean IsExternalTask => IsExternalTaskEx;
        public System.Boolean IsExternalTaskEx { get; set; }

        public override System.Boolean IsOverAllocated => IsOverAllocatedEx;
        public System.Boolean IsOverAllocatedEx { get; set; }

        public override System.Boolean IsRecurring => IsRecurringEx;
        public System.Boolean IsRecurringEx { get; set; }

        public override System.Boolean IsRecurringSummary => IsRecurringSummaryEx;
        public System.Boolean IsRecurringSummaryEx { get; set; }

        public override System.Boolean IsRolledUp => IsRolledUpEx;
        public System.Boolean IsRolledUpEx { get; set; }

        public override System.Boolean IsSubProject => IsSubProjectEx;
        public System.Boolean IsSubProjectEx { get; set; }

        public override System.Boolean IsSubProjectReadOnly => IsSubProjectReadOnlyEx;
        public System.Boolean IsSubProjectReadOnlyEx { get; set; }

        public override System.Boolean IsSubProjectScheduledFromFinish => IsSubProjectScheduledFromFinishEx;
        public System.Boolean IsSubProjectScheduledFromFinishEx { get; set; }

        public override System.Boolean IsSummary => IsSummaryEx;
        public System.Boolean IsSummaryEx { get; set; }

        public override System.DateTime LatestFinish => LatestFinishEx;
        public System.DateTime LatestFinishEx { get; set; }

        public override System.DateTime LatestStart => LatestStartEx;
        public System.DateTime LatestStartEx { get; set; }

        public override System.String LevelingDelay => LevelingDelayEx;
        public System.String LevelingDelayEx { get; set; }

        public override System.TimeSpan LevelingDelayTimeSpan => LevelingDelayTimeSpanEx;
        public System.TimeSpan LevelingDelayTimeSpanEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.String OutlinePosition => OutlinePositionEx;
        public System.String OutlinePositionEx { get; set; }

        public override System.Double OvertimeCost => OvertimeCostEx;
        public System.Double OvertimeCostEx { get; set; }

        public override System.String OvertimeWork => OvertimeWorkEx;
        public System.String OvertimeWorkEx { get; set; }

        public override System.TimeSpan OvertimeWorkTimeSpan => OvertimeWorkTimeSpanEx;
        public System.TimeSpan OvertimeWorkTimeSpanEx { get; set; }

        public override System.Int32 PercentWorkComplete => PercentWorkCompleteEx;
        public System.Int32 PercentWorkCompleteEx { get; set; }

        public override System.DateTime PreLevelingFinish => PreLevelingFinishEx;
        public System.DateTime PreLevelingFinishEx { get; set; }

        public override System.DateTime PreLevelingStart => PreLevelingStartEx;
        public System.DateTime PreLevelingStartEx { get; set; }

        public override System.String RegularWork => RegularWorkEx;
        public System.String RegularWorkEx { get; set; }

        public override System.TimeSpan RegularWorkTimeSpan => RegularWorkTimeSpanEx;
        public System.TimeSpan RegularWorkTimeSpanEx { get; set; }

        public override System.Double RemainingCost => RemainingCostEx;
        public System.Double RemainingCostEx { get; set; }

        public override System.Double RemainingOvertimeCost => RemainingOvertimeCostEx;
        public System.Double RemainingOvertimeCostEx { get; set; }

        public override System.String RemainingOvertimeWork => RemainingOvertimeWorkEx;
        public System.String RemainingOvertimeWorkEx { get; set; }

        public override System.TimeSpan RemainingOvertimeWorkTimeSpan => RemainingOvertimeWorkTimeSpanEx;
        public System.TimeSpan RemainingOvertimeWorkTimeSpanEx { get; set; }

        public override System.String RemainingWork => RemainingWorkEx;
        public System.String RemainingWorkEx { get; set; }

        public override System.TimeSpan RemainingWorkTimeSpan => RemainingWorkTimeSpanEx;
        public System.TimeSpan RemainingWorkTimeSpanEx { get; set; }

        public override System.DateTime Resume => ResumeEx;
        public System.DateTime ResumeEx { get; set; }

        public override System.Double ScheduleCostVariance => ScheduleCostVarianceEx;
        public System.Double ScheduleCostVarianceEx { get; set; }

        public override System.String ScheduledDuration => ScheduledDurationEx;
        public System.String ScheduledDurationEx { get; set; }

        public override System.TimeSpan ScheduledDurationTimeSpan => ScheduledDurationTimeSpanEx;
        public System.TimeSpan ScheduledDurationTimeSpanEx { get; set; }

        public override System.DateTime ScheduledFinish => ScheduledFinishEx;
        public System.DateTime ScheduledFinishEx { get; set; }

        public override System.DateTime ScheduledStart => ScheduledStartEx;
        public System.DateTime ScheduledStartEx { get; set; }

        public override System.Double SchedulePerformanceIndex => SchedulePerformanceIndexEx;
        public System.Double SchedulePerformanceIndexEx { get; set; }

        public override System.Int32 ScheduleVariancePercentage => ScheduleVariancePercentageEx;
        public System.Int32 ScheduleVariancePercentageEx { get; set; }

        public override System.String StartSlack => StartSlackEx;
        public System.String StartSlackEx { get; set; }

        public override System.TimeSpan StartSlackTimeSpan => StartSlackTimeSpanEx;
        public System.TimeSpan StartSlackTimeSpanEx { get; set; }

        public override System.String StartVariance => StartVarianceEx;
        public System.String StartVarianceEx { get; set; }

        public override System.TimeSpan StartVarianceTimeSpan => StartVarianceTimeSpanEx;
        public System.TimeSpan StartVarianceTimeSpanEx { get; set; }

        public override System.DateTime Stop => StopEx;
        public System.DateTime StopEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedProject SubProject => SubProjectEx;
        public Microsoft.ProjectServer.Client.PublishedProject SubProjectEx { get; set; }

        public override System.Double ToCompletePerformanceIndex => ToCompletePerformanceIndexEx;
        public System.Double ToCompletePerformanceIndexEx { get; set; }

        public override System.String TotalSlack => TotalSlackEx;
        public System.String TotalSlackEx { get; set; }

        public override System.TimeSpan TotalSlackTimeSpan => TotalSlackTimeSpanEx;
        public System.TimeSpan TotalSlackTimeSpanEx { get; set; }

        public override System.String WorkBreakdownStructure => WorkBreakdownStructureEx;
        public System.String WorkBreakdownStructureEx { get; set; }

        public override System.String WorkVariance => WorkVarianceEx;
        public System.String WorkVarianceEx { get; set; }

        public override System.TimeSpan WorkVarianceTimeSpan => WorkVarianceTimeSpanEx;
        public System.TimeSpan WorkVarianceTimeSpanEx { get; set; }

    }
}

