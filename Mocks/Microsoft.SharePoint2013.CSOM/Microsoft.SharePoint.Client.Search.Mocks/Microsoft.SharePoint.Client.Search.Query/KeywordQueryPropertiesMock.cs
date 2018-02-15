
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class KeywordQueryPropertiesMock : KeywordQueryProperties
    {


        public override System.Object Item { set { ItemEx = value; } };
        public System.Object ItemEx { get; set; }

    }
}

