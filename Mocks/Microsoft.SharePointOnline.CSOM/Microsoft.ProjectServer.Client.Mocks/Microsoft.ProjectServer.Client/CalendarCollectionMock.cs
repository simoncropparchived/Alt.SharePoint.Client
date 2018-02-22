
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class CalendarCollectionMock : CalendarCollection
    {


        public override Microsoft.ProjectServer.Client.Calendar Add(Microsoft.ProjectServer.Client.CalendarCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.Calendar AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.Calendar @calendar)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override Microsoft.ProjectServer.Client.Calendar GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.Calendar GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.Calendar GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.Calendar GetByGuidEx { get; set;}

        public override void Update()
        {
        }

    }
}

