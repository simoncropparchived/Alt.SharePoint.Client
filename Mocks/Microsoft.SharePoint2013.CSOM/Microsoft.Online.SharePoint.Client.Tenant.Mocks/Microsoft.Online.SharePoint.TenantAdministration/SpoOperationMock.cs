
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SpoOperationMock : SpoOperation
    {


        public override System.Boolean HasTimedout => HasTimedoutEx;
        public System.Boolean HasTimedoutEx { get; set; }

        public override System.Boolean IsComplete => IsCompleteEx;
        public System.Boolean IsCompleteEx { get; set; }

        public override System.Int32 PollingInterval => PollingIntervalEx;
        public System.Int32 PollingIntervalEx { get; set; }

    }
}

