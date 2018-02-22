
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class WorkflowDesignerFieldMock : WorkflowDesignerField
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override System.Boolean IsLookupField => IsLookupFieldEx;
        public System.Boolean IsLookupFieldEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupEntryCollection LookupEntries => LookupEntriesEx;
        public Microsoft.ProjectServer.Client.LookupEntryCollection LookupEntriesEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldType SPFieldType => SPFieldTypeEx;
        public Microsoft.SharePoint.Client.FieldType SPFieldTypeEx { get; set; }

    }
}

