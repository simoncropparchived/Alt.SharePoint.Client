
namespace Microsoft.ProjectServer.Client
{
    public class EngagementTimephasedPeriodCreationInformationMock
    {


        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.Double MaxUnits => MaxUnitsEx;
        public System.Double MaxUnitsEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

