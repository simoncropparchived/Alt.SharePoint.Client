
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomyItemMock : TaxonomyItem
    {


        public override System.DateTime CreatedDate => CreatedDateEx;
        public System.DateTime CreatedDateEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.DateTime LastModifiedDate => LastModifiedDateEx;
        public System.DateTime LastModifiedDateEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermStore TermStore => TermStoreEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermStore TermStoreEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

