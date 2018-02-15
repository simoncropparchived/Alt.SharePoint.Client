
namespace Microsoft.SharePoint.Client
{
    public class ClientValueObjectCollection`1Mock : ClientValueObjectCollection`1
    {


        public override System.Int32 Count => CountEx;
        public System.Int32 CountEx { get; set; }

        public override T Item => ItemEx;
        public T ItemEx { get; set; }

    }
}

