
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class SubmissionMock : Submission
    {


        public override Microsoft.Office.Client.Education.AssignedAssignment AssignedAssignment => AssignedAssignmentEx;
        public Microsoft.Office.Client.Education.AssignedAssignment AssignedAssignmentEx { get; set; }

        public override System.String DefaultFolderUrl => DefaultFolderUrlEx;
        public System.String DefaultFolderUrlEx { get; set; }

        public override Microsoft.Office.Client.Education.Grades Grades => GradesEx;
        public Microsoft.Office.Client.Education.Grades GradesEx { get; set; }

        public override System.Boolean IsSubmitted => IsSubmittedEx;
        public System.Boolean IsSubmittedEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources Resources => ResourcesEx;
        public Microsoft.Office.Client.Education.Resources ResourcesEx { get; set; }

        public override System.DateTime SubmissionDate => SubmissionDateEx;
        public System.DateTime SubmissionDateEx { get; set; }

    }
}

