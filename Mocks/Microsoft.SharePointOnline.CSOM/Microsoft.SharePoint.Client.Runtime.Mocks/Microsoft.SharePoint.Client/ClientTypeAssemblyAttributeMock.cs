
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientTypeAssemblyAttributeMock : ClientTypeAssemblyAttribute
    {


        public override System.Type ScriptTypeFactory => ScriptTypeFactoryEx;
        public System.Type ScriptTypeFactoryEx { get; set; }

    }
}

