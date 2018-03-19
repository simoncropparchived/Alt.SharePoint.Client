
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class LookupDurationMock : LookupDuration
    {


        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

        public override System.TimeSpan ValueTimeSpan => ValueTimeSpanEx;
        public System.TimeSpan ValueTimeSpanEx { get; set; }

    }
}

