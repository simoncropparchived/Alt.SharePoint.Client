
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ObjectSharingSettingsMock : ObjectSharingSettings
    {


        public override System.Boolean AccessRequestMode => AccessRequestModeEx;
        public System.Boolean AccessRequestModeEx { get; set; }

        public override System.Boolean CanCurrentUserManageOrganizationReadonlyLink => CanCurrentUserManageOrganizationReadonlyLinkEx;
        public System.Boolean CanCurrentUserManageOrganizationReadonlyLinkEx { get; set; }

        public override System.Boolean CanCurrentUserManageOrganizationReadWriteLink => CanCurrentUserManageOrganizationReadWriteLinkEx;
        public System.Boolean CanCurrentUserManageOrganizationReadWriteLinkEx { get; set; }

        public override System.Boolean CanCurrentUserManageReadonlyLink => CanCurrentUserManageReadonlyLinkEx;
        public System.Boolean CanCurrentUserManageReadonlyLinkEx { get; set; }

        public override System.Boolean CanCurrentUserManageReadWriteLink => CanCurrentUserManageReadWriteLinkEx;
        public System.Boolean CanCurrentUserManageReadWriteLinkEx { get; set; }

        public override System.Boolean CanCurrentUserRetrieveOrganizationReadonlyLink => CanCurrentUserRetrieveOrganizationReadonlyLinkEx;
        public System.Boolean CanCurrentUserRetrieveOrganizationReadonlyLinkEx { get; set; }

        public override System.Boolean CanCurrentUserRetrieveOrganizationReadWriteLink => CanCurrentUserRetrieveOrganizationReadWriteLinkEx;
        public System.Boolean CanCurrentUserRetrieveOrganizationReadWriteLinkEx { get; set; }

        public override System.Boolean CanCurrentUserRetrieveReadonlyLink => CanCurrentUserRetrieveReadonlyLinkEx;
        public System.Boolean CanCurrentUserRetrieveReadonlyLinkEx { get; set; }

        public override System.Boolean CanCurrentUserRetrieveReadWriteLink => CanCurrentUserRetrieveReadWriteLinkEx;
        public System.Boolean CanCurrentUserRetrieveReadWriteLinkEx { get; set; }

        public override System.Boolean CanCurrentUserShareExternally => CanCurrentUserShareExternallyEx;
        public System.Boolean CanCurrentUserShareExternallyEx { get; set; }

        public override System.Boolean CanCurrentUserShareInternally => CanCurrentUserShareInternallyEx;
        public System.Boolean CanCurrentUserShareInternallyEx { get; set; }

        public override System.Boolean CanSendEmail => CanSendEmailEx;
        public System.Boolean CanSendEmailEx { get; set; }

        public override System.Boolean CanSendLink => CanSendLinkEx;
        public System.Boolean CanSendLinkEx { get; set; }

        public override System.Boolean CanShareFolder => CanShareFolderEx;
        public System.Boolean CanShareFolderEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> GroupsList => GroupsListEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> GroupsListEx { get; set; }

        public override System.Boolean HasEditRole => HasEditRoleEx;
        public System.Boolean HasEditRoleEx { get; set; }

        public override System.Boolean HasReadRole => HasReadRoleEx;
        public System.Boolean HasReadRoleEx { get; set; }

        public override System.String InheritingWebLink => InheritingWebLinkEx;
        public System.String InheritingWebLinkEx { get; set; }

        public override System.Boolean IsGuestUser => IsGuestUserEx;
        public System.Boolean IsGuestUserEx { get; set; }

        public override System.Boolean IsPictureLibrary => IsPictureLibraryEx;
        public System.Boolean IsPictureLibraryEx { get; set; }

        public override System.Boolean IsUserSiteAdmin => IsUserSiteAdminEx;
        public System.Boolean IsUserSiteAdminEx { get; set; }

        public override System.String ItemId => ItemIdEx;
        public System.String ItemIdEx { get; set; }

        public override System.String ItemName => ItemNameEx;
        public System.String ItemNameEx { get; set; }

        public override System.String ItemUrl => ItemUrlEx;
        public System.String ItemUrlEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ObjectSharingInformation ObjectSharingInformation => ObjectSharingInformationEx;
        public Microsoft.SharePoint.Client.ObjectSharingInformation ObjectSharingInformationEx { get; set; }

        public override System.Boolean PermissionsOnlyMode => PermissionsOnlyModeEx;
        public System.Boolean PermissionsOnlyModeEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> Roles => RolesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> RolesEx { get; set; }

        public override System.Boolean ShareByEmailEnabled => ShareByEmailEnabledEx;
        public System.Boolean ShareByEmailEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.SharePointSharingSettings SharePointSettings => SharePointSettingsEx;
        public Microsoft.SharePoint.Client.SharePointSharingSettings SharePointSettingsEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingPermissionInformationCollection SharingPermissions => SharingPermissionsEx;
        public Microsoft.SharePoint.Client.SharingPermissionInformationCollection SharingPermissionsEx { get; set; }

        public override System.Boolean ShowExternalSharingWarning => ShowExternalSharingWarningEx;
        public System.Boolean ShowExternalSharingWarningEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> SimplifiedRoles => SimplifiedRolesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> SimplifiedRolesEx { get; set; }

        public override System.Boolean SupportsAclPropagation => SupportsAclPropagationEx;
        public System.Boolean SupportsAclPropagationEx { get; set; }

        public override System.String WebUrl => WebUrlEx;
        public System.String WebUrlEx { get; set; }

    }
}

