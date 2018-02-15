
namespace Microsoft.ProjectServer.Client
{
    public class LookupMaskMock : LookupMask
    {


        public override System.Int32 Length => LengthEx;
        public System.Int32 LengthEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupTableMaskSequence MaskType => MaskTypeEx;
        public Microsoft.ProjectServer.Client.LookupTableMaskSequence MaskTypeEx { get; set; }

        public override System.String Separator => SeparatorEx;
        public System.String SeparatorEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

