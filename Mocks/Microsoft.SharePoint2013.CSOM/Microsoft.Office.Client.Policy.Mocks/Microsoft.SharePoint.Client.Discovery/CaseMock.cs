
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Discovery
{
    public class CaseMock : Case
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetExportContent(System.Collections.Generic.IList<System.Int32> @sourceIds)
        {
            return GetExportContentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetExportContentEx { get; set;}

    }
}

