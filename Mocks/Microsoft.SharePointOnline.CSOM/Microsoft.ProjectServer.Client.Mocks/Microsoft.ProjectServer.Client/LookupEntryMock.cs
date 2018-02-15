
namespace Microsoft.ProjectServer.Client
{
    public class LookupEntryMock
    {


        public override System.Guid AppAlternateId => AppAlternateIdEx;
        public System.Guid AppAlternateIdEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String FullValue => FullValueEx;
        public System.String FullValueEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.Decimal SortIndex => SortIndexEx;
        public System.Decimal SortIndexEx { get; set; }

    }
}

