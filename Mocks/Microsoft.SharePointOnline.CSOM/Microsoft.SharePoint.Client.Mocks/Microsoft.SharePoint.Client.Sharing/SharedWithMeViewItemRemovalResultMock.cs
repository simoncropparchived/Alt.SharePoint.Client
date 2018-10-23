
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Sharing
{
    public class SharedWithMeViewItemRemovalResultMock : SharedWithMeViewItemRemovalResult
    {


        public override Microsoft.SharePoint.Client.Sharing.RemoveItemsFromSharedWithMeViewErrorCode ErrorCode => ErrorCodeEx;
        public Microsoft.SharePoint.Client.Sharing.RemoveItemsFromSharedWithMeViewErrorCode ErrorCodeEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.Boolean Success => SuccessEx;
        public System.Boolean SuccessEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}
