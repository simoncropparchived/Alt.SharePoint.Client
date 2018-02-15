
namespace Microsoft.SharePoint.Client
{
    public class AttachmentCreationInformationMock
    {


        public override System.IO.Stream ContentStream => ContentStreamEx;
        public System.IO.Stream ContentStreamEx { get; set; }

        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

