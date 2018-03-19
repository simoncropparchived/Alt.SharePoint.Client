
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class LabelCollectionMock : LabelCollection
    {


        public override Microsoft.SharePoint.Client.Taxonomy.Label GetByValue(System.String @index)
        {
            return GetByValueEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Label GetByValueEx { get; set;}

    }
}

