
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class Office365TenantMock : Office365Tenant
    {


        public override System.Boolean AllowDownloadingNonWebViewableFiles => AllowDownloadingNonWebViewableFilesEx;
        public System.Boolean AllowDownloadingNonWebViewableFilesEx { get; set; }

        public override System.Collections.Generic.IList`1<System.Guid> AllowedDomainListForSyncClient => AllowedDomainListForSyncClientEx;
        public System.Collections.Generic.IList`1<System.Guid> AllowedDomainListForSyncClientEx { get; set; }

        public override System.Boolean AllowEditing => AllowEditingEx;
        public System.Boolean AllowEditingEx { get; set; }

        public override System.Boolean AllowLimitedAccessOnUnmanagedDevices => AllowLimitedAccessOnUnmanagedDevicesEx;
        public System.Boolean AllowLimitedAccessOnUnmanagedDevicesEx { get; set; }

        public override System.Boolean BccExternalSharingInvitations => BccExternalSharingInvitationsEx;
        public System.Boolean BccExternalSharingInvitationsEx { get; set; }

        public override System.String BccExternalSharingInvitationsList => BccExternalSharingInvitationsListEx;
        public System.String BccExternalSharingInvitationsListEx { get; set; }

        public override System.Boolean BlockAccessOnUnmanagedDevices => BlockAccessOnUnmanagedDevicesEx;
        public System.Boolean BlockAccessOnUnmanagedDevicesEx { get; set; }

        public override System.Boolean BlockDownloadOfAllFilesForGuests => BlockDownloadOfAllFilesForGuestsEx;
        public System.Boolean BlockDownloadOfAllFilesForGuestsEx { get; set; }

        public override System.Boolean BlockDownloadOfAllFilesOnUnmanagedDevices => BlockDownloadOfAllFilesOnUnmanagedDevicesEx;
        public System.Boolean BlockDownloadOfAllFilesOnUnmanagedDevicesEx { get; set; }

        public override System.Boolean BlockDownloadOfViewableFilesForGuests => BlockDownloadOfViewableFilesForGuestsEx;
        public System.Boolean BlockDownloadOfViewableFilesForGuestsEx { get; set; }

        public override System.Boolean BlockDownloadOfViewableFilesOnUnmanagedDevices => BlockDownloadOfViewableFilesOnUnmanagedDevicesEx;
        public System.Boolean BlockDownloadOfViewableFilesOnUnmanagedDevicesEx { get; set; }

        public override System.Boolean BlockMacSync => BlockMacSyncEx;
        public System.Boolean BlockMacSyncEx { get; set; }

        public override System.Boolean CommentsOnSitePagesDisabled => CommentsOnSitePagesDisabledEx;
        public System.Boolean CommentsOnSitePagesDisabledEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SPOConditionalAccessPolicyType ConditionalAccessPolicy => ConditionalAccessPolicyEx;
        public Microsoft.Online.SharePoint.TenantManagement.SPOConditionalAccessPolicyType ConditionalAccessPolicyEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingPermissionType DefaultLinkPermission => DefaultLinkPermissionEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingPermissionType DefaultLinkPermissionEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingLinkType DefaultSharingLinkType => DefaultSharingLinkTypeEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingLinkType DefaultSharingLinkTypeEx { get; set; }

        public override System.Boolean DisplayStartASiteOption => DisplayStartASiteOptionEx;
        public System.Boolean DisplayStartASiteOptionEx { get; set; }

        public override System.Int32 EmailAttestationReAuthDays => EmailAttestationReAuthDaysEx;
        public System.Int32 EmailAttestationReAuthDaysEx { get; set; }

        public override System.Boolean EmailAttestationRequired => EmailAttestationRequiredEx;
        public System.Boolean EmailAttestationRequiredEx { get; set; }

        public override System.Boolean EnableGuestSignInAcceleration => EnableGuestSignInAccelerationEx;
        public System.Boolean EnableGuestSignInAccelerationEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> ExcludedFileExtensionsForSyncClient => ExcludedFileExtensionsForSyncClientEx;
        public System.Collections.Generic.IList`1<System.String> ExcludedFileExtensionsForSyncClientEx { get; set; }

        public override System.Boolean ExternalServicesEnabled => ExternalServicesEnabledEx;
        public System.Boolean ExternalServicesEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.AnonymousLinkType FileAnonymousLinkType => FileAnonymousLinkTypeEx;
        public Microsoft.SharePoint.Client.AnonymousLinkType FileAnonymousLinkTypeEx { get; set; }

        public override System.Boolean FilePickerExternalImageSearchEnabled => FilePickerExternalImageSearchEnabledEx;
        public System.Boolean FilePickerExternalImageSearchEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.AnonymousLinkType FolderAnonymousLinkType => FolderAnonymousLinkTypeEx;
        public Microsoft.SharePoint.Client.AnonymousLinkType FolderAnonymousLinkTypeEx { get; set; }

        public override System.Boolean HideSyncButtonOnODB => HideSyncButtonOnODBEx;
        public System.Boolean HideSyncButtonOnODBEx { get; set; }

        public override System.String IPAddressAllowList => IPAddressAllowListEx;
        public System.String IPAddressAllowListEx { get; set; }

        public override System.Boolean IPAddressEnforcement => IPAddressEnforcementEx;
        public System.Boolean IPAddressEnforcementEx { get; set; }

        public override System.Int32 IPAddressWACTokenLifetime => IPAddressWACTokenLifetimeEx;
        public System.Int32 IPAddressWACTokenLifetimeEx { get; set; }

        public override System.Boolean IsUnmanagedSyncClientForTenantRestricted => IsUnmanagedSyncClientForTenantRestrictedEx;
        public System.Boolean IsUnmanagedSyncClientForTenantRestrictedEx { get; set; }

        public override System.Boolean IsUnmanagedSyncClientRestrictionFlightEnabled => IsUnmanagedSyncClientRestrictionFlightEnabledEx;
        public System.Boolean IsUnmanagedSyncClientRestrictionFlightEnabledEx { get; set; }

        public override System.Boolean LegacyAuthProtocolsEnabled => LegacyAuthProtocolsEnabledEx;
        public System.Boolean LegacyAuthProtocolsEnabledEx { get; set; }

        public override System.Boolean MySitesPublicEnabled => MySitesPublicEnabledEx;
        public System.Boolean MySitesPublicEnabledEx { get; set; }

        public override System.Boolean NotificationsInOneDriveForBusinessEnabled => NotificationsInOneDriveForBusinessEnabledEx;
        public System.Boolean NotificationsInOneDriveForBusinessEnabledEx { get; set; }

        public override System.Boolean NotificationsInSharePointEnabled => NotificationsInSharePointEnabledEx;
        public System.Boolean NotificationsInSharePointEnabledEx { get; set; }

        public override System.Boolean NotifyOwnersWhenInvitationsAccepted => NotifyOwnersWhenInvitationsAcceptedEx;
        public System.Boolean NotifyOwnersWhenInvitationsAcceptedEx { get; set; }

        public override System.Boolean NotifyOwnersWhenItemsReshared => NotifyOwnersWhenItemsResharedEx;
        public System.Boolean NotifyOwnersWhenItemsResharedEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingState ODBAccessRequests => ODBAccessRequestsEx;
        public Microsoft.SharePoint.Client.SharingState ODBAccessRequestsEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingState ODBMembersCanShare => ODBMembersCanShareEx;
        public Microsoft.SharePoint.Client.SharingState ODBMembersCanShareEx { get; set; }

        public override System.Boolean OfficeClientADALDisabled => OfficeClientADALDisabledEx;
        public System.Boolean OfficeClientADALDisabledEx { get; set; }

        public override System.Boolean OneDriveForGuestsEnabled => OneDriveForGuestsEnabledEx;
        public System.Boolean OneDriveForGuestsEnabledEx { get; set; }

        public override System.Boolean OwnerAnonymousNotification => OwnerAnonymousNotificationEx;
        public System.Boolean OwnerAnonymousNotificationEx { get; set; }

        public override System.Boolean PreventExternalUsersFromResharing => PreventExternalUsersFromResharingEx;
        public System.Boolean PreventExternalUsersFromResharingEx { get; set; }

        public override System.Boolean ProvisionSharedWithEveryoneFolder => ProvisionSharedWithEveryoneFolderEx;
        public System.Boolean ProvisionSharedWithEveryoneFolderEx { get; set; }

        public override System.String PublicCdnAllowedFileTypes => PublicCdnAllowedFileTypesEx;
        public System.String PublicCdnAllowedFileTypesEx { get; set; }

        public override System.Boolean PublicCdnEnabled => PublicCdnEnabledEx;
        public System.Boolean PublicCdnEnabledEx { get; set; }

        public override System.Collections.Generic.IList<System.String> PublicCdnOrigins => PublicCdnOriginsEx;
        public System.Collections.Generic.IList<System.String> PublicCdnOriginsEx { get; set; }

        public override System.Boolean RequireAcceptingAccountMatchInvitedAccount => RequireAcceptingAccountMatchInvitedAccountEx;
        public System.Boolean RequireAcceptingAccountMatchInvitedAccountEx { get; set; }

        public override System.Int32 RequireAnonymousLinksExpireInDays => RequireAnonymousLinksExpireInDaysEx;
        public System.Int32 RequireAnonymousLinksExpireInDaysEx { get; set; }

        public override System.Boolean SearchResolveExactEmailOrUPN => SearchResolveExactEmailOrUPNEx;
        public System.Boolean SearchResolveExactEmailOrUPNEx { get; set; }

        public override System.String SharingAllowedDomainList => SharingAllowedDomainListEx;
        public System.String SharingAllowedDomainListEx { get; set; }

        public override System.String SharingBlockedDomainList => SharingBlockedDomainListEx;
        public System.String SharingBlockedDomainListEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapability => SharingCapabilityEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapabilityEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingDomainRestrictionModes SharingDomainRestrictionMode => SharingDomainRestrictionModeEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingDomainRestrictionModes SharingDomainRestrictionModeEx { get; set; }

        public override System.Boolean ShowAllUsersClaim => ShowAllUsersClaimEx;
        public System.Boolean ShowAllUsersClaimEx { get; set; }

        public override System.Boolean ShowEveryoneClaim => ShowEveryoneClaimEx;
        public System.Boolean ShowEveryoneClaimEx { get; set; }

        public override System.Boolean ShowEveryoneExceptExternalUsersClaim => ShowEveryoneExceptExternalUsersClaimEx;
        public System.Boolean ShowEveryoneExceptExternalUsersClaimEx { get; set; }

        public override System.Boolean ShowNGSCDialogForSyncOnODB => ShowNGSCDialogForSyncOnODBEx;
        public System.Boolean ShowNGSCDialogForSyncOnODBEx { get; set; }

        public override System.Boolean ShowPeoplePickerSuggestionsForGuestUsers => ShowPeoplePickerSuggestionsForGuestUsersEx;
        public System.Boolean ShowPeoplePickerSuggestionsForGuestUsersEx { get; set; }

        public override System.String SignInAccelerationDomain => SignInAccelerationDomainEx;
        public System.String SignInAccelerationDomainEx { get; set; }

        public override System.String StartASiteFormUrl => StartASiteFormUrlEx;
        public System.String StartASiteFormUrlEx { get; set; }

        public override System.Boolean UseFindPeopleInPeoplePicker => UseFindPeopleInPeoplePickerEx;
        public System.Boolean UseFindPeopleInPeoplePickerEx { get; set; }

        public override System.Boolean UsePersistentCookiesForExplorerView => UsePersistentCookiesForExplorerViewEx;
        public System.Boolean UsePersistentCookiesForExplorerViewEx { get; set; }

        public override System.Boolean UserVoiceForFeedbackEnabled => UserVoiceForFeedbackEnabledEx;
        public System.Boolean UserVoiceForFeedbackEnabledEx { get; set; }

    }
}

