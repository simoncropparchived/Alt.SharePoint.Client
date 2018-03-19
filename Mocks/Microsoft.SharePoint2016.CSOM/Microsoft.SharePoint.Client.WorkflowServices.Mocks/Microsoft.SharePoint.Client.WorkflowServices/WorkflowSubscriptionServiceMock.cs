
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowSubscriptionServiceMock : WorkflowSubscriptionService
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> PublishSubscription(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @subscription)
        {
            return PublishSubscriptionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> PublishSubscriptionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> PublishSubscriptionForList(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @subscription, System.Guid @listId)
        {
            return PublishSubscriptionForListEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> PublishSubscriptionForListEx { get; set;}

        public override void RegisterInterestInList(System.Guid @listId, System.String @eventName)
        {
        }

        public override void RegisterInterestInHostWebList(System.Guid @listId, System.String @eventName)
        {
        }

        public override void UnregisterInterestInList(System.Guid @listId, System.String @eventName)
        {
        }

        public override void UnregisterInterestInHostWebList(System.Guid @listId, System.String @eventName)
        {
        }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription GetSubscription(System.Guid @subscriptionId)
        {
            return GetSubscriptionEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription GetSubscriptionEx { get; set;}

        public override void DeleteSubscription(System.Guid @subscriptionId)
        {
        }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptions()
        {
            return EnumerateSubscriptionsEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByDefinition(System.Guid @definitionId)
        {
            return EnumerateSubscriptionsByDefinitionEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByDefinitionEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByEventSource(System.Guid @eventSourceId)
        {
            return EnumerateSubscriptionsByEventSourceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByEventSourceEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByList(System.Guid @listId)
        {
            return EnumerateSubscriptionsByListEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByListEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByListWithContentType(System.Guid @listId, System.Boolean @includeContentTypeSpecified)
        {
            return EnumerateSubscriptionsByListWithContentTypeEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByListWithContentTypeEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByListAndParentContentType(System.Guid @listId, Microsoft.SharePoint.Client.ContentTypeId @parentContentTypeId, System.Boolean @includeNoContentTypeSpecified)
        {
            return EnumerateSubscriptionsByListAndParentContentTypeEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionCollection EnumerateSubscriptionsByListAndParentContentTypeEx { get; set;}

    }
}

