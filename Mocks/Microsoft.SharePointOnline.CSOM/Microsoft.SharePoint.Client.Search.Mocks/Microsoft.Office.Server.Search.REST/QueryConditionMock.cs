
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class QueryConditionMock : QueryCondition
    {


        public override System.Int32 LCID => LCIDEx;
        public System.Int32 LCIDEx { get; set; }

        public override System.String MatchingOptions => MatchingOptionsEx;
        public System.String MatchingOptionsEx { get; set; }

        public override System.String QueryConditionType => QueryConditionTypeEx;
        public System.String QueryConditionTypeEx { get; set; }

        public override System.String SubjectTermsOrigin => SubjectTermsOriginEx;
        public System.String SubjectTermsOriginEx { get; set; }

        public override System.Collections.Generic.IList<System.String> Terms => TermsEx;
        public System.Collections.Generic.IList<System.String> TermsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

