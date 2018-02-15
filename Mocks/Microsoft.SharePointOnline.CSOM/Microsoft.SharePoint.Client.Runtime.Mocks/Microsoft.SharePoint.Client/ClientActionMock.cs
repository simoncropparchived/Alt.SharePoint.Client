
namespace Microsoft.SharePoint.Client
{
    public class ClientActionMock
    {


        public override System.Int64 Id => IdEx;
        public System.Int64 IdEx { get; set; }

        public override Microsoft.SharePoint.Client.ObjectPath Path => PathEx;
        public Microsoft.SharePoint.Client.ObjectPath PathEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

