
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StageCollectionMock : StageCollection
    {


        public override Microsoft.ProjectServer.Client.Stage GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.Stage GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.Stage GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.Stage GetByGuidEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.ProjectServer.Client.Stage Add(Microsoft.ProjectServer.Client.StageCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.Stage AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.Stage @stage)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

