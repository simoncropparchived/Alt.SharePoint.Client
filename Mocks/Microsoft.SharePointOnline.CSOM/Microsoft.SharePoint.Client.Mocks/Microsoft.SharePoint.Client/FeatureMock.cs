
namespace Microsoft.SharePoint.Client
{
    public class FeatureMock : Feature
    {


        public override System.Guid DefinitionId => DefinitionIdEx;
        public System.Guid DefinitionIdEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

    }
}

