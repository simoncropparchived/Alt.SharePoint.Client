
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class CustomFieldCollectionMock : CustomFieldCollection
    {


        public override Microsoft.ProjectServer.Client.CustomField Add(Microsoft.ProjectServer.Client.CustomFieldCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.CustomField AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.CustomField @field)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override Microsoft.ProjectServer.Client.CustomField GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.CustomField GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.CustomField GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.CustomField GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.CustomField GetByAppAlternateId(System.String @objectId)
        {
            return GetByAppAlternateIdEx;
        }
        public Microsoft.ProjectServer.Client.CustomField GetByAppAlternateIdEx { get; set;}

        public override void Update()
        {
        }

    }
}

