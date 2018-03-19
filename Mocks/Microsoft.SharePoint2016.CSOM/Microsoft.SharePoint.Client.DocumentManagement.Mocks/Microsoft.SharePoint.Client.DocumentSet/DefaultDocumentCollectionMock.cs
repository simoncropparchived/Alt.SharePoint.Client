
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.DocumentSet
{
    public class DefaultDocumentCollectionMock : DefaultDocumentCollection
    {


        public override Microsoft.SharePoint.Client.DocumentSet.DefaultDocument Add(System.String @name, Microsoft.SharePoint.Client.ContentTypeId @ctId, System.Byte[] @content)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.DocumentSet.DefaultDocument AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> ChangeContentTypeForDocument(System.String @name, Microsoft.SharePoint.Client.ContentTypeId @contentTypeId)
        {
            return ChangeContentTypeForDocumentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> ChangeContentTypeForDocumentEx { get; set;}

        public override void Remove(System.String @name)
        {
        }

    }
}

