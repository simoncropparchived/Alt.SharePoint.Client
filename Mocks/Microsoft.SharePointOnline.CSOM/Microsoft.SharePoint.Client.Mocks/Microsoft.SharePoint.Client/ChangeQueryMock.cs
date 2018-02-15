
namespace Microsoft.SharePoint.Client
{
    public class ChangeQueryMock : ChangeQuery
    {


        public override System.Boolean Activity => ActivityEx;
        public System.Boolean ActivityEx { get; set; }

        public override System.Boolean Add => AddEx;
        public System.Boolean AddEx { get; set; }

        public override System.Boolean Alert => AlertEx;
        public System.Boolean AlertEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeToken ChangeTokenEnd => ChangeTokenEndEx;
        public Microsoft.SharePoint.Client.ChangeToken ChangeTokenEndEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeToken ChangeTokenStart => ChangeTokenStartEx;
        public Microsoft.SharePoint.Client.ChangeToken ChangeTokenStartEx { get; set; }

        public override System.Boolean ContentType => ContentTypeEx;
        public System.Boolean ContentTypeEx { get; set; }

        public override System.Boolean DeleteObject => DeleteObjectEx;
        public System.Boolean DeleteObjectEx { get; set; }

        public override System.Int64 FetchLimit => FetchLimitEx;
        public System.Int64 FetchLimitEx { get; set; }

        public override System.Boolean Field => FieldEx;
        public System.Boolean FieldEx { get; set; }

        public override System.Boolean File => FileEx;
        public System.Boolean FileEx { get; set; }

        public override System.Boolean Folder => FolderEx;
        public System.Boolean FolderEx { get; set; }

        public override System.Boolean Group => GroupEx;
        public System.Boolean GroupEx { get; set; }

        public override System.Boolean GroupMembershipAdd => GroupMembershipAddEx;
        public System.Boolean GroupMembershipAddEx { get; set; }

        public override System.Boolean GroupMembershipDelete => GroupMembershipDeleteEx;
        public System.Boolean GroupMembershipDeleteEx { get; set; }

        public override System.Boolean Item => ItemEx;
        public System.Boolean ItemEx { get; set; }

        public override System.Boolean LatestFirst => LatestFirstEx;
        public System.Boolean LatestFirstEx { get; set; }

        public override System.Boolean List => ListEx;
        public System.Boolean ListEx { get; set; }

        public override System.Boolean Move => MoveEx;
        public System.Boolean MoveEx { get; set; }

        public override System.Boolean Navigation => NavigationEx;
        public System.Boolean NavigationEx { get; set; }

        public override System.Boolean RecursiveAll => RecursiveAllEx;
        public System.Boolean RecursiveAllEx { get; set; }

        public override System.Boolean Rename => RenameEx;
        public System.Boolean RenameEx { get; set; }

        public override System.Boolean RequireSecurityTrim => RequireSecurityTrimEx;
        public System.Boolean RequireSecurityTrimEx { get; set; }

        public override System.Boolean Restore => RestoreEx;
        public System.Boolean RestoreEx { get; set; }

        public override System.Boolean RoleAssignmentAdd => RoleAssignmentAddEx;
        public System.Boolean RoleAssignmentAddEx { get; set; }

        public override System.Boolean RoleAssignmentDelete => RoleAssignmentDeleteEx;
        public System.Boolean RoleAssignmentDeleteEx { get; set; }

        public override System.Boolean RoleDefinitionAdd => RoleDefinitionAddEx;
        public System.Boolean RoleDefinitionAddEx { get; set; }

        public override System.Boolean RoleDefinitionDelete => RoleDefinitionDeleteEx;
        public System.Boolean RoleDefinitionDeleteEx { get; set; }

        public override System.Boolean RoleDefinitionUpdate => RoleDefinitionUpdateEx;
        public System.Boolean RoleDefinitionUpdateEx { get; set; }

        public override System.Boolean SecurityPolicy => SecurityPolicyEx;
        public System.Boolean SecurityPolicyEx { get; set; }

        public override System.Boolean Site => SiteEx;
        public System.Boolean SiteEx { get; set; }

        public override System.Boolean SystemUpdate => SystemUpdateEx;
        public System.Boolean SystemUpdateEx { get; set; }

        public override System.Boolean Update => UpdateEx;
        public System.Boolean UpdateEx { get; set; }

        public override System.Boolean User => UserEx;
        public System.Boolean UserEx { get; set; }

        public override System.Boolean View => ViewEx;
        public System.Boolean ViewEx { get; set; }

        public override System.Boolean Web => WebEx;
        public System.Boolean WebEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

