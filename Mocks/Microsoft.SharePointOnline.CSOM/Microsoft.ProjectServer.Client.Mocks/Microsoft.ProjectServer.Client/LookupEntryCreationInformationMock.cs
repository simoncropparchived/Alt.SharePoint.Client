
namespace Microsoft.ProjectServer.Client
{
    public class LookupEntryCreationInformationMock
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Guid ParentId => ParentIdEx;
        public System.Guid ParentIdEx { get; set; }

        public override System.Decimal SortIndex => SortIndexEx;
        public System.Decimal SortIndexEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupEntryValue Value => ValueEx;
        public Microsoft.ProjectServer.Client.LookupEntryValue ValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

