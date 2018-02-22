
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EventHandlerCollectionMock : EventHandlerCollection
    {


        public override Microsoft.ProjectServer.Client.EventHandler GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.EventHandler GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.EventHandler GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.EventHandler GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.EventHandler Add(Microsoft.ProjectServer.Client.EventHandlerCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.EventHandler AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.EventHandler @handler)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

    }
}

