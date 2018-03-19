
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermGroupCollectionMock : TermGroupCollection
    {


        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup GetById(System.Guid @index)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup GetByName(System.String @index)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GetByNameEx { get; set;}

    }
}

