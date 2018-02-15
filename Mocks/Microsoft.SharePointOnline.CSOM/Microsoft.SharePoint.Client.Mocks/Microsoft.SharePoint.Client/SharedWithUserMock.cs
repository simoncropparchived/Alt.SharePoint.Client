
namespace Microsoft.SharePoint.Client
{
    public class SharedWithUserMock
    {


        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

