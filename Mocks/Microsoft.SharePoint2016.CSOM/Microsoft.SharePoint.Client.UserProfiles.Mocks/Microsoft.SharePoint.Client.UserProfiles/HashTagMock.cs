
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class HashTagMock : HashTag
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.UInt32 UseCount => UseCountEx;
        public System.UInt32 UseCountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

