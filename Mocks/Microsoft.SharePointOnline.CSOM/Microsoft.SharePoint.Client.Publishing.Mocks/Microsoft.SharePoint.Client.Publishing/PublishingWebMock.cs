
namespace Microsoft.SharePoint.Client.Publishing
{
    public class PublishingWebMock : PublishingWeb
    {


        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

    }
}

