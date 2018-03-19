
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AssignedAssignmentsMock : AssignedAssignments
    {


        public override Microsoft.Office.Client.Education.AssignedAssignment AddEntity(Microsoft.Office.Client.Education.AssignedAssignment @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.AssignedAssignment AddEntityEx { get; set;}

    }
}

