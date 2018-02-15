
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedDataLinkMock : MicrofeedDataLink
    {


        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedDataLinkType DataLinkType => DataLinkTypeEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedDataLinkType DataLinkTypeEx { get; set; }

        public override System.DateTime DateTimeValue => DateTimeValueEx;
        public System.DateTime DateTimeValueEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String PlaceHolderName => PlaceHolderNameEx;
        public System.String PlaceHolderNameEx { get; set; }

        public override System.String StringValue => StringValueEx;
        public System.String StringValueEx { get; set; }

        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override System.String UriValue => UriValueEx;
        public System.String UriValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

