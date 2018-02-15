
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SiteSharingEmailContextMock : SiteSharingEmailContext
    {


        public override System.String CustomDescription => CustomDescriptionEx;
        public System.String CustomDescriptionEx { get; set; }

        public override System.String CustomTitle => CustomTitleEx;
        public System.String CustomTitleEx { get; set; }

        public override System.String Message => MessageEx;
        public System.String MessageEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

