
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class EventReceiverDefinitionCollectionMock : EventReceiverDefinitionCollection
    {


        public override Microsoft.SharePoint.Client.EventReceiverDefinition GetById(System.Guid @eventReceiverId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.EventReceiverDefinition GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.EventReceiverDefinition Add(Microsoft.SharePoint.Client.EventReceiverDefinitionCreationInformation @eventReceiverCreationInformation)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.EventReceiverDefinition AddEx { get; set;}

    }
}

