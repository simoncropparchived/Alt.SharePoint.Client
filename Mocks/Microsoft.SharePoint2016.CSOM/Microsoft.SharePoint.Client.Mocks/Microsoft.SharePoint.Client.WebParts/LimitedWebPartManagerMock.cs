
namespace Microsoft.SharePoint.Client.WebParts
{
    public class LimitedWebPartManagerMock : LimitedWebPartManager
    {


        public override System.Boolean HasPersonalizedParts => HasPersonalizedPartsEx;
        public System.Boolean HasPersonalizedPartsEx { get; set; }

        public override Microsoft.SharePoint.Client.WebParts.PersonalizationScope Scope => ScopeEx;
        public Microsoft.SharePoint.Client.WebParts.PersonalizationScope ScopeEx { get; set; }

        public override Microsoft.SharePoint.Client.WebParts.WebPartDefinitionCollection WebParts => WebPartsEx;
        public Microsoft.SharePoint.Client.WebParts.WebPartDefinitionCollection WebPartsEx { get; set; }

    }
}

