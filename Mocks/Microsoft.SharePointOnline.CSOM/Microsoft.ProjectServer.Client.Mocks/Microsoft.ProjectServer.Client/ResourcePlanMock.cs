
namespace Microsoft.ProjectServer.Client
{
    public class ResourcePlanMock
    {


        public override Microsoft.ProjectServer.Client.PlanAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.PlanAssignmentCollection AssignmentsEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.DateTime UtilizationDate => UtilizationDateEx;
        public System.DateTime UtilizationDateEx { get; set; }

        public override Microsoft.ProjectServer.Client.UtilizationType UtilizationType => UtilizationTypeEx;
        public Microsoft.ProjectServer.Client.UtilizationType UtilizationTypeEx { get; set; }

    }
}

