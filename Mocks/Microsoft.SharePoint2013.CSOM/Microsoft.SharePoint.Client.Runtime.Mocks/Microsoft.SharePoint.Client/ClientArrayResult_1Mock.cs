
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientArrayResultMock<T> : ClientArrayResult<T>
    {


        public override T[] Value => ValueEx;
        public T[] ValueEx { get; set; }

    }
}

