
namespace Microsoft.Office.Client.Education
{
    public class DocumentMock : Document
    {


        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String FileUrl => FileUrlEx;
        public System.String FileUrlEx { get; set; }

    }
}

