
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class ContactAdminsByEmailFieldsDataMock : ContactAdminsByEmailFieldsData
    {


        public override System.String message => messageEx;
        public System.String messageEx { get; set; }

        public override System.String[] siteIds => siteIdsEx;
        public System.String[] siteIdsEx { get; set; }

        public override System.String subject => subjectEx;
        public System.String subjectEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

