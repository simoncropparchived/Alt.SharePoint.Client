
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class SubmissionsMock : Submissions
    {


        public override Microsoft.Office.Client.Education.Submission AddEntity(Microsoft.Office.Client.Education.Submission @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Submission AddEntityEx { get; set;}

    }
}

