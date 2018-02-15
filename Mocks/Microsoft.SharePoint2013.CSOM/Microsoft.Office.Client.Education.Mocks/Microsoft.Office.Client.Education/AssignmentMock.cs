
namespace Microsoft.Office.Client.Education
{
    public class AssignmentMock : Assignment
    {


        public override Microsoft.Office.Client.Education.AssignedAssignments AssignedAssignments => AssignedAssignmentsEx;
        public Microsoft.Office.Client.Education.AssignedAssignments AssignedAssignmentsEx { get; set; }

        public override System.String AssignedUsers => AssignedUsersEx;
        public System.String AssignedUsersEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignmentCategory Category => CategoryEx;
        public Microsoft.Office.Client.Education.AssignmentCategory CategoryEx { get; set; }

        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override Microsoft.Office.Client.Education.Events Events => EventsEx;
        public Microsoft.Office.Client.Education.Events EventsEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignmentFormat Format => FormatEx;
        public Microsoft.Office.Client.Education.AssignmentFormat FormatEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignmentGradeFormat GradeFormat => GradeFormatEx;
        public Microsoft.Office.Client.Education.AssignmentGradeFormat GradeFormatEx { get; set; }

        public override System.Boolean IsSubmissionRequired => IsSubmissionRequiredEx;
        public System.Boolean IsSubmissionRequiredEx { get; set; }

        public override Microsoft.Office.Client.Education.Lesson Lesson => LessonEx;
        public Microsoft.Office.Client.Education.Lesson LessonEx { get; set; }

        public override System.Int32 MaximumScore => MaximumScoreEx;
        public System.Int32 MaximumScoreEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

        public override System.String QuizId => QuizIdEx;
        public System.String QuizIdEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources Resources => ResourcesEx;
        public Microsoft.Office.Client.Education.Resources ResourcesEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignmentStatus Status => StatusEx;
        public Microsoft.Office.Client.Education.AssignmentStatus StatusEx { get; set; }

    }
}

