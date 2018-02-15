
namespace Microsoft.SharePoint.Client.Utilities
{
    public class PrincipalInfoMock : PrincipalInfo
    {


        public override System.String Department => DepartmentEx;
        public System.String DepartmentEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.String JobTitle => JobTitleEx;
        public System.String JobTitleEx { get; set; }

        public override System.String LoginName => LoginNameEx;
        public System.String LoginNameEx { get; set; }

        public override System.String Mobile => MobileEx;
        public System.String MobileEx { get; set; }

        public override System.Int32 PrincipalId => PrincipalIdEx;
        public System.Int32 PrincipalIdEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalType => PrincipalTypeEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalTypeEx { get; set; }

        public override System.String SIPAddress => SIPAddressEx;
        public System.String SIPAddressEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

