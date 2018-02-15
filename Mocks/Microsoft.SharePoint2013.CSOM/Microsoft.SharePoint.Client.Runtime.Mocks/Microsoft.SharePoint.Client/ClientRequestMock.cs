
namespace Microsoft.SharePoint.Client
{
    public class ClientRequestMock : ClientRequest
    {


        public override Microsoft.SharePoint.Client.WebRequestExecutor RequestExecutor => RequestExecutorEx;
        public Microsoft.SharePoint.Client.WebRequestExecutor RequestExecutorEx { get; set; }

    }
}

