
namespace Microsoft.SharePoint.Client.Utilities
{
    public class WopiWebAppPropertiesMock : WopiWebAppProperties
    {


        public override System.String App => AppEx;
        public System.String AppEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Utilities.WebAppUrlsByAction> ListByAction => ListByActionEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Utilities.WebAppUrlsByAction> ListByActionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

