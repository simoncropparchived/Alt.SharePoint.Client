
namespace Microsoft.SharePoint.Client
{
    public class JsonReaderMock
    {


        public override Microsoft.SharePoint.Client.ClientRuntimeContext Context => ContextEx;
        public Microsoft.SharePoint.Client.ClientRuntimeContext ContextEx { get; set; }

    }
}

