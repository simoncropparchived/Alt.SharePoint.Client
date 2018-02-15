
namespace Microsoft.SharePoint.Client
{
    public class MoveCopyOptionsMock
    {


        public override System.Boolean KeepBoth => KeepBothEx;
        public System.Boolean KeepBothEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

