
namespace Microsoft.SharePoint.Client
{
    public class MultiGeoCopyParametersMock
    {


        public override System.Byte[] binaryPayload => binaryPayloadEx;
        public System.Byte[] binaryPayloadEx { get; set; }

        public override System.Guid jobId => jobIdEx;
        public System.Guid jobIdEx { get; set; }

        public override System.Int32 userId => userIdEx;
        public System.Int32 userIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

