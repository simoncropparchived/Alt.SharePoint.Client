
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class LabelMatchInformationMock
    {


        public override System.Boolean DefaultLabelOnly => DefaultLabelOnlyEx;
        public System.Boolean DefaultLabelOnlyEx { get; set; }

        public override System.Boolean ExcludeKeyword => ExcludeKeywordEx;
        public System.Boolean ExcludeKeywordEx { get; set; }

        public override System.Int32 Lcid => LcidEx;
        public System.Int32 LcidEx { get; set; }

        public override System.Int32 ResultCollectionSize => ResultCollectionSizeEx;
        public System.Int32 ResultCollectionSizeEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.StringMatchOption StringMatchOption => StringMatchOptionEx;
        public Microsoft.SharePoint.Client.Taxonomy.StringMatchOption StringMatchOptionEx { get; set; }

        public override System.String TermLabel => TermLabelEx;
        public System.String TermLabelEx { get; set; }

        public override System.Boolean TrimDeprecated => TrimDeprecatedEx;
        public System.Boolean TrimDeprecatedEx { get; set; }

        public override System.Boolean TrimUnavailable => TrimUnavailableEx;
        public System.Boolean TrimUnavailableEx { get; set; }

    }
}

