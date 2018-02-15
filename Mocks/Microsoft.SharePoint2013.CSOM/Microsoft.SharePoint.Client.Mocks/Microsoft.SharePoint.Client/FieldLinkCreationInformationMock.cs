
namespace Microsoft.SharePoint.Client
{
    public class FieldLinkCreationInformationMock
    {


        public override Microsoft.SharePoint.Client.Field Field => FieldEx;
        public Microsoft.SharePoint.Client.Field FieldEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

