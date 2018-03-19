
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class CommunityEntityMock : CommunityEntity
    {


        public override Microsoft.Office.Client.Education.Community Community => CommunityEx;
        public Microsoft.Office.Client.Education.Community CommunityEx { get; set; }

    }
}

