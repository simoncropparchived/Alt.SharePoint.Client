
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedDataMock : MicrofeedData
    {


        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String, System.Object> Data => DataEx;
        public System.Collections.Generic.IDictionary<System.String, System.Object> DataEx { get; set; }

        public override System.Int32 DefinitionId => DefinitionIdEx;
        public System.Int32 DefinitionIdEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogType ItemTypeEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String TargetIdentifier => TargetIdentifierEx;
        public System.String TargetIdentifierEx { get; set; }

        public override System.String Version => VersionEx;
        public System.String VersionEx { get; set; }

        public override void AddAttachment(System.String @name, System.Byte[] @bytes)
        {
        }

        public override void Update()
        {
        }

        public override void SystemUpdate()
        {
        }

    }
}

