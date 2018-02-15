
namespace Microsoft.SharePoint.Client
{
    public class AppTileMock
    {


        public override Microsoft.SharePoint.Client.AppType AppType => AppTypeEx;
        public Microsoft.SharePoint.Client.AppType AppTypeEx { get; set; }

        public override System.Int32 ChildCount => ChildCountEx;
        public System.Int32 ChildCountEx { get; set; }

        public override System.String LastModified => LastModifiedEx;
        public System.String LastModifiedEx { get; set; }

        public override System.String Target => TargetEx;
        public System.String TargetEx { get; set; }

        public override System.String Thumbnail => ThumbnailEx;
        public System.String ThumbnailEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

    }
}

