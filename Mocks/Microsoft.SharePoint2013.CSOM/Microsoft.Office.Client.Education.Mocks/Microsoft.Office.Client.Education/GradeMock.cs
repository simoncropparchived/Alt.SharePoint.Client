
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class GradeMock : Grade
    {


        public override System.Double NumericScore => NumericScoreEx;
        public System.Double NumericScoreEx { get; set; }

        public override System.String Score => ScoreEx;
        public System.String ScoreEx { get; set; }

    }
}

