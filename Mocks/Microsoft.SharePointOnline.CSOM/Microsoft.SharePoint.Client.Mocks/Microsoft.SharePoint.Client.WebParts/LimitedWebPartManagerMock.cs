
// ReSharper disable IdentifierTypo
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

        public override Microsoft.SharePoint.Client.WebParts.WebPartDefinition AddWebPart(Microsoft.SharePoint.Client.WebParts.WebPart @webPart, System.String @zoneId, System.Int32 @zoneIndex)
        {
            return AddWebPartEx;
        }
        public Microsoft.SharePoint.Client.WebParts.WebPartDefinition AddWebPartEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ExportWebPart(System.Guid @webPartId)
        {
            return ExportWebPartEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ExportWebPartEx { get; set;}

        public override Microsoft.SharePoint.Client.WebParts.WebPartDefinition ImportWebPart(System.String @webPartXml)
        {
            return ImportWebPartEx;
        }
        public Microsoft.SharePoint.Client.WebParts.WebPartDefinition ImportWebPartEx { get; set;}

    }
}

