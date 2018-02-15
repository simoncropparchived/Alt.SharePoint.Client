
namespace Microsoft.Office.Client.Education
{
    public class MeetingScheduleMock : MeetingSchedule
    {


        public override System.String Attendees => AttendeesEx;
        public System.String AttendeesEx { get; set; }

    }
}

