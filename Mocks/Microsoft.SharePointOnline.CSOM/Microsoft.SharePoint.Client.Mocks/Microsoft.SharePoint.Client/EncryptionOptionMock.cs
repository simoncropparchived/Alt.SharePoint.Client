
namespace Microsoft.SharePoint.Client
{
    public class EncryptionOptionMock : EncryptionOption
    {


        public override System.Byte[] AES256CBCKey => AES256CBCKeyEx;
        public System.Byte[] AES256CBCKeyEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

