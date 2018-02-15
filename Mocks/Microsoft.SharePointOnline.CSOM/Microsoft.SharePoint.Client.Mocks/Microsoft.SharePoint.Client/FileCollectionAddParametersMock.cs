
namespace Microsoft.SharePoint.Client
{
    public class FileCollectionAddParametersMock
    {


        public override System.Boolean Overwrite => OverwriteEx;
        public System.Boolean OverwriteEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

