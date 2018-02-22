
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class LookupEntryCollectionMock : LookupEntryCollection
    {


        public override Microsoft.ProjectServer.Client.LookupEntry GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.LookupEntry GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupEntry GetByAppAlternateId(System.String @objectId)
        {
            return GetByAppAlternateIdEx;
        }
        public Microsoft.ProjectServer.Client.LookupEntry GetByAppAlternateIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupEntry GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.LookupEntry GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupEntry Add(Microsoft.ProjectServer.Client.LookupEntryCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.LookupEntry AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.LookupEntry @entry)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

