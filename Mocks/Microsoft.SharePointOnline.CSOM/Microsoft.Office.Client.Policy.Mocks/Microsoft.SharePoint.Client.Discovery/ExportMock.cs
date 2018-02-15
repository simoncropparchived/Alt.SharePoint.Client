
namespace Microsoft.SharePoint.Client.Discovery
{
    public class ExportMock
    {


        public override Microsoft.SharePoint.Client.Discovery.ExportStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.Discovery.ExportStatus StatusEx { get; set; }

    }
}

