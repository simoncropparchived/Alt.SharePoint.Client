
namespace Microsoft.SharePoint.Client
{
    public class ClientArrayResult`1Mock : ClientArrayResult`1
    {


        public override T[] Value => ValueEx;
        public T[] ValueEx { get; set; }

    }
}

