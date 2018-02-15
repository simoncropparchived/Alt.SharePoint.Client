
namespace Microsoft.SharePoint.Client
{
    public class MountPointInfoMock : MountPointInfo
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String RedirectUrl => RedirectUrlEx;
        public System.String RedirectUrlEx { get; set; }

    }
}

