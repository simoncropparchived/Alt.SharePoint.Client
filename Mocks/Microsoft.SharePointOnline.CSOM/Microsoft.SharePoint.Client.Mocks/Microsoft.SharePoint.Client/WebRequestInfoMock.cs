
namespace Microsoft.SharePoint.Client
{
    public class WebRequestInfoMock
    {


        public override System.String Body => BodyEx;
        public System.String BodyEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.String> Headers => HeadersEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> HeadersEx { get; set; }

        public override System.String Method => MethodEx;
        public System.String MethodEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

