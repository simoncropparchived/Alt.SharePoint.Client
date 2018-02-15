
namespace Microsoft.SharePoint.Client
{
    public class ConditionalScopeBaseMock : ConditionalScopeBase
    {


        public override System.Nullable<System.Boolean> TestResult => TestResultEx;
        public System.Nullable<System.Boolean> TestResultEx { get; set; }

    }
}

