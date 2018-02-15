
namespace Microsoft.SharePoint.Client
{
    public class AppViewCreationInfoMock
    {


        public override System.Guid AppId => AppIdEx;
        public System.Guid AppIdEx { get; set; }

        public override System.Boolean IsPrivate => IsPrivateEx;
        public System.Boolean IsPrivateEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

