
namespace Microsoft.SharePoint.Client
{
    public class FileInformationMock
    {


        public override System.IO.Stream Stream => StreamEx;
        public System.IO.Stream StreamEx { get; set; }

        public override System.String ETag => ETagEx;
        public System.String ETagEx { get; set; }

    }
}

