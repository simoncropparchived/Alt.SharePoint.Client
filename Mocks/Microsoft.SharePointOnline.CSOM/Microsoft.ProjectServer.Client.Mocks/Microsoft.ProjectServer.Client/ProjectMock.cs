
namespace Microsoft.ProjectServer.Client
{
    public class ProjectMock
    {


        public override System.DateTime ApprovedEnd => ApprovedEndEx;
        public System.DateTime ApprovedEndEx { get; set; }

        public override System.DateTime ApprovedStart => ApprovedStartEx;
        public System.DateTime ApprovedStartEx { get; set; }

        public override System.Boolean CalculateActualCosts => CalculateActualCostsEx;
        public System.Boolean CalculateActualCostsEx { get; set; }

        public override System.Boolean CalculatesActualCosts => CalculatesActualCostsEx;
        public System.Boolean CalculatesActualCostsEx { get; set; }

        public override Microsoft.SharePoint.Client.User CheckedOutBy => CheckedOutByEx;
        public Microsoft.SharePoint.Client.User CheckedOutByEx { get; set; }

        public override System.DateTime CheckedOutDate => CheckedOutDateEx;
        public System.DateTime CheckedOutDateEx { get; set; }

        public override System.String CheckOutDescription => CheckOutDescriptionEx;
        public System.String CheckOutDescriptionEx { get; set; }

        public override System.Guid CheckOutId => CheckOutIdEx;
        public System.Guid CheckOutIdEx { get; set; }

        public override System.DateTime CreatedDate => CreatedDateEx;
        public System.DateTime CreatedDateEx { get; set; }

        public override System.Int32 CriticalSlackLimit => CriticalSlackLimitEx;
        public System.Int32 CriticalSlackLimitEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override System.DateTime DefaultFinishTime => DefaultFinishTimeEx;
        public System.DateTime DefaultFinishTimeEx { get; set; }

        public override Microsoft.ProjectServer.Client.OvertimeRateFormat DefaultOvertimeRateUnits => DefaultOvertimeRateUnitsEx;
        public Microsoft.ProjectServer.Client.OvertimeRateFormat DefaultOvertimeRateUnitsEx { get; set; }

        public override Microsoft.ProjectServer.Client.StandardRateFormat DefaultStandardRateUnits => DefaultStandardRateUnitsEx;
        public Microsoft.ProjectServer.Client.StandardRateFormat DefaultStandardRateUnitsEx { get; set; }

        public override System.DateTime DefaultStartTime => DefaultStartTimeEx;
        public System.DateTime DefaultStartTimeEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectEngagementCollection Engagements => EngagementsEx;
        public Microsoft.ProjectServer.Client.ProjectEngagementCollection EngagementsEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseProjectType EnterpriseProjectType => EnterpriseProjectTypeEx;
        public Microsoft.ProjectServer.Client.EnterpriseProjectType EnterpriseProjectTypeEx { get; set; }

        public override System.Boolean HasMppPendingImport => HasMppPendingImportEx;
        public System.Boolean HasMppPendingImportEx { get; set; }

        public override System.Boolean HonorConstraints => HonorConstraintsEx;
        public System.Boolean HonorConstraintsEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsCheckedOut => IsCheckedOutEx;
        public System.Boolean IsCheckedOutEx { get; set; }

        public override System.DateTime LastPublishedDate => LastPublishedDateEx;
        public System.DateTime LastPublishedDateEx { get; set; }

        public override System.DateTime LastSavedDate => LastSavedDateEx;
        public System.DateTime LastSavedDateEx { get; set; }

        public override System.Boolean MoveActualIfLater => MoveActualIfLaterEx;
        public System.Boolean MoveActualIfLaterEx { get; set; }

        public override System.Boolean MoveActualToStatus => MoveActualToStatusEx;
        public System.Boolean MoveActualToStatusEx { get; set; }

        public override System.Boolean MoveRemainingIfEarlier => MoveRemainingIfEarlierEx;
        public System.Boolean MoveRemainingIfEarlierEx { get; set; }

        public override System.Boolean MoveRemainingToStatus => MoveRemainingToStatusEx;
        public System.Boolean MoveRemainingToStatusEx { get; set; }

        public override System.Boolean MultipleCriticalPaths => MultipleCriticalPathsEx;
        public System.Boolean MultipleCriticalPathsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CommittedDecisionResult OptimizerDecision => OptimizerDecisionEx;
        public Microsoft.ProjectServer.Client.CommittedDecisionResult OptimizerDecisionEx { get; set; }

        public override System.Int32 PercentComplete => PercentCompleteEx;
        public System.Int32 PercentCompleteEx { get; set; }

        public override Microsoft.ProjectServer.Client.Phase Phase => PhaseEx;
        public Microsoft.ProjectServer.Client.Phase PhaseEx { get; set; }

        public override Microsoft.ProjectServer.Client.CommittedDecisionResult PlannerDecision => PlannerDecisionEx;
        public Microsoft.ProjectServer.Client.CommittedDecisionResult PlannerDecisionEx { get; set; }

        public override System.String ProjectSiteUrl => ProjectSiteUrlEx;
        public System.String ProjectSiteUrlEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectSummaryTask ProjectSummaryTask => ProjectSummaryTaskEx;
        public Microsoft.ProjectServer.Client.ProjectSummaryTask ProjectSummaryTaskEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectType ProjectType => ProjectTypeEx;
        public Microsoft.ProjectServer.Client.ProjectType ProjectTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.QueueJobCollection QueueJobs => QueueJobsEx;
        public Microsoft.ProjectServer.Client.QueueJobCollection QueueJobsEx { get; set; }

        public override System.Boolean ScheduledFromStart => ScheduledFromStartEx;
        public System.Boolean ScheduledFromStartEx { get; set; }

        public override System.Boolean SplitInProgress => SplitInProgressEx;
        public System.Boolean SplitInProgressEx { get; set; }

        public override System.Boolean SpreadActualCostsToStatus => SpreadActualCostsToStatusEx;
        public System.Boolean SpreadActualCostsToStatusEx { get; set; }

        public override System.Boolean SpreadPercentCompleteToStatus => SpreadPercentCompleteToStatusEx;
        public System.Boolean SpreadPercentCompleteToStatusEx { get; set; }

        public override Microsoft.ProjectServer.Client.Stage Stage => StageEx;
        public Microsoft.ProjectServer.Client.Stage StageEx { get; set; }

        public override System.Guid SummaryTaskId => SummaryTaskIdEx;
        public System.Guid SummaryTaskIdEx { get; set; }

        public override System.Guid TaskListId => TaskListIdEx;
        public System.Guid TaskListIdEx { get; set; }

    }
}

