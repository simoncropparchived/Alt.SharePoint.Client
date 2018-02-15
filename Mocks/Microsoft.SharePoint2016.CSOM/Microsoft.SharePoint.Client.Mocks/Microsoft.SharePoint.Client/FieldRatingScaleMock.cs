
namespace Microsoft.SharePoint.Client
{
    public class FieldRatingScaleMock : FieldRatingScale
    {


        public override System.Int32 GridEndNumber => GridEndNumberEx;
        public System.Int32 GridEndNumberEx { get; set; }

        public override System.String GridNAOptionText => GridNAOptionTextEx;
        public System.String GridNAOptionTextEx { get; set; }

        public override System.Int32 GridStartNumber => GridStartNumberEx;
        public System.Int32 GridStartNumberEx { get; set; }

        public override System.String GridTextRangeAverage => GridTextRangeAverageEx;
        public System.String GridTextRangeAverageEx { get; set; }

        public override System.String GridTextRangeHigh => GridTextRangeHighEx;
        public System.String GridTextRangeHighEx { get; set; }

        public override System.String GridTextRangeLow => GridTextRangeLowEx;
        public System.String GridTextRangeLowEx { get; set; }

        public override System.Int32 RangeCount => RangeCountEx;
        public System.Int32 RangeCountEx { get; set; }

    }
}

