
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class GradesMock : Grades
    {


        public override Microsoft.Office.Client.Education.Grade AddEntity(Microsoft.Office.Client.Education.Grade @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Grade AddEntityEx { get; set;}

    }
}

