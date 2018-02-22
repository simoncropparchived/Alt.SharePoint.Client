
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AppPrincipalCredentialReferenceMock : AppPrincipalCredentialReference
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String NameIdentifier => NameIdentifierEx;
        public System.String NameIdentifierEx { get; set; }

        public override System.DateTime NotAfter => NotAfterEx;
        public System.DateTime NotAfterEx { get; set; }

        public override System.DateTime NotBefore => NotBeforeEx;
        public System.DateTime NotBeforeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

