
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class EventsMock : Events
    {


        public override Microsoft.Office.Client.Education.Event AddEntity(Microsoft.Office.Client.Education.Event @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Event AddEntityEx { get; set;}

    }
}

