
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class LessonsMock : Lessons
    {


        public override Microsoft.Office.Client.Education.Lesson AddEntity(Microsoft.Office.Client.Education.Lesson @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Lesson AddEntityEx { get; set;}

    }
}

