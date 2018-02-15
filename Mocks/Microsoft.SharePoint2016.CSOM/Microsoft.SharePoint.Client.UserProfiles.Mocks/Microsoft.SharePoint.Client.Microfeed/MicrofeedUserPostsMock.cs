
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedUserPostsMock
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedPostOptionCollection PostOptions => PostOptionsEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedPostOptionCollection PostOptionsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

