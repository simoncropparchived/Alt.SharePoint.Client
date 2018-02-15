
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SharePagePreviewByEmailFieldsDataMock : SharePagePreviewByEmailFieldsData
    {


        public override System.String message => messageEx;
        public System.String messageEx { get; set; }

        public override System.String[] recipientEmails => recipientEmailsEx;
        public System.String[] recipientEmailsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

