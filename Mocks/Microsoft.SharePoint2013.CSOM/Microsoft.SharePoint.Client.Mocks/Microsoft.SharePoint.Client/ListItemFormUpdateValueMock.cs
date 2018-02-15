
namespace Microsoft.SharePoint.Client
{
    public class ListItemFormUpdateValueMock : ListItemFormUpdateValue
    {


        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.String FieldName => FieldNameEx;
        public System.String FieldNameEx { get; set; }

        public override System.String FieldValue => FieldValueEx;
        public System.String FieldValueEx { get; set; }

        public override System.Boolean HasException => HasExceptionEx;
        public System.Boolean HasExceptionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

