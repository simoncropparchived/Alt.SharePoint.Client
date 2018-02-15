
namespace Microsoft.ProjectServer.Client
{
    public class DraftProjectResourceMock : DraftProjectResource
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object Item => ItemEx;
        public System.Object ItemEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftAssignmentCollection Assignments => AssignmentsEx;
        public Microsoft.ProjectServer.Client.DraftAssignmentCollection AssignmentsEx { get; set; }

        public override System.Boolean CanLevel => CanLevelEx;
        public System.Boolean CanLevelEx { get; set; }

        public override System.String Code => CodeEx;
        public System.String CodeEx { get; set; }

        public override Microsoft.ProjectServer.Client.AccrueAt CostAccrual => CostAccrualEx;
        public Microsoft.ProjectServer.Client.AccrueAt CostAccrualEx { get; set; }

        public override System.String CostCenter => CostCenterEx;
        public System.String CostCenterEx { get; set; }

        public override System.Double CostPerUse => CostPerUseEx;
        public System.Double CostPerUseEx { get; set; }

        public override Microsoft.SharePoint.Client.User DefaultAssignmentOwner => DefaultAssignmentOwnerEx;
        public Microsoft.SharePoint.Client.User DefaultAssignmentOwnerEx { get; set; }

        public override Microsoft.ProjectServer.Client.BookingType DefaultBookingType => DefaultBookingTypeEx;
        public Microsoft.ProjectServer.Client.BookingType DefaultBookingTypeEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.String Initials => InitialsEx;
        public System.String InitialsEx { get; set; }

        public override System.String MaterialLabel => MaterialLabelEx;
        public System.String MaterialLabelEx { get; set; }

        public override System.Double MaximumCapacity => MaximumCapacityEx;
        public System.Double MaximumCapacityEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Double OvertimeRate => OvertimeRateEx;
        public System.Double OvertimeRateEx { get; set; }

        public override Microsoft.ProjectServer.Client.OvertimeRateFormat OvertimeRateUnits => OvertimeRateUnitsEx;
        public Microsoft.ProjectServer.Client.OvertimeRateFormat OvertimeRateUnitsEx { get; set; }

        public override System.String Phonetics => PhoneticsEx;
        public System.String PhoneticsEx { get; set; }

        public override System.Double StandardRate => StandardRateEx;
        public System.Double StandardRateEx { get; set; }

        public override Microsoft.ProjectServer.Client.StandardRateFormat StandardRateUnits => StandardRateUnitsEx;
        public Microsoft.ProjectServer.Client.StandardRateFormat StandardRateUnitsEx { get; set; }

    }
}

