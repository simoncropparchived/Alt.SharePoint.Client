
namespace Microsoft.Online.SharePoint.SPLogger
{
    public class LogFileInfoMock
    {


        public override System.String AlternateUrl => AlternateUrlEx;
        public System.String AlternateUrlEx { get; set; }

        public override System.Byte[] DecryptionIV => DecryptionIVEx;
        public System.Byte[] DecryptionIVEx { get; set; }

        public override System.Byte[] DecryptionKey => DecryptionKeyEx;
        public System.Byte[] DecryptionKeyEx { get; set; }

        public override System.String Exception => ExceptionEx;
        public System.String ExceptionEx { get; set; }

        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

    }
}

