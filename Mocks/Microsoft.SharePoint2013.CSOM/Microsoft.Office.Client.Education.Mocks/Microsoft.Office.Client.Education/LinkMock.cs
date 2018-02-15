
namespace Microsoft.Office.Client.Education
{
    public class LinkMock : Link
    {


        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

    }
}

