
namespace Microsoft.ProjectServer.Client
{
    public class DraftProjectMock : DraftProject
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object Item => ItemEx;
        public System.Object ItemEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.DraftAssignmentCollection AssignmentsEx { get; set; }

        public override Microsoft.ProjectServer.Client.Calendar Calendar => CalendarEx;
        public Microsoft.ProjectServer.Client.Calendar CalendarEx { get; set; }

        public override System.String CurrencyCode => CurrencyCodeEx;
        public System.String CurrencyCodeEx { get; set; }

        public override System.Int32 CurrencyDigits => CurrencyDigitsEx;
        public System.Int32 CurrencyDigitsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CurrencySymbolPosition CurrencyPosition => CurrencyPositionEx;
        public Microsoft.ProjectServer.Client.CurrencySymbolPosition CurrencyPositionEx { get; set; }

        public override System.String CurrencySymbol => CurrencySymbolEx;
        public System.String CurrencySymbolEx { get; set; }

        public override System.DateTime CurrentDate => CurrentDateEx;
        public System.DateTime CurrentDateEx { get; set; }

        public override System.Int16 DaysPerMonth => DaysPerMonthEx;
        public System.Int16 DaysPerMonthEx { get; set; }

        public override System.Boolean DefaultEffortDriven => DefaultEffortDrivenEx;
        public System.Boolean DefaultEffortDrivenEx { get; set; }

        public override System.Boolean DefaultEstimatedDuration => DefaultEstimatedDurationEx;
        public System.Boolean DefaultEstimatedDurationEx { get; set; }

        public override Microsoft.ProjectServer.Client.FixedCostAccrual DefaultFixedCostAccrual => DefaultFixedCostAccrualEx;
        public Microsoft.ProjectServer.Client.FixedCostAccrual DefaultFixedCostAccrualEx { get; set; }

        public override System.Double DefaultOvertimeRate => DefaultOvertimeRateEx;
        public System.Double DefaultOvertimeRateEx { get; set; }

        public override System.Double DefaultStandardRate => DefaultStandardRateEx;
        public System.Double DefaultStandardRateEx { get; set; }

        public override Microsoft.ProjectServer.Client.TaskType DefaultTaskType => DefaultTaskTypeEx;
        public Microsoft.ProjectServer.Client.TaskType DefaultTaskTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.WorkFormat DefaultWorkFormat => DefaultWorkFormatEx;
        public Microsoft.ProjectServer.Client.WorkFormat DefaultWorkFormatEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.DateTime FinishDate => FinishDateEx;
        public System.DateTime FinishDateEx { get; set; }

        public override System.Int16 FiscalYearStartMonth => FiscalYearStartMonthEx;
        public System.Int16 FiscalYearStartMonthEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftProject IncludeCustomFields => IncludeCustomFieldsEx;
        public Microsoft.ProjectServer.Client.DraftProject IncludeCustomFieldsEx { get; set; }

        public override System.Int32 MinutesPerDay => MinutesPerDayEx;
        public System.Int32 MinutesPerDayEx { get; set; }

        public override System.Int32 MinutesPerWeek => MinutesPerWeekEx;
        public System.Int32 MinutesPerWeekEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean NewTasksAreManual => NewTasksAreManualEx;
        public System.Boolean NewTasksAreManualEx { get; set; }

        public override System.Boolean NumberFiscalYearFromStart => NumberFiscalYearFromStartEx;
        public System.Boolean NumberFiscalYearFromStartEx { get; set; }

        public override Microsoft.SharePoint.Client.User Owner => OwnerEx;
        public Microsoft.SharePoint.Client.User OwnerEx { get; set; }

        public override System.String ProjectIdentifier => ProjectIdentifierEx;
        public System.String ProjectIdentifierEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftProjectResourceCollection ProjectResources => ProjectResourcesEx;
        public Microsoft.ProjectServer.Client.DraftProjectResourceCollection ProjectResourcesEx { get; set; }

        public override System.Boolean ProtectedActualsSynch => ProtectedActualsSynchEx;
        public System.Boolean ProtectedActualsSynchEx { get; set; }

        public override System.Boolean ShowEstimatedDurations => ShowEstimatedDurationsEx;
        public System.Boolean ShowEstimatedDurationsEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

        public override System.DateTime StatusDate => StatusDateEx;
        public System.DateTime StatusDateEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftTaskLinkCollection TaskLinks => TaskLinksEx;
        public Microsoft.ProjectServer.Client.DraftTaskLinkCollection TaskLinksEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftTaskCollection Tasks => TasksEx;
        public Microsoft.ProjectServer.Client.DraftTaskCollection TasksEx { get; set; }

        public override Microsoft.ProjectServer.Client.TrackingMode TrackingMode => TrackingModeEx;
        public Microsoft.ProjectServer.Client.TrackingMode TrackingModeEx { get; set; }

        public override System.DateTime UtilizationDate => UtilizationDateEx;
        public System.DateTime UtilizationDateEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectUtilizationType UtilizationType => UtilizationTypeEx;
        public Microsoft.ProjectServer.Client.ProjectUtilizationType UtilizationTypeEx { get; set; }

        public override System.Int16 WeekStartDay => WeekStartDayEx;
        public System.Int16 WeekStartDayEx { get; set; }

        public override System.Decimal WinprojVersion => WinprojVersionEx;
        public System.Decimal WinprojVersionEx { get; set; }

    }
}

