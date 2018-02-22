
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ContentTypeCollectionMock : ContentTypeCollection
    {


        public override Microsoft.SharePoint.Client.ContentType GetById(System.String @contentTypeId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.ContentType GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ContentType AddExistingContentType(Microsoft.SharePoint.Client.ContentType @contentType)
        {
            return AddExistingContentTypeEx;
        }
        public Microsoft.SharePoint.Client.ContentType AddExistingContentTypeEx { get; set;}

        public override Microsoft.SharePoint.Client.ContentType Add(Microsoft.SharePoint.Client.ContentTypeCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.ContentType AddEx { get; set;}

    }
}

