
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class MeetingMock : Meeting
    {


        public override System.String Attendees => AttendeesEx;
        public System.String AttendeesEx { get; set; }

        public override System.String ConferenceData => ConferenceDataEx;
        public System.String ConferenceDataEx { get; set; }

        public override System.String ConferenceId => ConferenceIdEx;
        public System.String ConferenceIdEx { get; set; }

        public override System.String ConferenceUrl => ConferenceUrlEx;
        public System.String ConferenceUrlEx { get; set; }

        public override System.Boolean IsOnline => IsOnlineEx;
        public System.Boolean IsOnlineEx { get; set; }

        public override System.Boolean IsRecorded => IsRecordedEx;
        public System.Boolean IsRecordedEx { get; set; }

        public override System.String RecordingUrl => RecordingUrlEx;
        public System.String RecordingUrlEx { get; set; }

    }
}

