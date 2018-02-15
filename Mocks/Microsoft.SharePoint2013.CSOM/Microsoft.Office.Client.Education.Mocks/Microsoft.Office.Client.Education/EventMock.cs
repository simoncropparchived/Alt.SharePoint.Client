
namespace Microsoft.Office.Client.Education
{
    public class EventMock
    {


        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override System.String EventCategory => EventCategoryEx;
        public System.String EventCategoryEx { get; set; }

        public override System.String Location => LocationEx;
        public System.String LocationEx { get; set; }

        public override Microsoft.Office.Client.Education.LearningEntity Parent => ParentEx;
        public Microsoft.Office.Client.Education.LearningEntity ParentEx { get; set; }

        public override Microsoft.Office.Client.Education.Resources Resources => ResourcesEx;
        public Microsoft.Office.Client.Education.Resources ResourcesEx { get; set; }

        public override Microsoft.Office.Client.Education.EventSchedule Schedule => ScheduleEx;
        public Microsoft.Office.Client.Education.EventSchedule ScheduleEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

    }
}

