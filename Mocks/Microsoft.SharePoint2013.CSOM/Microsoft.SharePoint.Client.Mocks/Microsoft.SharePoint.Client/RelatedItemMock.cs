
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RelatedItemMock : RelatedItem
    {


        public override System.String IconUrl => IconUrlEx;
        public System.String IconUrlEx { get; set; }

        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override System.String ListId => ListIdEx;
        public System.String ListIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String WebId => WebIdEx;
        public System.String WebIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

