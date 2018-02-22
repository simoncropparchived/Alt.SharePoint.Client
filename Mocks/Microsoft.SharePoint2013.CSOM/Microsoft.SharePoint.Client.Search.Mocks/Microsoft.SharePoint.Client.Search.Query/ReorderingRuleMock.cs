
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class ReorderingRuleMock : ReorderingRule
    {


        public override System.Int32 Boost => BoostEx;
        public System.Int32 BoostEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.ReorderingRuleMatchType MatchType => MatchTypeEx;
        public Microsoft.SharePoint.Client.Search.Query.ReorderingRuleMatchType MatchTypeEx { get; set; }

        public override System.String MatchValue => MatchValueEx;
        public System.String MatchValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

