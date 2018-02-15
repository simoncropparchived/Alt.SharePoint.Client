
namespace Microsoft.SharePoint.Client
{
    public class FieldUrlMock
    {


        public override Microsoft.SharePoint.Client.UrlFieldFormatType DisplayFormat => DisplayFormatEx;
        public Microsoft.SharePoint.Client.UrlFieldFormatType DisplayFormatEx { get; set; }

    }
}

