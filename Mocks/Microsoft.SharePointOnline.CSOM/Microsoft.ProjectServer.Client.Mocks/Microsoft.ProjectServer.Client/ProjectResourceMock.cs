
namespace Microsoft.ProjectServer.Client
{
    public class ProjectResourceMock : ProjectResource
    {


        public override System.Double ActualCost => ActualCostEx;
        public System.Double ActualCostEx { get; set; }

        public override System.String ActualCostWorkPerformed => ActualCostWorkPerformedEx;
        public System.String ActualCostWorkPerformedEx { get; set; }

        public override System.TimeSpan ActualCostWorkPerformedTimeSpan => ActualCostWorkPerformedTimeSpanEx;
        public System.TimeSpan ActualCostWorkPerformedTimeSpanEx { get; set; }

        public override System.Double ActualOvertimeCost => ActualOvertimeCostEx;
        public System.Double ActualOvertimeCostEx { get; set; }

        public override System.String ActualOvertimeWork => ActualOvertimeWorkEx;
        public System.String ActualOvertimeWorkEx { get; set; }

        public override System.TimeSpan ActualOvertimeWorkTimeSpan => ActualOvertimeWorkTimeSpanEx;
        public System.TimeSpan ActualOvertimeWorkTimeSpanEx { get; set; }

        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.TimeSpan ActualWorkTimeSpan => ActualWorkTimeSpanEx;
        public System.TimeSpan ActualWorkTimeSpanEx { get; set; }

        public override System.DateTime AvailableFrom => AvailableFromEx;
        public System.DateTime AvailableFromEx { get; set; }

        public override System.DateTime AvailableTo => AvailableToEx;
        public System.DateTime AvailableToEx { get; set; }

        public override System.Double BaselineCost => BaselineCostEx;
        public System.Double BaselineCostEx { get; set; }

        public override System.String BaselineWork => BaselineWorkEx;
        public System.String BaselineWorkEx { get; set; }

        public override System.TimeSpan BaselineWorkTimeSpan => BaselineWorkTimeSpanEx;
        public System.TimeSpan BaselineWorkTimeSpanEx { get; set; }

        public override System.Double BudetCostWorkPerformed => BudetCostWorkPerformedEx;
        public System.Double BudetCostWorkPerformedEx { get; set; }

        public override System.Double BudgetedCost => BudgetedCostEx;
        public System.Double BudgetedCostEx { get; set; }

        public override System.Double BudgetedCostWorkScheduled => BudgetedCostWorkScheduledEx;
        public System.Double BudgetedCostWorkScheduledEx { get; set; }

        public override System.String BudgetedWork => BudgetedWorkEx;
        public System.String BudgetedWorkEx { get; set; }

        public override System.TimeSpan BudgetedWorkTimeSpan => BudgetedWorkTimeSpanEx;
        public System.TimeSpan BudgetedWorkTimeSpanEx { get; set; }

        public override System.Double Cost => CostEx;
        public System.Double CostEx { get; set; }

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

        public override Microsoft.ProjectServer.Client.EnterpriseResource EnterpriseResource => EnterpriseResourceEx;
        public Microsoft.ProjectServer.Client.EnterpriseResource EnterpriseResourceEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsBudgeted => IsBudgetedEx;
        public System.Boolean IsBudgetedEx { get; set; }

        public override System.Boolean IsGenericResource => IsGenericResourceEx;
        public System.Boolean IsGenericResourceEx { get; set; }

        public override System.Boolean IsOverAllocated => IsOverAllocatedEx;
        public System.Boolean IsOverAllocatedEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.Double OvertimeCost => OvertimeCostEx;
        public System.Double OvertimeCostEx { get; set; }

        public override System.String OvertimeWork => OvertimeWorkEx;
        public System.String OvertimeWorkEx { get; set; }

        public override System.TimeSpan OvertimeWorkTimeSpan => OvertimeWorkTimeSpanEx;
        public System.TimeSpan OvertimeWorkTimeSpanEx { get; set; }

        public override System.String PeakWork => PeakWorkEx;
        public System.String PeakWorkEx { get; set; }

        public override System.TimeSpan PeakWorkTimeSpan => PeakWorkTimeSpanEx;
        public System.TimeSpan PeakWorkTimeSpanEx { get; set; }

        public override System.Int32 PercentWorkComplete => PercentWorkCompleteEx;
        public System.Int32 PercentWorkCompleteEx { get; set; }

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

        public override System.Double ScheduleCostVariance => ScheduleCostVarianceEx;
        public System.Double ScheduleCostVarianceEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

        public override System.String WorkVariance => WorkVarianceEx;
        public System.String WorkVarianceEx { get; set; }

        public override System.TimeSpan WorkVarianceTimeSpan => WorkVarianceTimeSpanEx;
        public System.TimeSpan WorkVarianceTimeSpanEx { get; set; }

    }
}

