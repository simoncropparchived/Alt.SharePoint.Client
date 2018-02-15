
namespace Microsoft.SharePoint.Client
{
    public class ContentTypeIdMock : ContentTypeId
    {


        public override System.String StringValue => StringValueEx;
        public System.String StringValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

