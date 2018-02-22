
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class WorkflowActivitiesMock : WorkflowActivities
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateProjectFromListItem(System.Guid @webId, System.Guid @listId, System.Int32 @itemId, System.Guid @eptId)
        {
            return CreateProjectFromListItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateProjectFromListItemEx { get; set;}

        public override void UpdateIdeaListItemStatus(System.Guid @projectId, System.String @status)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Double> ReadCurrencyProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadCurrencyPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Double> ReadCurrencyPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.DateTime> ReadDateTimeProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadDateTimePropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.DateTime> ReadDateTimePropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> ReadIntegerProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadIntegerPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> ReadIntegerPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> ReadBooleanProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadBooleanPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> ReadBooleanPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Double> ReadNumberProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadNumberPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Double> ReadNumberPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ReadTextProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadTextPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ReadTextPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> ReadGuidProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadGuidPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> ReadGuidPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ReadProjectProperty(System.Guid @projectId, System.String @propertyId)
        {
            return ReadProjectPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ReadProjectPropertyEx { get; set;}

        public override void UpdateCurrencyProperty(System.Guid @projectId, System.String @propertyId, System.Double @value)
        {
        }

        public override void UpdateDateTimeProperty(System.Guid @projectId, System.String @propertyId, System.DateTime @value)
        {
        }

        public override void UpdateIntegerProperty(System.Guid @projectId, System.String @propertyId, System.Int32 @value)
        {
        }

        public override void UpdateBooleanProperty(System.Guid @projectId, System.String @propertyId, System.Boolean @value)
        {
        }

        public override void UpdateNumberProperty(System.Guid @projectId, System.String @propertyId, System.Double @value)
        {
        }

        public override void UpdateTextProperty(System.Guid @projectId, System.String @propertyId, System.String @value)
        {
        }

        public override void UpdateGuidProperty(System.Guid @projectId, System.String @propertyId, System.Guid @value)
        {
        }

        public override void UpdateProjectStageStatus(System.Guid @projectId, System.Guid @stageId, System.String @statusInformation, Microsoft.ProjectServer.Client.UpdateProjectStageStatusFieldValue @stageStatusValue, System.Boolean @append)
        {
        }

        public override void EnterProjectStage(System.Guid @projectId, System.Guid @stageId)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.ProjectServer.Client.ReadyToLeaveProjectStageValue> ReadyToLeaveProjectStage(System.Guid @projectId)
        {
            return ReadyToLeaveProjectStageEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.ProjectServer.Client.ReadyToLeaveProjectStageValue> ReadyToLeaveProjectStageEx { get; set;}

        public override void LeaveProjectStage(System.Guid @projectId)
        {
        }

    }
}

