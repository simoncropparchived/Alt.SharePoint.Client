
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentCreationInformationMock : PlanAssignmentCreationInformation
    {


        public override Microsoft.ProjectServer.Client.BookingType BookingType => BookingTypeEx;
        public Microsoft.ProjectServer.Client.BookingType BookingTypeEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.PlanAssignmentIntervalCreationInformation> Intervals => IntervalsEx;
        public System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.PlanAssignmentIntervalCreationInformation> IntervalsEx { get; set; }

        public override System.Guid ResourceId => ResourceIdEx;
        public System.Guid ResourceIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

