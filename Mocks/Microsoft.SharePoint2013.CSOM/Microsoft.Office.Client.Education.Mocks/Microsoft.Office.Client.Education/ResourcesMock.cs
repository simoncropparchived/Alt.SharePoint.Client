
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class ResourcesMock : Resources
    {


        public override Microsoft.Office.Client.Education.Resource AddEntity(Microsoft.Office.Client.Education.Resource @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Resource AddEntityEx { get; set;}

    }
}

