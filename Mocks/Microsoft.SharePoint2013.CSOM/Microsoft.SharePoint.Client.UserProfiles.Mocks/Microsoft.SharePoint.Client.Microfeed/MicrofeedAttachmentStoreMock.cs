
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedAttachmentStoreMock : MicrofeedAttachmentStore
    {


        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> PutImage(System.IO.Stream @imageData)
        {
            return PutImageEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> PutImageEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetImage(System.String @imageUrl, System.String @key, System.String @iv)
        {
            return GetImageEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetImageEx { get; set;}

    }
}

