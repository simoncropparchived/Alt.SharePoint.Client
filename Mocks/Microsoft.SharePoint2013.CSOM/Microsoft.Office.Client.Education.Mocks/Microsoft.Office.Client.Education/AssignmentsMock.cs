
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AssignmentsMock : Assignments
    {


        public override Microsoft.Office.Client.Education.Assignment AddEntity(Microsoft.Office.Client.Education.Assignment @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Assignment AddEntityEx { get; set;}

    }
}

