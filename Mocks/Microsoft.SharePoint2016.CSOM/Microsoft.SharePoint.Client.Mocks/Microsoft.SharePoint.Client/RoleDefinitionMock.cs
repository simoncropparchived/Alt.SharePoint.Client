
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RoleDefinitionMock : RoleDefinition
    {


        public override Microsoft.SharePoint.Client.BasePermissions BasePermissions => BasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions BasePermissionsEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

        public override Microsoft.SharePoint.Client.RoleType RoleTypeKind => RoleTypeKindEx;
        public Microsoft.SharePoint.Client.RoleType RoleTypeKindEx { get; set; }

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

