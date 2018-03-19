
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class PersonalResultSuggestionMock : PersonalResultSuggestion
    {


        public override System.String HighlightedTitle => HighlightedTitleEx;
        public System.String HighlightedTitleEx { get; set; }

        public override System.Boolean IsBestBet => IsBestBetEx;
        public System.Boolean IsBestBetEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

