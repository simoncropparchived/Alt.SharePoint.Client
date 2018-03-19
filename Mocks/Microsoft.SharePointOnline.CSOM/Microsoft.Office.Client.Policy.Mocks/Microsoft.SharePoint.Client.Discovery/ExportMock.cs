
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Discovery
{
    public class ExportMock : Export
    {


        public override Microsoft.SharePoint.Client.Discovery.ExportStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.Discovery.ExportStatus StatusEx { get; set; }

        public override void Update()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetExportContent()
        {
            return GetExportContentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetExportContentEx { get; set;}

    }
}

