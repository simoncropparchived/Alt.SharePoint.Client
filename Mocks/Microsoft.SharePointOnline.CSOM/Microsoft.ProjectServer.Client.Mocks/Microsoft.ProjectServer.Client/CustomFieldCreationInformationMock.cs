
namespace Microsoft.ProjectServer.Client
{
    public class CustomFieldCreationInformationMock
    {


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

        public override Microsoft.ProjectServer.Client.LookupTable LookupTable => LookupTableEx;
        public Microsoft.ProjectServer.Client.LookupTable LookupTableEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

