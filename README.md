# Alt.SharePoint.Client

A clone of the SharePoint client NuGets but with the following changes

 * All public member made virtual.
 * A public parameterless constructor added to all public types.
 * Constructors of public type made public.
 * StrongNamed with a new key

**This results in the public types being mockable for unit testing purposes.**


## Source NuGets

 * [Microsoft.SharePoint2013.CSOM](https://www.nuget.org/packages/Microsoft.SharePoint2013.CSOM/)
 * [Microsoft.SharePoint2016.CSOM](https://www.nuget.org/packages/Microsoft.SharePoint2016.CSOM/)
 * [Microsoft.SharePointOnline.CSOM](https://www.nuget.org/packages/Microsoft.SharePointOnline.CSOM/)


## Produce NuGets
 
 * [Alt.SharePoint2013.CSOM](https://www.nuget.org/packages/Alt.SharePoint2013.CSOM/)
 * [Alt.SharePoint2013.CSOM.Min](https://www.nuget.org/packages/Alt.SharePoint2013.CSOM.Min/)
 * [Alt.SharePoint2016.CSOM](https://www.nuget.org/packages/Alt.SharePoint2016.CSOM/)
 * [Alt.SharePoint2016.CSOM.Min](https://www.nuget.org/packages/Alt.SharePoint2016.CSOM.Min/)
 * [Alt.SharePointOnline.CSOM](https://www.nuget.org/packages/Alt.SharePointOnline.CSOM/)
 * [Alt.SharePointOnline.CSOM.Min](https://www.nuget.org/packages/Alt.SharePointOnline.CSOM.Min/)

The *.Min* variants contain  only `Microsoft.SharePoint.Client.dll` and `Microsoft.SharePoint.Client.Runtime.dll`.