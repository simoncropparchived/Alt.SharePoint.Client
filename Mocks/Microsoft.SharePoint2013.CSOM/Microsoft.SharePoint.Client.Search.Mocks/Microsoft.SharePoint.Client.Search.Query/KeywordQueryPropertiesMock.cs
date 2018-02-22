
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class KeywordQueryPropertiesMock : KeywordQueryProperties
    {


        public override System.Object this[System.String fieldName] { set => ItemEx[fieldName] = value;}
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override void SetQueryPropertyValue(System.String @name, Microsoft.SharePoint.Client.Search.Query.QueryPropertyValue @val)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.QueryPropertyValue> GetQueryPropertyValue(System.String @name)
        {
            return GetQueryPropertyValueEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.QueryPropertyValue> GetQueryPropertyValueEx { get; set;}

    }
}

