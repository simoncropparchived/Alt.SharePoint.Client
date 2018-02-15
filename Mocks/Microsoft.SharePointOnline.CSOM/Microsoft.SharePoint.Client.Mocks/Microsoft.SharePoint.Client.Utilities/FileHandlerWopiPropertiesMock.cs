
namespace Microsoft.SharePoint.Client.Utilities
{
    public class FileHandlerWopiPropertiesMock
    {


        public override System.String FileGetUrl => FileGetUrlEx;
        public System.String FileGetUrlEx { get; set; }

        public override System.String FileId => FileIdEx;
        public System.String FileIdEx { get; set; }

        public override System.String FilePutUrl => FilePutUrlEx;
        public System.String FilePutUrlEx { get; set; }

        public override System.String ResourceId => ResourceIdEx;
        public System.String ResourceIdEx { get; set; }

    }
}

