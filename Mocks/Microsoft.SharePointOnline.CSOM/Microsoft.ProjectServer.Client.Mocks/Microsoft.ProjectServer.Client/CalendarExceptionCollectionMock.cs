
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class CalendarExceptionCollectionMock : CalendarExceptionCollection
    {


        public override Microsoft.ProjectServer.Client.CalendarException GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.CalendarException GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.CalendarException Add(Microsoft.ProjectServer.Client.CalendarExceptionCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.CalendarException AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.CalendarException @exception)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

