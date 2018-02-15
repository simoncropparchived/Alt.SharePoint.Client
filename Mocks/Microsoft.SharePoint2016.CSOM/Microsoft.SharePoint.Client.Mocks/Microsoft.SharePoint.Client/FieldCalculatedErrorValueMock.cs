
namespace Microsoft.SharePoint.Client
{
    public class FieldCalculatedErrorValueMock : FieldCalculatedErrorValue
    {


        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

