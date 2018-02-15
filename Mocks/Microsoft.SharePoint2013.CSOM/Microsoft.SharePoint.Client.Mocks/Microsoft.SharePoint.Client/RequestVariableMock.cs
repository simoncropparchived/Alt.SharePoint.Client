
namespace Microsoft.SharePoint.Client
{
    public class RequestVariableMock : RequestVariable
    {


        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

    }
}

