
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetWorkCollectionMock : TimeSheetWorkCollection
    {


        public override Microsoft.ProjectServer.Client.TimeSheetWork GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetWork GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.TimeSheetWork GetByStartDate(System.DateTime @start)
        {
            return GetByStartDateEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetWork GetByStartDateEx { get; set;}

        public override Microsoft.ProjectServer.Client.TimeSheetWork Add(Microsoft.ProjectServer.Client.TimeSheetWorkCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetWork AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.TimeSheetWork @work)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

