
namespace Microsoft.SharePoint.Client
{
    public class ClientTypeAssemblyAttributeMock
    {


        public override System.Type ScriptTypeFactory => ScriptTypeFactoryEx;
        public System.Type ScriptTypeFactoryEx { get; set; }

    }
}

