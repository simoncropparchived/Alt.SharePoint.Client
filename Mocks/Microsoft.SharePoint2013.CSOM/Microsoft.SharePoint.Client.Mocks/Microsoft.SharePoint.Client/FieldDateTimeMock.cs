
namespace Microsoft.SharePoint.Client
{
    public class FieldDateTimeMock : FieldDateTime
    {


        public override Microsoft.SharePoint.Client.CalendarType DateTimeCalendarType => DateTimeCalendarTypeEx;
        public Microsoft.SharePoint.Client.CalendarType DateTimeCalendarTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.DateTimeFieldFormatType DisplayFormat => DisplayFormatEx;
        public Microsoft.SharePoint.Client.DateTimeFieldFormatType DisplayFormatEx { get; set; }

        public override Microsoft.SharePoint.Client.DateTimeFieldFriendlyFormatType FriendlyDisplayFormat => FriendlyDisplayFormatEx;
        public Microsoft.SharePoint.Client.DateTimeFieldFriendlyFormatType FriendlyDisplayFormatEx { get; set; }

    }
}

