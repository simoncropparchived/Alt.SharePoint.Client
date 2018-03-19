
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Application
{
    public class ModeCompletedEventArgsMock : ModeCompletedEventArgs
    {


        public override Microsoft.SharePoint.Client.Application.AuthenticationMode Result => ResultEx;
        public Microsoft.SharePoint.Client.Application.AuthenticationMode ResultEx { get; set; }

    }
}

