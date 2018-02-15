
namespace Microsoft.SharePoint.Client
{
    public class ListDataValidationFailureMock
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String Message => MessageEx;
        public System.String MessageEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.ListDataValidationFailureReason Reason => ReasonEx;
        public Microsoft.SharePoint.Client.ListDataValidationFailureReason ReasonEx { get; set; }

        public override Microsoft.SharePoint.Client.ListDataValidationType ValidationType => ValidationTypeEx;
        public Microsoft.SharePoint.Client.ListDataValidationType ValidationTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

