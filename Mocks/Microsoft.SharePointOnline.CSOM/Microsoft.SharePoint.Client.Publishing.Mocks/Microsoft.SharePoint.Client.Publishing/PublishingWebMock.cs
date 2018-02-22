
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class PublishingWebMock : PublishingWeb
    {


        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.PublishingPage AddPublishingPage(Microsoft.SharePoint.Client.Publishing.PublishingPageInformation @pageInformation)
        {
            return AddPublishingPageEx;
        }
        public Microsoft.SharePoint.Client.Publishing.PublishingPage AddPublishingPageEx { get; set;}

    }
}

