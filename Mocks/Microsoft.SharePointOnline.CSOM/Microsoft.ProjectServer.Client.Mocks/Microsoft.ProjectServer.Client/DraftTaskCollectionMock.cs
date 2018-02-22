
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DraftTaskCollectionMock : DraftTaskCollection
    {


        public override Microsoft.ProjectServer.Client.DraftTask GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.DraftTask GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftTask GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.DraftTask GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftTask Add(Microsoft.ProjectServer.Client.TaskCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.DraftTask AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.DraftTask @task)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

