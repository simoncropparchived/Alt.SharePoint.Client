
namespace Microsoft.Office.Client.Education
{
    public class AssignmentCategoryMock
    {


        public override Microsoft.Office.Client.Education.Assignments Assignments => AssignmentsEx;
        public Microsoft.Office.Client.Education.Assignments AssignmentsEx { get; set; }

        public override System.Double Weight => WeightEx;
        public System.Double WeightEx { get; set; }

    }
}

