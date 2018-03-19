
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyEventMock : SPPolicyEvent
    {


        public override System.DateTime EventDateTime => EventDateTimeEx;
        public System.DateTime EventDateTimeEx { get; set; }

        public override System.String[] EventTags => EventTagsEx;
        public System.String[] EventTagsEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String StatusData => StatusDataEx;
        public System.String StatusDataEx { get; set; }

        public override System.DateTime WhenChangedUTC => WhenChangedUTCEx;
        public System.DateTime WhenChangedUTCEx { get; set; }

        public override System.DateTime WhenCreatedUTC => WhenCreatedUTCEx;
        public System.DateTime WhenCreatedUTCEx { get; set; }

        public override System.Int32 Workload => WorkloadEx;
        public System.Int32 WorkloadEx { get; set; }

    }
}

