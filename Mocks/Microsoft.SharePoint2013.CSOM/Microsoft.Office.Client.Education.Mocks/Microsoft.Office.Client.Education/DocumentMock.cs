
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class DocumentMock : Document
    {


        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String FileUrl => FileUrlEx;
        public System.String FileUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetStream()
        {
            return GetStreamEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetStreamEx { get; set;}

        public override void SetStream(System.IO.Stream @stream)
        {
        }

    }
}

