
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class WebTemplateCollectionMock : WebTemplateCollection
    {


        public override Microsoft.SharePoint.Client.WebTemplate GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.WebTemplate GetByNameEx { get; set;}

    }
}

