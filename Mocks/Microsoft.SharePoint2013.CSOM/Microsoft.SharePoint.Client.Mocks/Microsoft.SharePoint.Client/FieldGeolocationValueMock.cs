
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldGeolocationValueMock : FieldGeolocationValue
    {


        public override System.Double Altitude => AltitudeEx;
        public System.Double AltitudeEx { get; set; }

        public override System.Double Latitude => LatitudeEx;
        public System.Double LatitudeEx { get; set; }

        public override System.Double Longitude => LongitudeEx;
        public System.Double LongitudeEx { get; set; }

        public override System.Double Measure => MeasureEx;
        public System.Double MeasureEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

