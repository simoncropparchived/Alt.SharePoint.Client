
namespace Microsoft.Office.Client.Education
{
    public class LessonMock : Lesson
    {


        public override Microsoft.Office.Client.Education.Assignments Assignments => AssignmentsEx;
        public Microsoft.Office.Client.Education.Assignments AssignmentsEx { get; set; }

        public override Microsoft.Office.Client.Education.Events Events => EventsEx;
        public Microsoft.Office.Client.Education.Events EventsEx { get; set; }

        public override Microsoft.Office.Client.Education.Lessons Lessons => LessonsEx;
        public Microsoft.Office.Client.Education.Lessons LessonsEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

        public override Microsoft.Office.Client.Education.Lesson ParentLesson => ParentLessonEx;
        public Microsoft.Office.Client.Education.Lesson ParentLessonEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources Resources => ResourcesEx;
        public Microsoft.Office.Client.Education.Resources ResourcesEx { get; set; }

    }
}

