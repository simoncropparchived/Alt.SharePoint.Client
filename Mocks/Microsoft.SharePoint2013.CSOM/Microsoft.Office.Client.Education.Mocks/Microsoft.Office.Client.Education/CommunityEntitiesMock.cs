
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class CommunityEntitiesMock : CommunityEntities
    {


        public override Microsoft.Office.Client.Education.CommunityEntity AddEntity(Microsoft.Office.Client.Education.CommunityEntity @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.CommunityEntity AddEntityEx { get; set;}

    }
}

