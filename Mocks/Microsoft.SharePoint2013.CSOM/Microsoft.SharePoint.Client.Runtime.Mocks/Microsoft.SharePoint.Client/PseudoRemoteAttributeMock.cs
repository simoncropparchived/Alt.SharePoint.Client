
namespace Microsoft.SharePoint.Client
{
    public class PseudoRemoteAttributeMock : PseudoRemoteAttribute
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

