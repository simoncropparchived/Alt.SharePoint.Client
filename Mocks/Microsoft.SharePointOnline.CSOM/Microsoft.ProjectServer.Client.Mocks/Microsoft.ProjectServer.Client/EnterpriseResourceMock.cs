
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceMock : EnterpriseResource
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override Microsoft.ProjectServer.Client.StatusAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.StatusAssignmentCollection AssignmentsEx { get; set; }

        public override Microsoft.ProjectServer.Client.Calendar BaseCalendar => BaseCalendarEx;
        public Microsoft.ProjectServer.Client.Calendar BaseCalendarEx { get; set; }

        public override System.Boolean CanLevel => CanLevelEx;
        public System.Boolean CanLevelEx { get; set; }

        public override System.String Code => CodeEx;
        public System.String CodeEx { get; set; }

        public override Microsoft.ProjectServer.Client.AccrueAt CostAccrual => CostAccrualEx;
        public Microsoft.ProjectServer.Client.AccrueAt CostAccrualEx { get; set; }

        public override System.String CostCenter => CostCenterEx;
        public System.String CostCenterEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResourceCostRateTableCollection CostRateTables => CostRateTablesEx;
        public Microsoft.ProjectServer.Client.EnterpriseResourceCostRateTableCollection CostRateTablesEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.User DefaultAssignmentOwner => DefaultAssignmentOwnerEx;
        public Microsoft.SharePoint.Client.User DefaultAssignmentOwnerEx { get; set; }

        public override Microsoft.ProjectServer.Client.BookingType DefaultBookingType => DefaultBookingTypeEx;
        public Microsoft.ProjectServer.Client.BookingType DefaultBookingTypeEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override Microsoft.ProjectServer.Client.ResourceEngagementCollection Engagements => EngagementsEx;
        public Microsoft.ProjectServer.Client.ResourceEngagementCollection EngagementsEx { get; set; }

        public override System.String ExternalId => ExternalIdEx;
        public System.String ExternalIdEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.DateTime HireDate => HireDateEx;
        public System.DateTime HireDateEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Initials => InitialsEx;
        public System.String InitialsEx { get; set; }

        public override System.Boolean IsActive => IsActiveEx;
        public System.Boolean IsActiveEx { get; set; }

        public override System.Boolean IsBudget => IsBudgetEx;
        public System.Boolean IsBudgetEx { get; set; }

        public override System.Boolean IsCheckedOut => IsCheckedOutEx;
        public System.Boolean IsCheckedOutEx { get; set; }

        public override System.Boolean IsGeneric => IsGenericEx;
        public System.Boolean IsGenericEx { get; set; }

        public override System.Boolean IsTeam => IsTeamEx;
        public System.Boolean IsTeamEx { get; set; }

        public override System.String MaterialLabel => MaterialLabelEx;
        public System.String MaterialLabelEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Phonetics => PhoneticsEx;
        public System.String PhoneticsEx { get; set; }

        public override System.Boolean RequiresEngagements => RequiresEngagementsEx;
        public System.Boolean RequiresEngagementsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CalendarExceptionCollection ResourceCalendarExceptions => ResourceCalendarExceptionsEx;
        public Microsoft.ProjectServer.Client.CalendarExceptionCollection ResourceCalendarExceptionsEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResourceType ResourceType => ResourceTypeEx;
        public Microsoft.ProjectServer.Client.EnterpriseResourceType ResourceTypeEx { get; set; }

        public override System.DateTime TerminationDate => TerminationDateEx;
        public System.DateTime TerminationDateEx { get; set; }

        public override Microsoft.SharePoint.Client.User TimesheetManager => TimesheetManagerEx;
        public Microsoft.SharePoint.Client.User TimesheetManagerEx { get; set; }

        public override Microsoft.SharePoint.Client.User User => UserEx;
        public Microsoft.SharePoint.Client.User UserEx { get; set; }

        public override void RefreshLoad()
        {
        }

        public override void DeleteObject()
        {
        }

        public override void ForceCheckIn()
        {
        }

    }
}

