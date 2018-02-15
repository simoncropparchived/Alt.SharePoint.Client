
namespace Microsoft.SharePoint.Client
{
    public class RoleAssignmentMock : RoleAssignment
    {


        public override Microsoft.SharePoint.Client.Principal Member => MemberEx;
        public Microsoft.SharePoint.Client.Principal MemberEx { get; set; }

        public override System.Int32 PrincipalId => PrincipalIdEx;
        public System.Int32 PrincipalIdEx { get; set; }

        public override Microsoft.SharePoint.Client.RoleDefinitionBindingCollection RoleDefinitionBindings => RoleDefinitionBindingsEx;
        public Microsoft.SharePoint.Client.RoleDefinitionBindingCollection RoleDefinitionBindingsEx { get; set; }

    }
}

