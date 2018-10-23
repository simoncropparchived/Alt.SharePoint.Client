
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EngagementTimephasedPeriodMock : EngagementTimephasedPeriod
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

    }
}
