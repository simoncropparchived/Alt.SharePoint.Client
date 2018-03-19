
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ViewFieldCollectionMock : ViewFieldCollection
    {


        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

        public override void MoveFieldTo(System.String @field, System.Int32 @index)
        {
        }

        public override void Add(System.String @strField)
        {
        }

        public override void Remove(System.String @strField)
        {
        }

        public override void RemoveAll()
        {
        }

    }
}

