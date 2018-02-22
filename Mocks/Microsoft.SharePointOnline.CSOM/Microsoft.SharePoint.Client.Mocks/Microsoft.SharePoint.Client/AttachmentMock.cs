
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AttachmentMock : Attachment
    {


        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath FileNameAsPath => FileNameAsPathEx;
        public Microsoft.SharePoint.Client.ResourcePath FileNameAsPathEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ServerRelativePath => ServerRelativePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ServerRelativePathEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override void DeleteObject()
        {
        }

        public override void RecycleObject()
        {
        }

    }
}

