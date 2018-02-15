
namespace Microsoft.SharePoint.Client.WebParts
{
    public class WebPartDefinitionMock
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.WebParts.WebPart WebPart => WebPartEx;
        public Microsoft.SharePoint.Client.WebParts.WebPart WebPartEx { get; set; }

    }
}

