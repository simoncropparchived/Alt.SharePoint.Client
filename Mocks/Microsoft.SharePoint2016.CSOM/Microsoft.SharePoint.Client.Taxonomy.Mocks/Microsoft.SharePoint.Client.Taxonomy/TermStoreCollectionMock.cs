
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermStoreCollectionMock : TermStoreCollection
    {


        public override Microsoft.SharePoint.Client.Taxonomy.TermStore GetById(System.Guid @index)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermStore GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermStore GetByName(System.String @index)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermStore GetByNameEx { get; set;}

    }
}

