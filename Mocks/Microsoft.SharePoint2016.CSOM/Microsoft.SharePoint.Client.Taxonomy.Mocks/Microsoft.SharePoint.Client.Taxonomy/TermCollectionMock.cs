
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermCollectionMock : TermCollection
    {


        public override Microsoft.SharePoint.Client.Taxonomy.Term GetById(System.Guid @index)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetByName(System.String @index)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetByNameEx { get; set;}

    }
}

