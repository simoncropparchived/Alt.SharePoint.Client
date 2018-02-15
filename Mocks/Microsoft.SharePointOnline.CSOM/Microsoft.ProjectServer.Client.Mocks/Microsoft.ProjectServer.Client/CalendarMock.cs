
namespace Microsoft.ProjectServer.Client
{
    public class CalendarMock : Calendar
    {


        public override Microsoft.ProjectServer.Client.CalendarExceptionCollection BaseCalendarExceptions => BaseCalendarExceptionsEx;
        public Microsoft.ProjectServer.Client.CalendarExceptionCollection BaseCalendarExceptionsEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsStandardCalendar => IsStandardCalendarEx;
        public System.Boolean IsStandardCalendarEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

