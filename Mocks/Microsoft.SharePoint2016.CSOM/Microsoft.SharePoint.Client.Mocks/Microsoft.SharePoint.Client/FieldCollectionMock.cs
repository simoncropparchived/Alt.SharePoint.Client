
namespace Microsoft.SharePoint.Client
{
    public class FieldCollectionMock : FieldCollection
    {


        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

    }
}

