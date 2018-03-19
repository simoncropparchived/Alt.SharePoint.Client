
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PhaseCollectionMock : PhaseCollection
    {


        public override Microsoft.ProjectServer.Client.Phase GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.Phase GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.Phase GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.Phase GetByGuidEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.ProjectServer.Client.Phase Add(Microsoft.ProjectServer.Client.PhaseCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.Phase AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.Phase @phase)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

