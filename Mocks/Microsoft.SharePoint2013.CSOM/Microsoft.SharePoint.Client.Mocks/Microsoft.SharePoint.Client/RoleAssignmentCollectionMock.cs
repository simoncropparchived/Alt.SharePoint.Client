
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RoleAssignmentCollectionMock : RoleAssignmentCollection
    {


        public override Microsoft.SharePoint.Client.GroupCollection Groups => GroupsEx;
        public Microsoft.SharePoint.Client.GroupCollection GroupsEx { get; set; }

        public override Microsoft.SharePoint.Client.RoleAssignment GetByPrincipal(Microsoft.SharePoint.Client.Principal @principalToFind)
        {
            return GetByPrincipalEx;
        }
        public Microsoft.SharePoint.Client.RoleAssignment GetByPrincipalEx { get; set;}

        public override Microsoft.SharePoint.Client.RoleAssignment GetByPrincipalId(System.Int32 @principalId)
        {
            return GetByPrincipalIdEx;
        }
        public Microsoft.SharePoint.Client.RoleAssignment GetByPrincipalIdEx { get; set;}

        public override Microsoft.SharePoint.Client.RoleAssignment Add(Microsoft.SharePoint.Client.Principal @principal, Microsoft.SharePoint.Client.RoleDefinitionBindingCollection @roleBindings)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.RoleAssignment AddEx { get; set;}

    }
}

