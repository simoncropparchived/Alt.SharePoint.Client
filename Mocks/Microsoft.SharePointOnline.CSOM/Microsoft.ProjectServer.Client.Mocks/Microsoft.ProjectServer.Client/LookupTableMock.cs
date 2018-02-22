
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class LookupTableMock : LookupTable
    {


        public override System.Guid AppAlternateId => AppAlternateIdEx;
        public System.Guid AppAlternateIdEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupEntryCollection Entries => EntriesEx;
        public Microsoft.ProjectServer.Client.LookupEntryCollection EntriesEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldType FieldType => FieldTypeEx;
        public Microsoft.ProjectServer.Client.CustomFieldType FieldTypeEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupMask> Masks => MasksEx;
        public System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupMask> MasksEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupTableSortOrder SortOrder => SortOrderEx;
        public Microsoft.ProjectServer.Client.LookupTableSortOrder SortOrderEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

