
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetPeriodCollectionMock : TimeSheetPeriodCollection
    {


        public override Microsoft.ProjectServer.Client.TimeSheetPeriod GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetPeriod GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.TimeSheetPeriod GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.TimeSheetPeriod GetByGuidEx { get; set;}

    }
}

