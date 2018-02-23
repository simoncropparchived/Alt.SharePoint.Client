
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class Office365TenantMock : Office365Tenant
    {


        public override System.Boolean AllowDownloadingNonWebViewableFiles => AllowDownloadingNonWebViewableFilesEx;
        public System.Boolean AllowDownloadingNonWebViewableFilesEx { get; set; }

        public override System.Collections.Generic.IList<System.Guid> AllowedDomainListForSyncClient => AllowedDomainListForSyncClientEx;
        public System.Collections.Generic.IList<System.Guid> AllowedDomainListForSyncClientEx { get; set; }

        public override System.Boolean AllowEditing => AllowEditingEx;
        public System.Boolean AllowEditingEx { get; set; }

        public override System.Boolean AllowLimitedAccessOnUnmanagedDevices => AllowLimitedAccessOnUnmanagedDevicesEx;
        public System.Boolean AllowLimitedAccessOnUnmanagedDevicesEx { get; set; }

        public override System.Boolean ApplyAppEnforcedRestrictionsToAdHocRecipients => ApplyAppEnforcedRestrictionsToAdHocRecipientsEx;
        public System.Boolean ApplyAppEnforcedRestrictionsToAdHocRecipientsEx { get; set; }

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

        public override System.Collections.Generic.IList<System.String> ExcludedFileExtensionsForSyncClient => ExcludedFileExtensionsForSyncClientEx;
        public System.Collections.Generic.IList<System.String> ExcludedFileExtensionsForSyncClientEx { get; set; }

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

        public override System.Boolean SocialBarOnSitePagesDisabled => SocialBarOnSitePagesDisabledEx;
        public System.Boolean SocialBarOnSitePagesDisabledEx { get; set; }

        public override System.String StartASiteFormUrl => StartASiteFormUrlEx;
        public System.String StartASiteFormUrlEx { get; set; }

        public override System.Boolean UseFindPeopleInPeoplePicker => UseFindPeopleInPeoplePickerEx;
        public System.Boolean UseFindPeopleInPeoplePickerEx { get; set; }

        public override System.Boolean UsePersistentCookiesForExplorerView => UsePersistentCookiesForExplorerViewEx;
        public System.Boolean UsePersistentCookiesForExplorerViewEx { get; set; }

        public override System.Boolean UserVoiceForFeedbackEnabled => UserVoiceForFeedbackEnabledEx;
        public System.Boolean UserVoiceForFeedbackEnabledEx { get; set; }

        public override void AddSdnProvider(System.String @identifier, System.String @license)
        {
        }

        public override void RemoveSdnProvider()
        {
        }

        public override Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsers(System.Int32 @position, System.Int32 @pageSize, System.String @filter, Microsoft.Online.SharePoint.TenantManagement.SortOrder @sortOrder)
        {
            return GetExternalUsersEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersWithSortBy(System.Int32 @position, System.Int32 @pageSize, System.String @filter, System.String @sortPropertyName, Microsoft.Online.SharePoint.TenantManagement.SortOrder @sortOrder)
        {
            return GetExternalUsersWithSortByEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersWithSortByEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersForSite(System.String @siteUrl, System.Int32 @position, System.Int32 @pageSize, System.String @filter, Microsoft.Online.SharePoint.TenantManagement.SortOrder @sortOrder)
        {
            return GetExternalUsersForSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersForSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.RemoveExternalUsersResults RemoveExternalUsers(System.String[] @uniqueIds)
        {
            return RemoveExternalUsersEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.RemoveExternalUsersResults RemoveExternalUsersEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> QueueImportProfileProperties(Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesUserIdType @idType, System.String @sourceDataIdProperty, System.Collections.Generic.IDictionary<System.String,System.String> @propertyMap, System.String @sourceUri)
        {
            return QueueImportProfilePropertiesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> QueueImportProfilePropertiesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteImportProfilePropertiesJob(System.Guid @jobId)
        {
            return DeleteImportProfilePropertiesJobEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteImportProfilePropertiesJobEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobStatusCollection GetImportProfilePropertyJobs()
        {
            return GetImportProfilePropertyJobsEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobStatusCollection GetImportProfilePropertyJobsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobInfo GetImportProfilePropertyJob(System.Guid @jobId)
        {
            return GetImportProfilePropertyJobEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobInfo GetImportProfilePropertyJobEx { get; set;}

        public override void DisableSharingForNonOwnersOfSite(System.String @siteUrl)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsSharingDisabledForNonOwnersOfSite(System.String @siteUrl)
        {
            return IsSharingDisabledForNonOwnersOfSiteEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsSharingDisabledForNonOwnersOfSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationResult RevokeAllUserSessions(System.String @userName)
        {
            return RevokeAllUserSessionsEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationResult RevokeAllUserSessionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationResult> RevokeAllUserSessionsByPuid(System.Collections.Generic.IList<System.String> @puidList)
        {
            return RevokeAllUserSessionsByPuidEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantManagement.SPOUserSessionRevocationResult> RevokeAllUserSessionsByPuidEx { get; set;}

        public override void CreateGroupForSite(System.String @siteUrl, System.String @displayName, System.String @alias, System.Boolean @isPublic, Microsoft.Online.SharePoint.TenantManagement.GroupCreationParams @optionalParams)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetIdleSessionSignOutForUnmanagedDevices(System.Boolean @enabled, System.TimeSpan @warnAfter, System.TimeSpan @signOutAfter)
        {
            return SetIdleSessionSignOutForUnmanagedDevicesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetIdleSessionSignOutForUnmanagedDevicesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetIdleSessionSignOutForUnmanagedDevices()
        {
            return GetIdleSessionSignOutForUnmanagedDevicesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetIdleSessionSignOutForUnmanagedDevicesEx { get; set;}

        public override void AddPublicCdnOrigin(System.String @origin)
        {
        }

        public override void RemovePublicCdnOrigin(System.String @originId)
        {
        }

        public override System.Collections.Generic.IList<System.String> GetTenantCdnOrigins(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType)
        {
            return GetTenantCdnOriginsEx;
        }
        public System.Collections.Generic.IList<System.String> GetTenantCdnOriginsEx { get; set;}

        public override void AddTenantCdnOrigin(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType, System.String @originUrl)
        {
        }

        public override void RemoveTenantCdnOrigin(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType, System.String @originUrl)
        {
        }

        public override void SetTenantCdnEnabled(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType, System.Boolean @isEnabled)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetTenantCdnEnabled(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType)
        {
            return GetTenantCdnEnabledEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetTenantCdnEnabledEx { get; set;}

        public override void SetTenantCdnPolicy(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType, Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnPolicyType @policy, System.String @policyValue)
        {
        }

        public override System.Collections.Generic.IList<System.String> GetTenantCdnPolicies(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType)
        {
            return GetTenantCdnPoliciesEx;
        }
        public System.Collections.Generic.IList<System.String> GetTenantCdnPoliciesEx { get; set;}

        public override void CreateTenantCdnDefaultOrigins(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddTenantTheme(System.String @name, System.String @themeJson)
        {
            return AddTenantThemeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddTenantThemeEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> UpdateTenantTheme(System.String @name, System.String @themeJson)
        {
            return UpdateTenantThemeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> UpdateTenantThemeEx { get; set;}

        public override void DeleteTenantTheme(System.String @name)
        {
        }

        public override Microsoft.Online.SharePoint.TenantManagement.ThemeProperties GetTenantTheme(System.String @name)
        {
            return GetTenantThemeEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.ThemeProperties GetTenantThemeEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantManagement.ThemeProperties> GetAllTenantThemes()
        {
            return GetAllTenantThemesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantManagement.ThemeProperties> GetAllTenantThemesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetHideDefaultThemes()
        {
            return GetHideDefaultThemesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetHideDefaultThemesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetHideDefaultThemes(System.Boolean @hideDefaultThemes)
        {
            return SetHideDefaultThemesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetHideDefaultThemesEx { get; set;}

    }
}

