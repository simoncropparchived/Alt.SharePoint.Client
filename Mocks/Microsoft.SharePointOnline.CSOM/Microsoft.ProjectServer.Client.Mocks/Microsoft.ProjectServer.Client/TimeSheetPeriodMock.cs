
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetPeriodMock
    {


        public override System.DateTime End => EndEx;
        public System.DateTime EndEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheet TimeSheet => TimeSheetEx;
        public Microsoft.ProjectServer.Client.TimeSheet TimeSheetEx { get; set; }

    }
}

