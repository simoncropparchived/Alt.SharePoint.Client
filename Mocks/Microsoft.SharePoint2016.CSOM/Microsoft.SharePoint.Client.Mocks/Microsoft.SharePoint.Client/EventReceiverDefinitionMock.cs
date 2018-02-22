
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class EventReceiverDefinitionMock : EventReceiverDefinition
    {


        public override System.String ReceiverAssembly => ReceiverAssemblyEx;
        public System.String ReceiverAssemblyEx { get; set; }

        public override System.String ReceiverClass => ReceiverClassEx;
        public System.String ReceiverClassEx { get; set; }

        public override System.Guid ReceiverId => ReceiverIdEx;
        public System.Guid ReceiverIdEx { get; set; }

        public override System.String ReceiverName => ReceiverNameEx;
        public System.String ReceiverNameEx { get; set; }

        public override System.Int32 SequenceNumber => SequenceNumberEx;
        public System.Int32 SequenceNumberEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceiverSynchronization Synchronization => SynchronizationEx;
        public Microsoft.SharePoint.Client.EventReceiverSynchronization SynchronizationEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceiverType EventType => EventTypeEx;
        public Microsoft.SharePoint.Client.EventReceiverType EventTypeEx { get; set; }

        public override System.String ReceiverUrl => ReceiverUrlEx;
        public System.String ReceiverUrlEx { get; set; }

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

