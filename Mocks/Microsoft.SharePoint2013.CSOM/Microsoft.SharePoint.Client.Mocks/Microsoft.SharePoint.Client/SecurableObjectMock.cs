
namespace Microsoft.SharePoint.Client
{
    public class SecurableObjectMock
    {


        public override Microsoft.SharePoint.Client.SecurableObject FirstUniqueAncestorSecurableObject => FirstUniqueAncestorSecurableObjectEx;
        public Microsoft.SharePoint.Client.SecurableObject FirstUniqueAncestorSecurableObjectEx { get; set; }

        public override System.Boolean HasUniqueRoleAssignments => HasUniqueRoleAssignmentsEx;
        public System.Boolean HasUniqueRoleAssignmentsEx { get; set; }

        public override Microsoft.SharePoint.Client.RoleAssignmentCollection RoleAssignments => RoleAssignmentsEx;
        public Microsoft.SharePoint.Client.RoleAssignmentCollection RoleAssignmentsEx { get; set; }

    }
}

