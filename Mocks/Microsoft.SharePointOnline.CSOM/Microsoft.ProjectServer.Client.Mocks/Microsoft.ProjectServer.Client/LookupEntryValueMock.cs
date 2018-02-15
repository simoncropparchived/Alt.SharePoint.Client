
namespace Microsoft.ProjectServer.Client
{
    public class LookupEntryValueMock : LookupEntryValue
    {


        public override System.DateTime DateValue => DateValueEx;
        public System.DateTime DateValueEx { get; set; }

        public override System.String DurationValue => DurationValueEx;
        public System.String DurationValueEx { get; set; }

        public override System.Decimal NumberValue => NumberValueEx;
        public System.Decimal NumberValueEx { get; set; }

        public override System.String TextValue => TextValueEx;
        public System.String TextValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

