
namespace Microsoft.SharePoint.Client
{
    public class RemoteAttributeMock : RemoteAttribute
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

