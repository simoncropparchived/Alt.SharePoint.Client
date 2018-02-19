
namespace Microsoft.ProjectServer.Client
{
    public class LookupTableCreationInformationMock : LookupTableCreationInformation
    {


        public override System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupEntryCreationInformation> Entries => EntriesEx;
        public System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupEntryCreationInformation> EntriesEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupMask> Masks => MasksEx;
        public System.Collections.Generic.IEnumerable<Microsoft.ProjectServer.Client.LookupMask> MasksEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupTableSortOrder SortOrder => SortOrderEx;
        public Microsoft.ProjectServer.Client.LookupTableSortOrder SortOrderEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

