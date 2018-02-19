
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteEventResultMock : SPRemoteEventResult
    {


        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteEventServiceStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteEventServiceStatus StatusEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String,System.Object> ChangedItemProperties => ChangedItemPropertiesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> ChangedItemPropertiesEx { get; set; }

    }
}

