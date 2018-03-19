
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class AnnouncementMock : Announcement
    {


        public override System.String Body => BodyEx;
        public System.String BodyEx { get; set; }

        public override System.DateTime Expires => ExpiresEx;
        public System.DateTime ExpiresEx { get; set; }

    }
}

