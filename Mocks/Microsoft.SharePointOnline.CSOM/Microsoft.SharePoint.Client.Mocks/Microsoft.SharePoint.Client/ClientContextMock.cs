
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientContextMock : ClientContext
    {


        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

        public override Microsoft.SharePoint.Client.Site Site => SiteEx;
        public Microsoft.SharePoint.Client.Site SiteEx { get; set; }

        public override Microsoft.SharePoint.Client.RequestResources RequestResources => RequestResourcesEx;
        public Microsoft.SharePoint.Client.RequestResources RequestResourcesEx { get; set; }

        public override System.Boolean FormDigestHandlingEnabled => FormDigestHandlingEnabledEx;
        public System.Boolean FormDigestHandlingEnabledEx { get; set; }

        public override System.Version ServerVersion => ServerVersionEx;
        public System.Version ServerVersionEx { get; set; }

        public override Microsoft.SharePoint.Client.FormDigestInfo GetFormDigestDirect()
        {
            return GetFormDigestDirectEx;
        }
        public Microsoft.SharePoint.Client.FormDigestInfo GetFormDigestDirectEx { get; set;}

        public override void ExecuteQuery()
        {
        }

        public override System.Threading.Tasks.Task ExecuteQueryAsync()
        {
            return ExecuteQueryAsyncEx;
        }
        public System.Threading.Tasks.Task ExecuteQueryAsyncEx { get; set;}

    }
}

