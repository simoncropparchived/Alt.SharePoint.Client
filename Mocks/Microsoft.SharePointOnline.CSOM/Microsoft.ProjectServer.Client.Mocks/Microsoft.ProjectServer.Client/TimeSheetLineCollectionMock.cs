
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetLineCollectionMock : TimeSheetLineCollection
    {


        public override Microsoft.ProjectServer.Client.TimeSheetLine GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetLine GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.TimeSheetLine GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetLine GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.TimeSheetLine Add(Microsoft.ProjectServer.Client.TimeSheetLineCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetLine AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.TimeSheetLine @line)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

