
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldLinkCollectionMock : FieldLinkCollection
    {


        public override Microsoft.SharePoint.Client.FieldLink GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.FieldLink GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.FieldLink Add(Microsoft.SharePoint.Client.FieldLinkCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.FieldLink AddEx { get; set;}

        public override void Reorder(System.String[] @internalNames)
        {
        }

    }
}

