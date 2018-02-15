
namespace Microsoft.SharePoint.ClientSideComponent
{
    public class StorageEntityMock : StorageEntity
    {


        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

    }
}

