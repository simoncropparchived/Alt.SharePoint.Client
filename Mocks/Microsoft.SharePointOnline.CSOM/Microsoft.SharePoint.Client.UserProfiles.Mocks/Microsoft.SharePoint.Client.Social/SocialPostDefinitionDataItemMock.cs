
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostDefinitionDataItemMock
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostDefinitionDataItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialPostDefinitionDataItemType ItemTypeEx { get; set; }

        public override System.String PlaceholderName => PlaceholderNameEx;
        public System.String PlaceholderNameEx { get; set; }

        public override System.Guid TagGuid => TagGuidEx;
        public System.Guid TagGuidEx { get; set; }

        public override System.String Text => TextEx;
        public System.String TextEx { get; set; }

        public override System.String Uri => UriEx;
        public System.String UriEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

