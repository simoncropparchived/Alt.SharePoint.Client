
namespace Microsoft.ProjectServer.Client
{
    public class AssignmentMock : Assignment
    {


        public override System.Double ActualCostWorkPerformed => ActualCostWorkPerformedEx;
        public System.Double ActualCostWorkPerformedEx { get; set; }

        public override System.Double ActualOvertimeCost => ActualOvertimeCostEx;
        public System.Double ActualOvertimeCostEx { get; set; }

        public override System.Double BaselineCost => BaselineCostEx;
        public System.Double BaselineCostEx { get; set; }

        public override System.Double BaselineCostPerUse => BaselineCostPerUseEx;
        public System.Double BaselineCostPerUseEx { get; set; }

        public override System.DateTime BaselineFinish => BaselineFinishEx;
        public System.DateTime BaselineFinishEx { get; set; }

        public override System.DateTime BaselineStart => BaselineStartEx;
        public System.DateTime BaselineStartEx { get; set; }

        public override System.String BaselineWork => BaselineWorkEx;
        public System.String BaselineWorkEx { get; set; }

        public override System.TimeSpan BaselineWorkTimeSpan => BaselineWorkTimeSpanEx;
        public System.TimeSpan BaselineWorkTimeSpanEx { get; set; }

        public override System.Double BudgetedCostWorkPerformed => BudgetedCostWorkPerformedEx;
        public System.Double BudgetedCostWorkPerformedEx { get; set; }

        public override System.Double BudgetedCostWorkScheduled => BudgetedCostWorkScheduledEx;
        public System.Double BudgetedCostWorkScheduledEx { get; set; }

        public override System.Double CostVariance => CostVarianceEx;
        public System.Double CostVarianceEx { get; set; }

        public override System.Double CostVarianceAtCompletion => CostVarianceAtCompletionEx;
        public System.Double CostVarianceAtCompletionEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.Double CurrentCostVariance => CurrentCostVarianceEx;
        public System.Double CurrentCostVarianceEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.String FinishVariance => FinishVarianceEx;
        public System.String FinishVarianceEx { get; set; }

        public override System.TimeSpan FinishVarianceTimeSpan => FinishVarianceTimeSpanEx;
        public System.TimeSpan FinishVarianceTimeSpanEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsConfirmed => IsConfirmedEx;
        public System.Boolean IsConfirmedEx { get; set; }

        public override System.Boolean IsOverAllocated => IsOverAllocatedEx;
        public System.Boolean IsOverAllocatedEx { get; set; }

        public override System.Boolean IsPublished => IsPublishedEx;
        public System.Boolean IsPublishedEx { get; set; }

        public override System.Boolean IsResponsePending => IsResponsePendingEx;
        public System.Boolean IsResponsePendingEx { get; set; }

        public override System.Boolean IsUpdateNeeded => IsUpdateNeededEx;
        public System.Boolean IsUpdateNeededEx { get; set; }

        public override System.String LevelingDelay => LevelingDelayEx;
        public System.String LevelingDelayEx { get; set; }

        public override System.TimeSpan LevelingDelayTimeSpan => LevelingDelayTimeSpanEx;
        public System.TimeSpan LevelingDelayTimeSpanEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.Double OvertimeCost => OvertimeCostEx;
        public System.Double OvertimeCostEx { get; set; }

        public override System.Double RemainingCost => RemainingCostEx;
        public System.Double RemainingCostEx { get; set; }

        public override System.Double RemainingOvertimeCost => RemainingOvertimeCostEx;
        public System.Double RemainingOvertimeCostEx { get; set; }

        public override System.DateTime Resume => ResumeEx;
        public System.DateTime ResumeEx { get; set; }

        public override System.Double ScheduleCostVariance => ScheduleCostVarianceEx;
        public System.Double ScheduleCostVarianceEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.String StartVariance => StartVarianceEx;
        public System.String StartVarianceEx { get; set; }

        public override System.TimeSpan StartVarianceTimeSpan => StartVarianceTimeSpanEx;
        public System.TimeSpan StartVarianceTimeSpanEx { get; set; }

        public override System.DateTime Stop => StopEx;
        public System.DateTime StopEx { get; set; }

        public override Microsoft.ProjectServer.Client.WorkContourType WorkContourType => WorkContourTypeEx;
        public Microsoft.ProjectServer.Client.WorkContourType WorkContourTypeEx { get; set; }

        public override System.String WorkVariance => WorkVarianceEx;
        public System.String WorkVarianceEx { get; set; }

        public override System.TimeSpan WorkVarianceTimeSpan => WorkVarianceTimeSpanEx;
        public System.TimeSpan WorkVarianceTimeSpanEx { get; set; }

    }
}

