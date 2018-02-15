
namespace Microsoft.SharePoint.WebControls
{
    public class ResourceManifestInformationMock : ResourceManifestInformation
    {


        public override System.String RequireJsScriptBlock => RequireJsScriptBlockEx;
        public System.String RequireJsScriptBlockEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> ScenarioMapping => ScenarioMappingEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> ScenarioMappingEx { get; set; }

    }
}

