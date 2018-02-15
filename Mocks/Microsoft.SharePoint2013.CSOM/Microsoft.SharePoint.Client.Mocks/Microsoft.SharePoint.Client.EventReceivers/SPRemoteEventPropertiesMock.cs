
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteEventPropertiesMock
    {


        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteEventType EventType => EventTypeEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteEventType EventTypeEx { get; set; }

        public override System.Guid CorrelationId => CorrelationIdEx;
        public System.Guid CorrelationIdEx { get; set; }

        public override System.String ContextToken => ContextTokenEx;
        public System.String ContextTokenEx { get; set; }

        public override System.Int32 CultureLCID => CultureLCIDEx;
        public System.Int32 CultureLCIDEx { get; set; }

        public override System.Int32 UICultureLCID => UICultureLCIDEx;
        public System.Int32 UICultureLCIDEx { get; set; }

        public override System.String ErrorCode => ErrorCodeEx;
        public System.String ErrorCodeEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteItemEventProperties ItemEventProperties => ItemEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteItemEventProperties ItemEventPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteListEventProperties ListEventProperties => ListEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteListEventProperties ListEventPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteWebEventProperties WebEventProperties => WebEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteWebEventProperties WebEventPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteSecurityEventProperties SecurityEventProperties => SecurityEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteSecurityEventProperties SecurityEventPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteAppEventProperties AppEventProperties => AppEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteAppEventProperties AppEventPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceivers.SPRemoteEntityInstanceEventProperties EntityInstanceEventProperties => EntityInstanceEventPropertiesEx;
        public Microsoft.SharePoint.Client.EventReceivers.SPRemoteEntityInstanceEventProperties EntityInstanceEventPropertiesEx { get; set; }

    }
}

