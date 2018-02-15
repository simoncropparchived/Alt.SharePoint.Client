
namespace Microsoft.SharePoint.Client
{
    public class ClientResult`1Mock : ClientResult`1
    {


        public override T Value => ValueEx;
        public T ValueEx { get; set; }

    }
}

