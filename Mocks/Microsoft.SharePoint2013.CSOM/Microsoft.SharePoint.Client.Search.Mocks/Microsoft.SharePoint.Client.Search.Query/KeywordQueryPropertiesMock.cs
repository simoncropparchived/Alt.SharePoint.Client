
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class KeywordQueryPropertiesMock : KeywordQueryProperties
    {


        public override System.Object this[System.String fieldName] { set => ItemEx[fieldName] = value;}
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


    }
}

