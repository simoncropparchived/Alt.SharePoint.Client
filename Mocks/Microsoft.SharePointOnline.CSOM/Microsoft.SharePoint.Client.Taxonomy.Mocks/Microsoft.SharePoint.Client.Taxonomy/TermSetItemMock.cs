
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermSetItemMock : TermSetItem
    {


        public override System.Collections.Generic.IDictionary<System.String,System.String> CustomProperties => CustomPropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> CustomPropertiesEx { get; set; }

        public override System.String CustomSortOrder => CustomSortOrderEx;
        public System.String CustomSortOrderEx { get; set; }

        public override System.Boolean IsAvailableForTagging => IsAvailableForTaggingEx;
        public System.Boolean IsAvailableForTaggingEx { get; set; }

        public override System.String Owner => OwnerEx;
        public System.String OwnerEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection Terms => TermsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection TermsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term CreateTerm(System.String @name, System.Int32 @lcid, System.Guid @newTermId)
        {
            return CreateTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term CreateTermEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTerms(System.Int32 @pagingLimit)
        {
            return GetTermsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term ReuseTerm(Microsoft.SharePoint.Client.Taxonomy.Term @sourceTerm, System.Boolean @reuseBranch)
        {
            return ReuseTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term ReuseTermEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term ReuseTermWithPinning(Microsoft.SharePoint.Client.Taxonomy.Term @sourceTerm)
        {
            return ReuseTermWithPinningEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term ReuseTermWithPinningEx { get; set;}

        public override void DeleteCustomProperty(System.String @name)
        {
        }

        public override void DeleteAllCustomProperties()
        {
        }

        public override void SetCustomProperty(System.String @name, System.String @value)
        {
        }

    }
}

