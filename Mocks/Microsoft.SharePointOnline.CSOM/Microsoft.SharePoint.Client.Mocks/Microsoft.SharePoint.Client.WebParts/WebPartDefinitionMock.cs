
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WebParts
{
    public class WebPartDefinitionMock : WebPartDefinition
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.WebParts.WebPart WebPart => WebPartEx;
        public Microsoft.SharePoint.Client.WebParts.WebPart WebPartEx { get; set; }

        public override System.String ZoneId => ZoneIdEx;
        public System.String ZoneIdEx { get; set; }

        public override void SaveWebPartChanges()
        {
        }

        public override void CloseWebPart()
        {
        }

        public override void OpenWebPart()
        {
        }

        public override void DeleteWebPart()
        {
        }

        public override void MoveWebPartTo(System.String @zoneID, System.Int32 @zoneIndex)
        {
        }

    }
}

