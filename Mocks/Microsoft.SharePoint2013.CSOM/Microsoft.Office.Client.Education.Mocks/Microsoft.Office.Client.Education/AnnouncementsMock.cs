
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AnnouncementsMock : Announcements
    {


        public override Microsoft.Office.Client.Education.Announcement AddEntity(Microsoft.Office.Client.Education.Announcement @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Announcement AddEntityEx { get; set;}

    }
}

