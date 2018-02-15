
namespace Microsoft.SharePoint.Client
{
    public class FieldLookupValueMock
    {


        public override System.Int32 LookupId => LookupIdEx;
        public System.Int32 LookupIdEx { get; set; }

        public override System.String LookupValue => LookupValueEx;
        public System.String LookupValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

