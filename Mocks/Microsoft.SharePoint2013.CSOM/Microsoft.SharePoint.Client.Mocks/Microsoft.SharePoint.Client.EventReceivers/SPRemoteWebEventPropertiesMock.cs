
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteWebEventPropertiesMock : SPRemoteWebEventProperties
    {


        public override System.String FullUrl => FullUrlEx;
        public System.String FullUrlEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String NewServerRelativeUrl => NewServerRelativeUrlEx;
        public System.String NewServerRelativeUrlEx { get; set; }

    }
}

