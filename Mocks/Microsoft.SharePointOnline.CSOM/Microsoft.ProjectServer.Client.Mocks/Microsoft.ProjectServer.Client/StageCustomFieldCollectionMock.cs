
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StageCustomFieldCollectionMock : StageCustomFieldCollection
    {


        public override Microsoft.ProjectServer.Client.StageCustomField GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.StageCustomField GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.StageCustomField GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.StageCustomField GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.StageCustomField Add(Microsoft.ProjectServer.Client.StageCustomFieldCreationInformation @creationInfo)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.StageCustomField AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.StageCustomField @field)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

