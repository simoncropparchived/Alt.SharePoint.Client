
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialExceptionDetailsMock : SocialExceptionDetails
    {


        public override System.Int32 InternalErrorCode => InternalErrorCodeEx;
        public System.Int32 InternalErrorCodeEx { get; set; }

        public override System.String InternalMessage => InternalMessageEx;
        public System.String InternalMessageEx { get; set; }

        public override System.String InternalStackTrace => InternalStackTraceEx;
        public System.String InternalStackTraceEx { get; set; }

        public override System.String InternalTypeName => InternalTypeNameEx;
        public System.String InternalTypeNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Social.SocialStatusCode StatusEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

