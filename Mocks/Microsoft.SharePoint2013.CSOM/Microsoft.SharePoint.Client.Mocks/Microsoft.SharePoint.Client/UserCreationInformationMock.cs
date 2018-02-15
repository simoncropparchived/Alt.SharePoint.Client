
namespace Microsoft.SharePoint.Client
{
    public class UserCreationInformationMock : UserCreationInformation
    {


        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.String LoginName => LoginNameEx;
        public System.String LoginNameEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

