
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SecondaryAdministratorsInfoMock : SecondaryAdministratorsInfo
    {


        public override System.String email => emailEx;
        public System.String emailEx { get; set; }

        public override System.String name => nameEx;
        public System.String nameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

