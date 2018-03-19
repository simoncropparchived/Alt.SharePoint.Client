
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationJobStatusMock : TranslationJobStatus
    {


        public override System.Int32 Canceled => CanceledEx;
        public System.Int32 CanceledEx { get; set; }

        public override System.Int32 Count => CountEx;
        public System.Int32 CountEx { get; set; }

        public override System.Int32 Failed => FailedEx;
        public System.Int32 FailedEx { get; set; }

        public override System.Int32 InProgress => InProgressEx;
        public System.Int32 InProgressEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 NotStarted => NotStartedEx;
        public System.Int32 NotStartedEx { get; set; }

        public override System.Int32 Succeeded => SucceededEx;
        public System.Int32 SucceededEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> GetItems(Microsoft.Office.Client.TranslationServices.ItemTypes @types)
        {
            return GetItemsEx;
        }
        public System.Collections.Generic.IEnumerable<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> GetItemsEx { get; set;}

        public override System.Collections.Generic.IEnumerable<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> GetAllItems()
        {
            return GetAllItemsEx;
        }
        public System.Collections.Generic.IEnumerable<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> GetAllItemsEx { get; set;}

        public override void Refresh()
        {
        }

    }
}

