
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentCreationInformationMock
    {


        public override Microsoft.ProjectServer.Client.BookingType BookingType => BookingTypeEx;
        public Microsoft.ProjectServer.Client.BookingType BookingTypeEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.PlanAssignmentIntervalCreationInformation> Intervals => IntervalsEx;
        public System.Collections.Generic.IEnumerable`1<Microsoft.ProjectServer.Client.PlanAssignmentIntervalCreationInformation> IntervalsEx { get; set; }

        public override System.Guid ResourceId => ResourceIdEx;
        public System.Guid ResourceIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

