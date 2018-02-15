
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermMock
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean IsDeprecated => IsDeprecatedEx;
        public System.Boolean IsDeprecatedEx { get; set; }

        public override System.Boolean IsKeyword => IsKeywordEx;
        public System.Boolean IsKeywordEx { get; set; }

        public override System.Boolean IsPinned => IsPinnedEx;
        public System.Boolean IsPinnedEx { get; set; }

        public override System.Boolean IsPinnedRoot => IsPinnedRootEx;
        public System.Boolean IsPinnedRootEx { get; set; }

        public override System.Boolean IsReused => IsReusedEx;
        public System.Boolean IsReusedEx { get; set; }

        public override System.Boolean IsRoot => IsRootEx;
        public System.Boolean IsRootEx { get; set; }

        public override System.Boolean IsSourceTerm => IsSourceTermEx;
        public System.Boolean IsSourceTermEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.LabelCollection Labels => LabelsEx;
        public Microsoft.SharePoint.Client.Taxonomy.LabelCollection LabelsEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.String> LocalCustomProperties => LocalCustomPropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> LocalCustomPropertiesEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Guid> MergedTermIds => MergedTermIdsEx;
        public System.Collections.Generic.IEnumerable`1<System.Guid> MergedTermIdsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term Parent => ParentEx;
        public Microsoft.SharePoint.Client.Taxonomy.Term ParentEx { get; set; }

        public override System.String PathOfTerm => PathOfTermEx;
        public System.String PathOfTermEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet PinSourceTermSet => PinSourceTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet PinSourceTermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection ReusedTerms => ReusedTermsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection ReusedTermsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term SourceTerm => SourceTermEx;
        public Microsoft.SharePoint.Client.Taxonomy.Term SourceTermEx { get; set; }

        public override System.Int32 TermsCount => TermsCountEx;
        public System.Int32 TermsCountEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet TermSet => TermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet TermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSets => TermSetsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSetsEx { get; set; }

    }
}

