
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListTemplateCollectionMock : ListTemplateCollection
    {


        public override Microsoft.SharePoint.Client.ListTemplate GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.ListTemplate GetByNameEx { get; set;}

    }
}

