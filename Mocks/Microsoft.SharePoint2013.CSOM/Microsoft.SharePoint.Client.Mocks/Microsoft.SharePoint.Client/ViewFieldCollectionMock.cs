
namespace Microsoft.SharePoint.Client
{
    public class ViewFieldCollectionMock : ViewFieldCollection
    {


        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

    }
}

