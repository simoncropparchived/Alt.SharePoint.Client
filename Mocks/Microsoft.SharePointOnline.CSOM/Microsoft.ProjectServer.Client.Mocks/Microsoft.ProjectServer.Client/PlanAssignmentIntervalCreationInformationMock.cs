
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentIntervalCreationInformationMock : PlanAssignmentIntervalCreationInformation
    {


        public override System.String Duration => DurationEx;
        public System.String DurationEx { get; set; }

        public override System.DateTime Interval => IntervalEx;
        public System.DateTime IntervalEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

