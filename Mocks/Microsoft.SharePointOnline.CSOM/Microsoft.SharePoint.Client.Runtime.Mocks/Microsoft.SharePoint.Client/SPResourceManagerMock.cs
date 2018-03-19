
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class SPResourceManagerMock : SPResourceManager
    {


        public override System.String GetString(System.String @name, System.Globalization.CultureInfo @culture)
        {
            return GetStringEx;
        }
        public System.String GetStringEx { get; set;}

        public override System.Object GetObject(System.String @name, System.Globalization.CultureInfo @culture)
        {
            return GetObjectEx;
        }
        public System.Object GetObjectEx { get; set;}

    }
}

