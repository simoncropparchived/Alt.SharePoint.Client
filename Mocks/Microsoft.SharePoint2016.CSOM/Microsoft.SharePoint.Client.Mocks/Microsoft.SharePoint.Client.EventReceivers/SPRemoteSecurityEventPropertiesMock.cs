
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteSecurityEventPropertiesMock : SPRemoteSecurityEventProperties
    {


        public override System.String UserDisplayName => UserDisplayNameEx;
        public System.String UserDisplayNameEx { get; set; }

        public override System.String UserLoginName => UserLoginNameEx;
        public System.String UserLoginNameEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override System.String WebFullUrl => WebFullUrlEx;
        public System.String WebFullUrlEx { get; set; }

        public override System.String GroupName => GroupNameEx;
        public System.String GroupNameEx { get; set; }

        public override System.Int32 GroupId => GroupIdEx;
        public System.Int32 GroupIdEx { get; set; }

        public override System.Int32 GroupOwnerId => GroupOwnerIdEx;
        public System.Int32 GroupOwnerIdEx { get; set; }

        public override System.Int32 GroupNewOwnerId => GroupNewOwnerIdEx;
        public System.Int32 GroupNewOwnerIdEx { get; set; }

        public override System.Int32 GroupUserId => GroupUserIdEx;
        public System.Int32 GroupUserIdEx { get; set; }

        public override System.String GroupUserLoginName => GroupUserLoginNameEx;
        public System.String GroupUserLoginNameEx { get; set; }

        public override System.String RoleDefinitionName => RoleDefinitionNameEx;
        public System.String RoleDefinitionNameEx { get; set; }

        public override System.UInt64 RoleDefinitionPermissions => RoleDefinitionPermissionsEx;
        public System.UInt64 RoleDefinitionPermissionsEx { get; set; }

        public override System.Int32 RoleDefinitionId => RoleDefinitionIdEx;
        public System.Int32 RoleDefinitionIdEx { get; set; }

        public override System.Int32 ObjectType => ObjectTypeEx;
        public System.Int32 ObjectTypeEx { get; set; }

        public override System.String ScopeUrl => ScopeUrlEx;
        public System.String ScopeUrlEx { get; set; }

        public override System.Int32 PrincipalId => PrincipalIdEx;
        public System.Int32 PrincipalIdEx { get; set; }

    }
}

