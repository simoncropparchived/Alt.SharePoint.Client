
namespace Microsoft.Office.Client.Education
{
    public class CourseMock
    {


        public override Microsoft.Office.Client.Education.Announcements Announcements => AnnouncementsEx;
        public Microsoft.Office.Client.Education.Announcements AnnouncementsEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignedAssignments AssignedAssignments => AssignedAssignmentsEx;
        public Microsoft.Office.Client.Education.AssignedAssignments AssignedAssignmentsEx { get; set; }

        public override Microsoft.Office.Client.Education.AssignmentCategories AssignmentCategories => AssignmentCategoriesEx;
        public Microsoft.Office.Client.Education.AssignmentCategories AssignmentCategoriesEx { get; set; }

        public override Microsoft.Office.Client.Education.Assignments Assignments => AssignmentsEx;
        public Microsoft.Office.Client.Education.Assignments AssignmentsEx { get; set; }

        public override System.String Code => CodeEx;
        public System.String CodeEx { get; set; }

        public override System.Boolean CourseGradesPublished => CourseGradesPublishedEx;
        public System.Boolean CourseGradesPublishedEx { get; set; }

        public override System.String CustomData => CustomDataEx;
        public System.String CustomDataEx { get; set; }

        public override System.String Department => DepartmentEx;
        public System.String DepartmentEx { get; set; }

        public override Microsoft.Office.Client.Education.Events Events => EventsEx;
        public Microsoft.Office.Client.Education.Events EventsEx { get; set; }

        public override Microsoft.Office.Client.Education.EventSchedules EventSchedules => EventSchedulesEx;
        public Microsoft.Office.Client.Education.EventSchedules EventSchedulesEx { get; set; }

        public override Microsoft.Office.Client.Education.Grades Grades => GradesEx;
        public Microsoft.Office.Client.Education.Grades GradesEx { get; set; }

        public override Microsoft.Office.Client.Education.Lessons Lessons => LessonsEx;
        public Microsoft.Office.Client.Education.Lessons LessonsEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources ResourceLibrary => ResourceLibraryEx;
        public Microsoft.Office.Client.Education.Resources ResourceLibraryEx { get; set; }

        public override Microsoft.Office.Client.Education.Submissions Submissions => SubmissionsEx;
        public Microsoft.Office.Client.Education.Submissions SubmissionsEx { get; set; }

    }
}

