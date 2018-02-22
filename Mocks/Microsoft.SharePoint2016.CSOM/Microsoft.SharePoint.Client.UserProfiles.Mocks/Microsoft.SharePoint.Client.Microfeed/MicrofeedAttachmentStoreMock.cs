
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

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> PutFile(System.String @originalFileName, System.IO.Stream @fileData)
        {
            return PutFileEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> PutFileEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedLink> PreProcessAttachment(Microsoft.SharePoint.Client.Microfeed.MicrofeedLink @link)
        {
            return PreProcessAttachmentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedLink> PreProcessAttachmentEx { get; set;}

        public override void DeletePreProcessedAttachment(System.String @attachmentUri)
        {
        }

    }
}

