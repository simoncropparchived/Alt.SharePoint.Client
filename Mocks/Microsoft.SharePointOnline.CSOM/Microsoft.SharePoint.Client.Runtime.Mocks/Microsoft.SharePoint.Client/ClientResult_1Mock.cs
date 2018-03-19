
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientResultMock<T> : ClientResult<T>
    {


        public override Microsoft.SharePoint.Client.ClientResult.T Value => ValueEx;
        public Microsoft.SharePoint.Client.ClientResult.T ValueEx { get; set; }

    }
}

