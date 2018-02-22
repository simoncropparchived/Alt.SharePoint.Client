
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class TimeZoneCollectionMock : TimeZoneCollection
    {


        public override Microsoft.SharePoint.Client.TimeZone GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.TimeZone GetByIdEx { get; set;}

    }
}

