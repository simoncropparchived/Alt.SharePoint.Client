
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AssignedAssignmentMock : AssignedAssignment
    {


        public override Microsoft.Office.Client.Education.Assignment Assignment => AssignmentEx;
        public Microsoft.Office.Client.Education.Assignment AssignmentEx { get; set; }

        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override Microsoft.Office.Client.Education.Events Events => EventsEx;
        public Microsoft.Office.Client.Education.Events EventsEx { get; set; }

        public override Microsoft.Office.Client.Education.Grades Grades => GradesEx;
        public Microsoft.Office.Client.Education.Grades GradesEx { get; set; }

        public override Microsoft.Office.Client.Education.GradingStatus GradingStatus => GradingStatusEx;
        public Microsoft.Office.Client.Education.GradingStatus GradingStatusEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources Resources => ResourcesEx;
        public Microsoft.Office.Client.Education.Resources ResourcesEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignedAssignmentStatus Status => StatusEx;
        public Microsoft.Office.Client.Education.AssignedAssignmentStatus StatusEx { get; set; }

        public override Microsoft.Office.Client.Education.Submissions Submissions => SubmissionsEx;
        public Microsoft.Office.Client.Education.Submissions SubmissionsEx { get; set; }

        public override System.String UserId => UserIdEx;
        public System.String UserIdEx { get; set; }

        public override System.String UserName => UserNameEx;
        public System.String UserNameEx { get; set; }

    }
}

