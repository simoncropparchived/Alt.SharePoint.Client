
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.DocumentSet
{
    public class DocumentSetMock : DocumentSet
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> ExportDocumentSet()
        {
            return ExportDocumentSetEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> ExportDocumentSetEx { get; set;}

    }
}

