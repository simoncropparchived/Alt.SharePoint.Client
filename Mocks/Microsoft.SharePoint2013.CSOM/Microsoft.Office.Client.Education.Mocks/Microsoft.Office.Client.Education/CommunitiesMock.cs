
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class CommunitiesMock : Communities
    {


        public override Microsoft.Office.Client.Education.Community AddEntity(Microsoft.Office.Client.Education.Community @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Community AddEntityEx { get; set;}

    }
}

