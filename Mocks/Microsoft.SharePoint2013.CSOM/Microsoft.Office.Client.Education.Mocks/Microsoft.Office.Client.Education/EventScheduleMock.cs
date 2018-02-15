
namespace Microsoft.Office.Client.Education
{
    public class EventScheduleMock
    {


        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override System.String EventCategory => EventCategoryEx;
        public System.String EventCategoryEx { get; set; }

        public override System.String Location => LocationEx;
        public System.String LocationEx { get; set; }

        public override System.String RecurrenceData => RecurrenceDataEx;
        public System.String RecurrenceDataEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

    }
}

