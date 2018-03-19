
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class LookupTableCollectionMock : LookupTableCollection
    {


        public override Microsoft.ProjectServer.Client.LookupTable GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.LookupTable GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupTable GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.LookupTable GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupTable GetByAppAlternateId(System.String @objectId)
        {
            return GetByAppAlternateIdEx;
        }
        public Microsoft.ProjectServer.Client.LookupTable GetByAppAlternateIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.LookupTable Add(Microsoft.ProjectServer.Client.LookupTableCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.LookupTable AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.LookupTable @table)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

    }
}

