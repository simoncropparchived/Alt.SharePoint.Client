
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QueryPropertyValueMock : QueryPropertyValue
    {


        public override System.Boolean BoolVal => BoolValEx;
        public System.Boolean BoolValEx { get; set; }

        public override System.Int32 IntVal => IntValEx;
        public System.Int32 IntValEx { get; set; }

        public override System.Int32 QueryPropertyValueTypeIndex => QueryPropertyValueTypeIndexEx;
        public System.Int32 QueryPropertyValueTypeIndexEx { get; set; }

        public override System.String[] StrArray => StrArrayEx;
        public System.String[] StrArrayEx { get; set; }

        public override System.String StrVal => StrValEx;
        public System.String StrValEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

