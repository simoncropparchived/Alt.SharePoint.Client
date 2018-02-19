
namespace Microsoft.ProjectServer.Client
{
    public class EngagementCreationInformationMock : EngagementCreationInformation
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Double MaxUnits => MaxUnitsEx;
        public System.Double MaxUnitsEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.EngagementTimephasedPeriodCreationInformation> TimephasedPeriodData => TimephasedPeriodDataEx;
        public System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.EngagementTimephasedPeriodCreationInformation> TimephasedPeriodDataEx { get; set; }

        public override System.String Work => WorkEx;
        public System.String WorkEx { get; set; }

        public override System.TimeSpan WorkTimeSpan => WorkTimeSpanEx;
        public System.TimeSpan WorkTimeSpanEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

