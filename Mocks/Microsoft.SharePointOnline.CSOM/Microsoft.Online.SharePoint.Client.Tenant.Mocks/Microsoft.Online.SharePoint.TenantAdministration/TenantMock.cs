
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantMock : Tenant
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

        public override System.String CompatibilityRange => CompatibilityRangeEx;
        public System.String CompatibilityRangeEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SPOConditionalAccessPolicyType ConditionalAccessPolicy => ConditionalAccessPolicyEx;
        public Microsoft.Online.SharePoint.TenantManagement.SPOConditionalAccessPolicyType ConditionalAccessPolicyEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingPermissionType DefaultLinkPermission => DefaultLinkPermissionEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingPermissionType DefaultLinkPermissionEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingLinkType DefaultSharingLinkType => DefaultSharingLinkTypeEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingLinkType DefaultSharingLinkTypeEx { get; set; }

        public override System.Boolean DisableReportProblemDialog => DisableReportProblemDialogEx;
        public System.Boolean DisableReportProblemDialogEx { get; set; }

        public override System.Boolean DisallowInfectedFileDownload => DisallowInfectedFileDownloadEx;
        public System.Boolean DisallowInfectedFileDownloadEx { get; set; }

        public override System.Boolean DisplayNamesOfFileViewers => DisplayNamesOfFileViewersEx;
        public System.Boolean DisplayNamesOfFileViewersEx { get; set; }

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

        public override System.Boolean HideDefaultThemes => HideDefaultThemesEx;
        public System.Boolean HideDefaultThemesEx { get; set; }

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

        public override System.String NoAccessRedirectUrl => NoAccessRedirectUrlEx;
        public System.String NoAccessRedirectUrlEx { get; set; }

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

        public override System.Int64 OneDriveStorageQuota => OneDriveStorageQuotaEx;
        public System.Int64 OneDriveStorageQuotaEx { get; set; }

        public override System.Boolean OptOutOfGrooveBlock => OptOutOfGrooveBlockEx;
        public System.Boolean OptOutOfGrooveBlockEx { get; set; }

        public override System.Boolean OptOutOfGrooveSoftBlock => OptOutOfGrooveSoftBlockEx;
        public System.Boolean OptOutOfGrooveSoftBlockEx { get; set; }

        public override System.Int32 OrphanedPersonalSitesRetentionPeriod => OrphanedPersonalSitesRetentionPeriodEx;
        public System.Int32 OrphanedPersonalSitesRetentionPeriodEx { get; set; }

        public override System.Boolean OwnerAnonymousNotification => OwnerAnonymousNotificationEx;
        public System.Boolean OwnerAnonymousNotificationEx { get; set; }

        public override System.Boolean PermissiveBrowserFileHandlingOverride => PermissiveBrowserFileHandlingOverrideEx;
        public System.Boolean PermissiveBrowserFileHandlingOverrideEx { get; set; }

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

        public override System.Double ResourceQuota => ResourceQuotaEx;
        public System.Double ResourceQuotaEx { get; set; }

        public override System.Double ResourceQuotaAllocated => ResourceQuotaAllocatedEx;
        public System.Double ResourceQuotaAllocatedEx { get; set; }

        public override System.String RootSiteUrl => RootSiteUrlEx;
        public System.String RootSiteUrlEx { get; set; }

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

        public override Microsoft.Online.SharePoint.TenantManagement.SpecialCharactersState SpecialCharactersStateInFileFolderNames => SpecialCharactersStateInFileFolderNamesEx;
        public Microsoft.Online.SharePoint.TenantManagement.SpecialCharactersState SpecialCharactersStateInFileFolderNamesEx { get; set; }

        public override System.String StartASiteFormUrl => StartASiteFormUrlEx;
        public System.String StartASiteFormUrlEx { get; set; }

        public override System.Int64 StorageQuota => StorageQuotaEx;
        public System.Int64 StorageQuotaEx { get; set; }

        public override System.Int64 StorageQuotaAllocated => StorageQuotaAllocatedEx;
        public System.Int64 StorageQuotaAllocatedEx { get; set; }

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

        public override void CreateGroupForSite(System.String @siteUrl, System.String @displayName, System.String @alias, System.Boolean @isPublic, Microsoft.Online.SharePoint.TenantManagement.GroupCreationParams @optionalParams)
        {
        }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.SPOTenantInstance> GetTenantInstances()
        {
            return GetTenantInstancesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.SPOTenantInstance> GetTenantInstancesEx { get; set;}

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

        public override void SetTenantCdnPolicy(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnType @cdnType, Microsoft.Online.SharePoint.TenantAdministration.SPOTenantCdnPolicyType @policyType, System.String @policyValue)
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

        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript CreateSiteScript(Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScriptCreationInfo @info)
        {
            return CreateSiteScriptEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript CreateSiteScriptEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript> GetSiteScripts()
        {
            return GetSiteScriptsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript> GetSiteScriptsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript UpdateSiteScript(Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript @updateInfo)
        {
            return UpdateSiteScriptEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScript UpdateSiteScriptEx { get; set;}

        public override void DeleteSiteScript(System.Guid @id)
        {
        }

        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign CreateSiteDesign(Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesignCreationInfo @info)
        {
            return CreateSiteDesignEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign CreateSiteDesignEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign> GetSiteDesigns()
        {
            return GetSiteDesignsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign> GetSiteDesignsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign UpdateSiteDesign(Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign @updateInfo)
        {
            return UpdateSiteDesignEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesign UpdateSiteDesignEx { get; set;}

        public override void DeleteSiteDesign(System.Guid @id)
        {
        }

        public override void GrantSiteDesignRights(System.Guid @id, System.String[] @principalNames, Microsoft.Online.SharePoint.TenantAdministration.TenantSiteDesignPrincipalRights @grantedRights)
        {
        }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScriptActionResult> ApplySiteDesign(System.String @webUrl, System.Guid @siteDesignId)
        {
            return ApplySiteDesignEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScriptActionResult> ApplySiteDesignEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GetHubSitePropertiesByUrl(System.String @siteUrl)
        {
            return GetHubSitePropertiesByUrlEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GetHubSitePropertiesByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GetHubSitePropertiesById(System.Guid @hubSiteId)
        {
            return GetHubSitePropertiesByIdEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GetHubSitePropertiesByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties> GetHubSitesProperties()
        {
            return GetHubSitesPropertiesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties> GetHubSitesPropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties RegisterHubSite(System.String @siteUrl)
        {
            return RegisterHubSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties RegisterHubSiteEx { get; set;}

        public override void UnregisterHubSite(System.String @siteUrl)
        {
        }

        public override void ConnectSiteToHubSite(System.String @siteUrl, System.String @hubSiteUrl)
        {
        }

        public override void DisconnectSiteFromHubSite(System.String @siteUrl)
        {
        }

        public override Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GrantHubSiteRights(System.String @hubSiteUrl, System.String[] @principals, Microsoft.Online.SharePoint.TenantAdministration.SPOHubSiteUserRights @grantedRights)
        {
            return GrantHubSiteRightsEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties GrantHubSiteRightsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties RevokeHubSiteRights(System.String @hubSiteUrl, System.String[] @principals)
        {
            return RevokeHubSiteRightsEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties RevokeHubSiteRightsEx { get; set;}

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

        public override Microsoft.SharePoint.Client.ClientResult<System.String> SetWebTheme(System.String @themeName, System.String @webUrl)
        {
            return SetWebThemeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> SetWebThemeEx { get; set;}

        public override Microsoft.SharePoint.Client.Site GetSiteByUrl(System.String @url)
        {
            return GetSiteByUrlEx;
        }
        public Microsoft.SharePoint.Client.Site GetSiteByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SiteProperties GetSitePropertiesByUrl(System.String @url, System.Boolean @includeDetail)
        {
            return GetSitePropertiesByUrlEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SiteProperties GetSitePropertiesByUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetRootSiteUrl()
        {
            return GetRootSiteUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetRootSiteUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSiteProperties(System.Int32 @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePoint(System.String @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesFromSharePointEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePointEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesByFilter(System.String @filter, System.Int32 @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesByFilterEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesByFilterEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePointByFilter(System.String @filter, System.String @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesFromSharePointByFilterEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePointByFilterEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePointByFilters(Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerableFilter @speFilter)
        {
            return GetSitePropertiesFromSharePointByFiltersEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesFromSharePointByFiltersEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.UserMigrationPropertiesEnumerable GetUserMigrationPropertiesByFilter(Microsoft.Online.SharePoint.TenantAdministration.UserMigrationPropertiesEnumerableFilter @userMigrationPropertiesEnumerableFilter)
        {
            return GetUserMigrationPropertiesByFilterEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.UserMigrationPropertiesEnumerable GetUserMigrationPropertiesByFilterEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.UserMigrationProperties GetUserMigrationProperties(System.String @userPrincipalName)
        {
            return GetUserMigrationPropertiesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.UserMigrationProperties GetUserMigrationPropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation CreateSite(Microsoft.Online.SharePoint.TenantAdministration.SiteCreationProperties @siteCreationProperties)
        {
            return CreateSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation CreateSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantAllWebTemplates()
        {
            return GetSPOTenantAllWebTemplatesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantAllWebTemplatesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantWebTemplates(System.UInt32 @localeId, System.Int32 @compatibilityLevel)
        {
            return GetSPOTenantWebTemplatesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantWebTemplatesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveSite(System.String @siteUrl)
        {
            return RemoveSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.DeletedSiteProperties GetDeletedSitePropertiesByUrl(System.String @siteUrl)
        {
            return GetDeletedSitePropertiesByUrlEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.DeletedSiteProperties GetDeletedSitePropertiesByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSiteProperties(System.Int32 @startIndex)
        {
            return GetDeletedSitePropertiesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSitePropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSitePropertiesFromSharePoint(System.String @startIndex)
        {
            return GetDeletedSitePropertiesFromSharePointEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSitePropertiesFromSharePointEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedPersonalSitePropertiesAllVersions(System.String @url)
        {
            return GetDeletedPersonalSitePropertiesAllVersionsEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedPersonalSitePropertiesAllVersionsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetAllDeletedPersonalSitesPropertiesAllVersions(System.Int32 @startIndex)
        {
            return GetAllDeletedPersonalSitesPropertiesAllVersionsEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetAllDeletedPersonalSitesPropertiesAllVersionsEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RequestPersonalSites(System.String[] @userIds)
        {
            return RequestPersonalSitesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RequestPersonalSitesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSite(System.String @siteUrl)
        {
            return RemoveDeletedSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSitePreferId(System.String @siteUrl, System.Guid @siteId)
        {
            return RemoveDeletedSitePreferIdEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSitePreferIdEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSite(System.String @siteUrl)
        {
            return RestoreDeletedSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSitePreferId(System.String @siteUrl, System.Guid @siteId)
        {
            return RestoreDeletedSitePreferIdEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSitePreferIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> EncodeClaim(System.String @identifier)
        {
            return EncodeClaimEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> EncodeClaimEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> DecodeClaim(System.String @identifier)
        {
            return DecodeClaimEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> DecodeClaimEx { get; set;}

        public override System.Collections.Generic.IList<System.String> EncodeClaims(System.Collections.Generic.IList<System.String> @identifiers)
        {
            return EncodeClaimsEx;
        }
        public System.Collections.Generic.IList<System.String> EncodeClaimsEx { get; set;}

        public override System.Collections.Generic.IList<System.String> DecodeClaims(System.Collections.Generic.IList<System.String> @claims)
        {
            return DecodeClaimsEx;
        }
        public System.Collections.Generic.IList<System.String> DecodeClaimsEx { get; set;}

        public override Microsoft.SharePoint.Client.User SetSiteAdmin(System.String @siteUrl, System.String @loginName, System.Boolean @isSiteAdmin)
        {
            return SetSiteAdminEx;
        }
        public Microsoft.SharePoint.Client.User SetSiteAdminEx { get; set;}

        public override Microsoft.SharePoint.Client.User UpdateUserTypeFromAzureAD(System.String @siteUrl, System.String @loginName)
        {
            return UpdateUserTypeFromAzureADEx;
        }
        public Microsoft.SharePoint.Client.User UpdateUserTypeFromAzureADEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.User> UpdateUserTypesFromAzureADForSite(System.String @siteUrl)
        {
            return UpdateUserTypesFromAzureADForSiteEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.User> UpdateUserTypesFromAzureADForSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable UpdateUserTypeFromAzureADForAllSites(System.String @loginName)
        {
            return UpdateUserTypeFromAzureADForAllSitesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable UpdateUserTypeFromAzureADForAllSitesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppErrorEntry> GetAppErrors(System.Guid @productId, System.DateTime @timeStart, System.DateTime @timeEnd)
        {
            return GetAppErrorsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppErrorEntry> GetAppErrorsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByProductId(System.Guid @productId)
        {
            return GetAppInfoByProductIdEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByProductIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByName(System.String @name)
        {
            return GetAppInfoByNameEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByNameEx { get; set;}

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

    }
}

