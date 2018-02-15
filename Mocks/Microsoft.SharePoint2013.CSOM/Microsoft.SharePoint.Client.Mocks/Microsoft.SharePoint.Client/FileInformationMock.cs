
namespace Microsoft.SharePoint.Client
{
    public class FileInformationMock : FileInformation
    {


        public override System.IO.Stream Stream => StreamEx;
        public System.IO.Stream StreamEx { get; set; }

        public override System.String ETag => ETagEx;
        public System.String ETagEx { get; set; }

    }
}

