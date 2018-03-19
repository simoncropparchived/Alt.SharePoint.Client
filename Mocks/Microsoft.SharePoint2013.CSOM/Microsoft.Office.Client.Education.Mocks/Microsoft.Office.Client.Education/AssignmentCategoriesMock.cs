
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AssignmentCategoriesMock : AssignmentCategories
    {


        public override Microsoft.Office.Client.Education.AssignmentCategory AddEntity(Microsoft.Office.Client.Education.AssignmentCategory @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.AssignmentCategory AddEntityEx { get; set;}

    }
}

