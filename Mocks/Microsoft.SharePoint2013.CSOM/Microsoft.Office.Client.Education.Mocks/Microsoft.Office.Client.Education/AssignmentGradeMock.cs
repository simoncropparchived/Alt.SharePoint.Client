
namespace Microsoft.Office.Client.Education
{
    public class AssignmentGradeMock : AssignmentGrade
    {


        public override Microsoft.Office.Client.Education.LearningEntity Parent => ParentEx;
        public Microsoft.Office.Client.Education.LearningEntity ParentEx { get; set; }

        public override System.String UserId => UserIdEx;
        public System.String UserIdEx { get; set; }

        public override System.String UserName => UserNameEx;
        public System.String UserNameEx { get; set; }

    }
}

