
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class LearningEntitiesMock : LearningEntities
    {


        public override Microsoft.Office.Client.Education.LearningEntity AddEntity(Microsoft.Office.Client.Education.LearningEntity @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.LearningEntity AddEntityEx { get; set;}

    }
}

