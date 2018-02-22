
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class EventSchedulesMock : EventSchedules
    {


        public override Microsoft.Office.Client.Education.EventSchedule AddEntity(Microsoft.Office.Client.Education.EventSchedule @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.EventSchedule AddEntityEx { get; set;}

    }
}

