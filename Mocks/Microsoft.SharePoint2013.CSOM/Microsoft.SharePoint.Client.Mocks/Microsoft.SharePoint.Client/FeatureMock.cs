
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FeatureMock : Feature
    {


        public override System.Guid DefinitionId => DefinitionIdEx;
        public System.Guid DefinitionIdEx { get; set; }

    }
}

