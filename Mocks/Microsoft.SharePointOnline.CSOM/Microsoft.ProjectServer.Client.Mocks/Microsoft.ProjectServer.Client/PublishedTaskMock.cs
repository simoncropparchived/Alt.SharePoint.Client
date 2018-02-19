
namespace Microsoft.ProjectServer.Client
{
    public class PublishedTaskMock : PublishedTask
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Double ActualCost => ActualCostEx;
        public System.Double ActualCostEx { get; set; }

        public override System.DateTime ActualFinish => ActualFinishEx;
        public System.DateTime ActualFinishEx { get; set; }

        public override System.DateTime ActualStart => ActualStartEx;
        public System.DateTime ActualStartEx { get; set; }

        public override System.String ActualWork => ActualWorkEx;
        public System.String ActualWorkEx { get; set; }

        public override System.TimeSpan ActualWorkTimeSpan => ActualWorkTimeSpanEx;
        public System.TimeSpan ActualWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.PublishedAssignmentCollection AssignmentsEx { get; set; }

        public override System.String BudgetWork => BudgetWorkEx;
        public System.String BudgetWorkEx { get; set; }

        public override System.TimeSpan BudgetWorkTimeSpan => BudgetWorkTimeSpanEx;
        public System.TimeSpan BudgetWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.Calendar Calendar => CalendarEx;
        public Microsoft.ProjectServer.Client.Calendar CalendarEx { get; set; }

        public override System.DateTime Completion => CompletionEx;
        public System.DateTime CompletionEx { get; set; }

        public override System.DateTime ConstraintStartEnd => ConstraintStartEndEx;
        public System.DateTime ConstraintStartEndEx { get; set; }

        public override Microsoft.ProjectServer.Client.ConstraintType ConstraintType => ConstraintTypeEx;
        public Microsoft.ProjectServer.Client.ConstraintType ConstraintTypeEx { get; set; }

        public override System.Double Cost => CostEx;
        public System.Double CostEx { get; set; }

        public override System.DateTime Deadline => DeadlineEx;
        public System.DateTime DeadlineEx { get; set; }

        public override System.String Duration => DurationEx;
        public System.String DurationEx { get; set; }

        public override System.TimeSpan DurationTimeSpan => DurationTimeSpanEx;
        public System.TimeSpan DurationTimeSpanEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.String FinishText => FinishTextEx;
        public System.String FinishTextEx { get; set; }

        public override System.Double FixedCost => FixedCostEx;
        public System.Double FixedCostEx { get; set; }

        public override System.Boolean IsActive => IsActiveEx;
        public System.Boolean IsActiveEx { get; set; }

        public override System.Boolean IsLockedByManager => IsLockedByManagerEx;
        public System.Boolean IsLockedByManagerEx { get; set; }

        public override System.Boolean IsManual => IsManualEx;
        public System.Boolean IsManualEx { get; set; }

        public override System.Boolean IsMarked => IsMarkedEx;
        public System.Boolean IsMarkedEx { get; set; }

        public override System.Boolean IsMilestone => IsMilestoneEx;
        public System.Boolean IsMilestoneEx { get; set; }

        public override System.Boolean LevelingAdjustsAssignments => LevelingAdjustsAssignmentsEx;
        public System.Boolean LevelingAdjustsAssignmentsEx { get; set; }

        public override System.Boolean LevelingCanSplit => LevelingCanSplitEx;
        public System.Boolean LevelingCanSplitEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 OutlineLevel => OutlineLevelEx;
        public System.Int32 OutlineLevelEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedTask Parent => ParentEx;
        public Microsoft.ProjectServer.Client.PublishedTask ParentEx { get; set; }

        public override System.Int32 PercentComplete => PercentCompleteEx;
        public System.Int32 PercentCompleteEx { get; set; }

        public override System.Int32 PercentPhysicalWorkComplete => PercentPhysicalWorkCompleteEx;
        public System.Int32 PercentPhysicalWorkCompleteEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedTaskLinkCollection Predecessors => PredecessorsEx;
        public Microsoft.ProjectServer.Client.PublishedTaskLinkCollection PredecessorsEx { get; set; }

        public override System.Int32 Priority => PriorityEx;
        public System.Int32 PriorityEx { get; set; }

        public override System.String RemainingDuration => RemainingDurationEx;
        public System.String RemainingDurationEx { get; set; }

        public override System.TimeSpan RemainingDurationTimeSpan => RemainingDurationTimeSpanEx;
        public System.TimeSpan RemainingDurationTimeSpanEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.String StartText => StartTextEx;
        public System.String StartTextEx { get; set; }

        public override Microsoft.SharePoint.Client.User StatusManager => StatusManagerEx;
        public Microsoft.SharePoint.Client.User StatusManagerEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedTaskLinkCollection Successors => SuccessorsEx;
        public Microsoft.ProjectServer.Client.PublishedTaskLinkCollection SuccessorsEx { get; set; }

        public override Microsoft.ProjectServer.Client.TaskType TaskType => TaskTypeEx;
        public Microsoft.ProjectServer.Client.TaskType TaskTypeEx { get; set; }

        public override System.Boolean UsePercentPhysicalWorkComplete => UsePercentPhysicalWorkCompleteEx;
        public System.Boolean UsePercentPhysicalWorkCompleteEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

    }
}

