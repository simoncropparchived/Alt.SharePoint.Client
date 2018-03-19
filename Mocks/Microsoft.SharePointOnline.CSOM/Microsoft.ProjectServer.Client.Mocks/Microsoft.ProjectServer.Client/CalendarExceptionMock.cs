
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class CalendarExceptionMock : CalendarException
    {


        public override Microsoft.ProjectServer.Client.Calendar Calendar => CalendarEx;
        public Microsoft.ProjectServer.Client.Calendar CalendarEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.CalendarRecurrenceDays RecurrenceDays => RecurrenceDaysEx;
        public Microsoft.ProjectServer.Client.CalendarRecurrenceDays RecurrenceDaysEx { get; set; }

        public override System.Int32 RecurrenceFrequency => RecurrenceFrequencyEx;
        public System.Int32 RecurrenceFrequencyEx { get; set; }

        public override System.Int32 RecurrenceMonth => RecurrenceMonthEx;
        public System.Int32 RecurrenceMonthEx { get; set; }

        public override System.Int32 RecurrenceMonthDay => RecurrenceMonthDayEx;
        public System.Int32 RecurrenceMonthDayEx { get; set; }

        public override Microsoft.ProjectServer.Client.CalendarRecurrenceType RecurrenceType => RecurrenceTypeEx;
        public Microsoft.ProjectServer.Client.CalendarRecurrenceType RecurrenceTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.CalendarRecurrenceWeek RecurrenceWeek => RecurrenceWeekEx;
        public Microsoft.ProjectServer.Client.CalendarRecurrenceWeek RecurrenceWeekEx { get; set; }

        public override System.Int32 Shift1Finish => Shift1FinishEx;
        public System.Int32 Shift1FinishEx { get; set; }

        public override System.Int32 Shift1Start => Shift1StartEx;
        public System.Int32 Shift1StartEx { get; set; }

        public override System.Int32 Shift2Finish => Shift2FinishEx;
        public System.Int32 Shift2FinishEx { get; set; }

        public override System.Int32 Shift2Start => Shift2StartEx;
        public System.Int32 Shift2StartEx { get; set; }

        public override System.Int32 Shift3Finish => Shift3FinishEx;
        public System.Int32 Shift3FinishEx { get; set; }

        public override System.Int32 Shift3Start => Shift3StartEx;
        public System.Int32 Shift3StartEx { get; set; }

        public override System.Int32 Shift4Finish => Shift4FinishEx;
        public System.Int32 Shift4FinishEx { get; set; }

        public override System.Int32 Shift4Start => Shift4StartEx;
        public System.Int32 Shift4StartEx { get; set; }

        public override System.Int32 Shift5Finish => Shift5FinishEx;
        public System.Int32 Shift5FinishEx { get; set; }

        public override System.Int32 Shift5Start => Shift5StartEx;
        public System.Int32 Shift5StartEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

