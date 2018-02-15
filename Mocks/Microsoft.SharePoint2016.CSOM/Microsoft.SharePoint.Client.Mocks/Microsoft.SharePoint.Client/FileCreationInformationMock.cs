
namespace Microsoft.SharePoint.Client
{
    public class FileCreationInformationMock : FileCreationInformation
    {


        public override System.Byte[] Content => ContentEx;
        public System.Byte[] ContentEx { get; set; }

        public override System.IO.Stream ContentStream => ContentStreamEx;
        public System.IO.Stream ContentStreamEx { get; set; }

        public override System.Boolean Overwrite => OverwriteEx;
        public System.Boolean OverwriteEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

