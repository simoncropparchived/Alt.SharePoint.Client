
namespace Microsoft.SharePoint.Client
{
    public class AttachmentMock : Attachment
    {


        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

    }
}

