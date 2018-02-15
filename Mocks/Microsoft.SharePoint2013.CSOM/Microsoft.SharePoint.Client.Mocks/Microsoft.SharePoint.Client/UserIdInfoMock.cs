
namespace Microsoft.SharePoint.Client
{
    public class UserIdInfoMock : UserIdInfo
    {


        public override System.String NameId => NameIdEx;
        public System.String NameIdEx { get; set; }

        public override System.String NameIdIssuer => NameIdIssuerEx;
        public System.String NameIdIssuerEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

