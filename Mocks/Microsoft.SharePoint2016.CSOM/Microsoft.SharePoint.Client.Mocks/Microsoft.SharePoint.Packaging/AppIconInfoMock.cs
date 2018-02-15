
namespace Microsoft.SharePoint.Packaging
{
    public class AppIconInfoMock : AppIconInfo
    {


        public override System.Byte[] Content => ContentEx;
        public System.Byte[] ContentEx { get; set; }

        public override System.String MimeType => MimeTypeEx;
        public System.String MimeTypeEx { get; set; }

    }
}

