
namespace Microsoft.ProjectServer.Client
{
    public class CustomFieldMock
    {


        public override System.Guid AppAlternateId => AppAlternateIdEx;
        public System.Guid AppAlternateIdEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.ProjectServer.Client.EntityType EntityType => EntityTypeEx;
        public Microsoft.ProjectServer.Client.EntityType EntityTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldType FieldType => FieldTypeEx;
        public Microsoft.ProjectServer.Client.CustomFieldType FieldTypeEx { get; set; }

        public override System.String Formula => FormulaEx;
        public System.String FormulaEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.Boolean IsEditableInVisibility => IsEditableInVisibilityEx;
        public System.Boolean IsEditableInVisibilityEx { get; set; }

        public override System.Boolean IsMultilineText => IsMultilineTextEx;
        public System.Boolean IsMultilineTextEx { get; set; }

        public override System.Boolean IsRequired => IsRequiredEx;
        public System.Boolean IsRequiredEx { get; set; }

        public override System.Boolean IsWorkflowControlled => IsWorkflowControlledEx;
        public System.Boolean IsWorkflowControlledEx { get; set; }

        public override System.Boolean LookupAllowMultiSelect => LookupAllowMultiSelectEx;
        public System.Boolean LookupAllowMultiSelectEx { get; set; }

        public override System.Guid LookupDefaultValue => LookupDefaultValueEx;
        public System.Guid LookupDefaultValueEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupEntryCollection LookupEntries => LookupEntriesEx;
        public Microsoft.ProjectServer.Client.LookupEntryCollection LookupEntriesEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupTable LookupTable => LookupTableEx;
        public Microsoft.ProjectServer.Client.LookupTable LookupTableEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean RollsDownToAssignments => RollsDownToAssignmentsEx;
        public System.Boolean RollsDownToAssignmentsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldRollupType RollupType => RollupTypeEx;
        public Microsoft.ProjectServer.Client.CustomFieldRollupType RollupTypeEx { get; set; }

    }
}

