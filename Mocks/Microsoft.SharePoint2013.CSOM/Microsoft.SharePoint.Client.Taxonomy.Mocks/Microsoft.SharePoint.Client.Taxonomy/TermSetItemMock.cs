
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermSetItemMock
    {


        public override System.Collections.Generic.IDictionary`2<System.String,System.String> CustomProperties => CustomPropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> CustomPropertiesEx { get; set; }

        public override System.String CustomSortOrder => CustomSortOrderEx;
        public System.String CustomSortOrderEx { get; set; }

        public override System.Boolean IsAvailableForTagging => IsAvailableForTaggingEx;
        public System.Boolean IsAvailableForTaggingEx { get; set; }

        public override System.String Owner => OwnerEx;
        public System.String OwnerEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection Terms => TermsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection TermsEx { get; set; }

    }
}

