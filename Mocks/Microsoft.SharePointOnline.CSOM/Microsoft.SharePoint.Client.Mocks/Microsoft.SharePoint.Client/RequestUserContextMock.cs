
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RequestUserContextMock : RequestUserContext
    {


        public override Microsoft.SharePoint.Client.User User => UserEx;
        public Microsoft.SharePoint.Client.User UserEx { get; set; }

    }
}

