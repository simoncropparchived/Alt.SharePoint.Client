
namespace Microsoft.SharePoint.Client
{
    public class SharePointSharingSettingsMock : SharePointSharingSettings
    {


        public override System.String AddToGroupModeName => AddToGroupModeNameEx;
        public System.String AddToGroupModeNameEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> GroupNameLines => GroupNameLinesEx;
        public System.Collections.Generic.IEnumerable<System.String> GroupNameLinesEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> GroupRoleDefinitionNamesLines => GroupRoleDefinitionNamesLinesEx;
        public System.Collections.Generic.IEnumerable<System.String> GroupRoleDefinitionNamesLinesEx { get; set; }

        public override System.Boolean IsMobileView => IsMobileViewEx;
        public System.Boolean IsMobileViewEx { get; set; }

        public override System.Boolean PanelGivePermissionsVisible => PanelGivePermissionsVisibleEx;
        public System.Boolean PanelGivePermissionsVisibleEx { get; set; }

        public override System.Boolean PanelShowHideMoreOptionsVisible => PanelShowHideMoreOptionsVisibleEx;
        public System.Boolean PanelShowHideMoreOptionsVisibleEx { get; set; }

        public override System.Boolean PanelSimplifiedRoleSelectorVisible => PanelSimplifiedRoleSelectorVisibleEx;
        public System.Boolean PanelSimplifiedRoleSelectorVisibleEx { get; set; }

        public override Microsoft.SharePoint.Client.PickerSettings PickerProperties => PickerPropertiesEx;
        public Microsoft.SharePoint.Client.PickerSettings PickerPropertiesEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> RequiredScriptFileLinks => RequiredScriptFileLinksEx;
        public System.Collections.Generic.IEnumerable<System.String> RequiredScriptFileLinksEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> RoleDefinitionNameLines => RoleDefinitionNameLinesEx;
        public System.Collections.Generic.IEnumerable<System.String> RoleDefinitionNameLinesEx { get; set; }

        public override System.String SelectedGroup => SelectedGroupEx;
        public System.String SelectedGroupEx { get; set; }

        public override System.Boolean SharedWithEnabled => SharedWithEnabledEx;
        public System.Boolean SharedWithEnabledEx { get; set; }

        public override System.String SharingCssLink => SharingCssLinkEx;
        public System.String SharingCssLinkEx { get; set; }

        public override System.Boolean TabbedDialogEnabled => TabbedDialogEnabledEx;
        public System.Boolean TabbedDialogEnabledEx { get; set; }

        public override System.Int32 TabToShow => TabToShowEx;
        public System.Int32 TabToShowEx { get; set; }

        public override System.String txtEmailSubjectText => txtEmailSubjectTextEx;
        public System.String txtEmailSubjectTextEx { get; set; }

        public override System.String UserDisplayUrl => UserDisplayUrlEx;
        public System.String UserDisplayUrlEx { get; set; }

    }
}

