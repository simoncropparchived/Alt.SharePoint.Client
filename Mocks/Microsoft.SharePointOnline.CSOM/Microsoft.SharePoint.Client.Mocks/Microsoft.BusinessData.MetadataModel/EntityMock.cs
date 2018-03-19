
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityMock : Entity
    {


        public override System.Int64 EstimatedInstanceCount => EstimatedInstanceCountEx;
        public System.Int64 EstimatedInstanceCountEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Namespace => NamespaceEx;
        public System.String NamespaceEx { get; set; }

        public override Microsoft.BusinessData.MetadataModel.Collections.EntityIdentifierCollection GetIdentifiers()
        {
            return GetIdentifiersEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.EntityIdentifierCollection GetIdentifiersEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetIdentifierCount()
        {
            return GetIdentifierCountEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetIdentifierCountEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.LobSystem GetLobSystem()
        {
            return GetLobSystemEx;
        }
        public Microsoft.BusinessData.MetadataModel.LobSystem GetLobSystemEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetCreatorView(System.String @methodInstanceName)
        {
            return GetCreatorViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetCreatorViewEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetUpdaterView(System.String @updaterName)
        {
            return GetUpdaterViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetUpdaterViewEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetFinderView(System.String @methodInstanceName)
        {
            return GetFinderViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetFinderViewEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetSpecificFinderView(System.String @specificFinderName)
        {
            return GetSpecificFinderViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetSpecificFinderViewEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetDefaultSpecificFinderView()
        {
            return GetDefaultSpecificFinderViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetDefaultSpecificFinderViewEx { get; set;}

        public override Microsoft.BusinessData.Runtime.EntityInstance FindSpecificDefault(Microsoft.BusinessData.Runtime.EntityIdentity @identity, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindSpecificDefaultEx;
        }
        public Microsoft.BusinessData.Runtime.EntityInstance FindSpecificDefaultEx { get; set;}

        public override Microsoft.BusinessData.Runtime.EntityInstance FindSpecific(Microsoft.BusinessData.Runtime.EntityIdentity @identity, System.String @specificFinderName, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindSpecificEx;
        }
        public Microsoft.BusinessData.Runtime.EntityInstance FindSpecificEx { get; set;}

        public override Microsoft.BusinessData.Runtime.EntityInstance FindSpecificDefaultByBdcId(System.String @bdcIdentity, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindSpecificDefaultByBdcIdEx;
        }
        public Microsoft.BusinessData.Runtime.EntityInstance FindSpecificDefaultByBdcIdEx { get; set;}

        public override Microsoft.BusinessData.Runtime.EntityInstance FindSpecificByBdcId(System.String @bdcIdentity, System.String @specificFinderName, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindSpecificByBdcIdEx;
        }
        public Microsoft.BusinessData.Runtime.EntityInstance FindSpecificByBdcIdEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.Collections.EntityInstanceCollection FindFiltered(Microsoft.BusinessData.MetadataModel.Collections.FilterCollection @filterList, System.String @nameOfFinder, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindFilteredEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.EntityInstanceCollection FindFilteredEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.Collections.EntityInstanceCollection FindAssociated(Microsoft.BusinessData.Runtime.EntityInstance @entityInstance, System.String @associationName, Microsoft.BusinessData.MetadataModel.Collections.FilterCollection @filterList, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return FindAssociatedEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.EntityInstanceCollection FindAssociatedEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.Collections.FilterCollection GetFilters(System.String @methodInstanceName)
        {
            return GetFiltersEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.FilterCollection GetFiltersEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.MethodExecutionResult Execute(System.String @methodInstanceName, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance, System.Object[] @inputParams)
        {
            return ExecuteEx;
        }
        public Microsoft.BusinessData.MetadataModel.MethodExecutionResult ExecuteEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.EntityView GetAssociationView(System.String @associationName)
        {
            return GetAssociationViewEx;
        }
        public Microsoft.BusinessData.MetadataModel.EntityView GetAssociationViewEx { get; set;}

        public override Microsoft.BusinessData.Runtime.EntityIdentity Create(Microsoft.BusinessData.Runtime.EntityFieldValueDictionary @fieldValues, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return CreateEx;
        }
        public Microsoft.BusinessData.Runtime.EntityIdentity CreateEx { get; set;}

        public override Microsoft.BusinessData.Runtime.Subscription Subscribe(Microsoft.BusinessData.Runtime.EntityEventType @eventType, Microsoft.BusinessData.Runtime.NotificationCallback @notificationCallback, System.String @onBehalfOfUser, System.String @subscriberName, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
            return SubscribeEx;
        }
        public Microsoft.BusinessData.Runtime.Subscription SubscribeEx { get; set;}

        public override void Unsubscribe(Microsoft.BusinessData.Runtime.Subscription @subscription, System.String @onBehalfOfUser, System.String @unsubscriberName, Microsoft.BusinessData.MetadataModel.LobSystemInstance @lobSystemInstance)
        {
        }

    }
}

