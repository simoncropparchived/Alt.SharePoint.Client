
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectCollection`1Mock : ClientObjectCollection`1
    {


        public override T Item => ItemEx;
        public T ItemEx { get; set; }

        public override System.Type ElementType => ElementTypeEx;
        public System.Type ElementTypeEx { get; set; }

        public override System.Linq.Expressions.Expression Expression => ExpressionEx;
        public System.Linq.Expressions.Expression ExpressionEx { get; set; }

        public override System.Linq.IQueryProvider Provider => ProviderEx;
        public System.Linq.IQueryProvider ProviderEx { get; set; }

    }
}

