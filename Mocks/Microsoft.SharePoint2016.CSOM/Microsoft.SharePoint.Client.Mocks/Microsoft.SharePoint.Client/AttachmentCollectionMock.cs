
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AttachmentCollectionMock : AttachmentCollection
    {


        public override Microsoft.SharePoint.Client.Attachment Add(Microsoft.SharePoint.Client.AttachmentCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Attachment AddEx { get; set;}

        public override Microsoft.SharePoint.Client.Attachment GetByFileName(System.String @fileName)
        {
            return GetByFileNameEx;
        }
        public Microsoft.SharePoint.Client.Attachment GetByFileNameEx { get; set;}

    }
}

