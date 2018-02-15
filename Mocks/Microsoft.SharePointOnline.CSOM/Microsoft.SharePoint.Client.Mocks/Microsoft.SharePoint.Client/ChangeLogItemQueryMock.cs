
namespace Microsoft.SharePoint.Client
{
    public class ChangeLogItemQueryMock
    {


        public override System.String ChangeToken => ChangeTokenEx;
        public System.String ChangeTokenEx { get; set; }

        public override System.String Contains => ContainsEx;
        public System.String ContainsEx { get; set; }

        public override System.String Query => QueryEx;
        public System.String QueryEx { get; set; }

        public override System.String QueryOptions => QueryOptionsEx;
        public System.String QueryOptionsEx { get; set; }

        public override System.String RowLimit => RowLimitEx;
        public System.String RowLimitEx { get; set; }

        public override System.String ViewFields => ViewFieldsEx;
        public System.String ViewFieldsEx { get; set; }

        public override System.String ViewName => ViewNameEx;
        public System.String ViewNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

