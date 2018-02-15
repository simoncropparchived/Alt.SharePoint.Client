
namespace Microsoft.SharePoint.Client
{
    public class RoleAssignmentCollectionMock : RoleAssignmentCollection
    {


        public override Microsoft.SharePoint.Client.GroupCollection Groups => GroupsEx;
        public Microsoft.SharePoint.Client.GroupCollection GroupsEx { get; set; }

    }
}

