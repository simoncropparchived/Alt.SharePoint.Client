
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class ResourceRefMock : ResourceRef
    {


        public override Microsoft.Office.Client.Education.Resource Resource => ResourceEx;
        public Microsoft.Office.Client.Education.Resource ResourceEx { get; set; }

    }
}

