
namespace Microsoft.SharePoint.Client
{
    public class PrincipalMock : Principal
    {


        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.Boolean IsHiddenInUI => IsHiddenInUIEx;
        public System.Boolean IsHiddenInUIEx { get; set; }

        public override System.String LoginName => LoginNameEx;
        public System.String LoginNameEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalType => PrincipalTypeEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalTypeEx { get; set; }

    }
}

