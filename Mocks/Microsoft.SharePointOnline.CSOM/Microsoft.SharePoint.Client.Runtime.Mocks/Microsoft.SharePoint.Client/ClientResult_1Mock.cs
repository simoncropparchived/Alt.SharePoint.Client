
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientResultMock<T> : ClientResult<T>
    {


        public override T Value => ValueEx;
        public T ValueEx { get; set; }

    }
}

