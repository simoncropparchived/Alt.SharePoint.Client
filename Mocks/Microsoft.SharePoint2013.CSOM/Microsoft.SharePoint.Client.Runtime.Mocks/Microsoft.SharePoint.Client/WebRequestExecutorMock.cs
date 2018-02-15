
namespace Microsoft.SharePoint.Client
{
    public class WebRequestExecutorMock
    {


        public override System.Net.HttpWebRequest WebRequest => WebRequestEx;
        public System.Net.HttpWebRequest WebRequestEx { get; set; }

        public override System.String RequestContentType => RequestContentTypeEx;
        public System.String RequestContentTypeEx { get; set; }

        public override System.Net.WebHeaderCollection RequestHeaders => RequestHeadersEx;
        public System.Net.WebHeaderCollection RequestHeadersEx { get; set; }

        public override System.String RequestMethod => RequestMethodEx;
        public System.String RequestMethodEx { get; set; }

        public override System.Boolean RequestKeepAlive => RequestKeepAliveEx;
        public System.Boolean RequestKeepAliveEx { get; set; }

        public override System.Net.HttpStatusCode StatusCode => StatusCodeEx;
        public System.Net.HttpStatusCode StatusCodeEx { get; set; }

        public override System.String ResponseContentType => ResponseContentTypeEx;
        public System.String ResponseContentTypeEx { get; set; }

        public override System.Net.WebHeaderCollection ResponseHeaders => ResponseHeadersEx;
        public System.Net.WebHeaderCollection ResponseHeadersEx { get; set; }

    }
}

