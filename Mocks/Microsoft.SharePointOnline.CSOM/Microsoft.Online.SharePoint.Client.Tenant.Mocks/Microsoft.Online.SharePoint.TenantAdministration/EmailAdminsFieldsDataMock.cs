
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class EmailAdminsFieldsDataMock : EmailAdminsFieldsData
    {


        public override System.String message => messageEx;
        public System.String messageEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Guid> siteIds => siteIdsEx;
        public System.Collections.Generic.IEnumerable`1<System.Guid> siteIdsEx { get; set; }

        public override System.String subject => subjectEx;
        public System.String subjectEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

