
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermSetCollectionMock : TermSetCollection
    {


        public override Microsoft.SharePoint.Client.Taxonomy.TermSet GetById(System.Guid @index)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet GetByName(System.String @index)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet GetByNameEx { get; set;}

    }
}

