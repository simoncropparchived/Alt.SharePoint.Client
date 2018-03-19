
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentIntervalMock : PlanAssignmentInterval
    {


        public override System.String Duration => DurationEx;
        public System.String DurationEx { get; set; }

        public override System.TimeSpan DurationTimeSpan => DurationTimeSpanEx;
        public System.TimeSpan DurationTimeSpanEx { get; set; }

        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

    }
}

