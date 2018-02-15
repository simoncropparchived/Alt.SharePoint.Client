
namespace Microsoft.ProjectServer.Client
{
    public class TimePhaseMock
    {


        public override Microsoft.ProjectServer.Client.StatusAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.StatusAssignmentCollection AssignmentsEx { get; set; }

        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

    }
}

