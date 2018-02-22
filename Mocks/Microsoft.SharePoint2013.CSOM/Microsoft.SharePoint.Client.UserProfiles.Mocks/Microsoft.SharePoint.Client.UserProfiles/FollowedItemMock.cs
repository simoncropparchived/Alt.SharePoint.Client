
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class FollowedItemMock : FollowedItem
    {


        public override System.Collections.Generic.IDictionary<System.String,System.Object> Data => DataEx;
        public System.Collections.Generic.IDictionary<System.String,System.Object> DataEx { get; set; }

        public override System.String FileType => FileTypeEx;
        public System.String FileTypeEx { get; set; }

        public override System.String FileTypeProgid => FileTypeProgidEx;
        public System.String FileTypeProgidEx { get; set; }

        public override System.String Flags => FlagsEx;
        public System.String FlagsEx { get; set; }

        public override System.Boolean HasFeed => HasFeedEx;
        public System.Boolean HasFeedEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.String IconUrl => IconUrlEx;
        public System.String IconUrlEx { get; set; }

        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.FollowedItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.UserProfiles.FollowedItemType ItemTypeEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.String ParentUrl => ParentUrlEx;
        public System.String ParentUrlEx { get; set; }

        public override System.String ServerUrlProgid => ServerUrlProgidEx;
        public System.String ServerUrlProgidEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.Int32 Subtype => SubtypeEx;
        public System.Int32 SubtypeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

