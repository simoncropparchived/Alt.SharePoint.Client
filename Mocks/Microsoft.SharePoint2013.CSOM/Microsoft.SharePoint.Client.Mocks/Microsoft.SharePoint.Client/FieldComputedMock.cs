
namespace Microsoft.SharePoint.Client
{
    public class FieldComputedMock : FieldComputed
    {


        public override System.Boolean EnableLookup => EnableLookupEx;
        public System.Boolean EnableLookupEx { get; set; }

    }
}

