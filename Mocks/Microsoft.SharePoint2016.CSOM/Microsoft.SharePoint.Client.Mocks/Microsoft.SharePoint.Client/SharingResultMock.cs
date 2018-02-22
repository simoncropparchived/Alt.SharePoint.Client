
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class SharingResultMock : SharingResult
    {


        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override Microsoft.SharePoint.Client.GroupCollection GroupsSharedWith => GroupsSharedWithEx;
        public Microsoft.SharePoint.Client.GroupCollection GroupsSharedWithEx { get; set; }

        public override Microsoft.SharePoint.Client.Group GroupUsersAddedTo => GroupUsersAddedToEx;
        public Microsoft.SharePoint.Client.Group GroupUsersAddedToEx { get; set; }

        public override System.String IconUrl => IconUrlEx;
        public System.String IconUrlEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.SPInvitationCreationResult> InvitedUsers => InvitedUsersEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.SPInvitationCreationResult> InvitedUsersEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String PermissionsPageRelativeUrl => PermissionsPageRelativeUrlEx;
        public System.String PermissionsPageRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingOperationStatusCode StatusCode => StatusCodeEx;
        public Microsoft.SharePoint.Client.SharingOperationStatusCode StatusCodeEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Sharing.UserSharingResult> UniquelyPermissionedUsers => UniquelyPermissionedUsersEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Sharing.UserSharingResult> UniquelyPermissionedUsersEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Sharing.UserSharingResult> UsersAddedToGroup => UsersAddedToGroupEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Sharing.UserSharingResult> UsersAddedToGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingUserCollection UsersWithAccessRequests => UsersWithAccessRequestsEx;
        public Microsoft.SharePoint.Client.SharingUserCollection UsersWithAccessRequestsEx { get; set; }

    }
}

