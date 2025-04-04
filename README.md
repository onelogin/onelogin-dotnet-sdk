# onelogin-dotnet-sdk

This is a portable library for consuming the OneLogin REST-API and accessing all the features of the Onelogin API /1 and API/2 in (almost) any C# application.
This is the Url for more info about the API versions : https://developers.onelogin.com/api-docs/2/getting-started/dev-overview

The toolkit is hosted on GitHub. You can download it from: 

Latest release:  https://github.com/onelogin/onelogin-dotnet-sdk/tree/develop 

Master repo:  https://github.com/onelogin/onelogin-dotnet-sdk/tree/develop
# Quickstart

## Including OneLogin Dot Net SDK
The OneLogin API is avaiable through [NuGet](https://www.nuget.org/packages/OneloginApi.Dotnet.Nuget/):

```
> Install-Package OneloginApi.Dotnet.Nuget

```

## Status

[![Nuget](https://img.shields.io/nuget/v/OneloginApi.Dotnet.Nuget?style=for-the-badge)]()

## Supported Plattforms
OneLogin API is built on top of the new [.NET Standard](https://github.com/dotnet/standard) targeting netstandard versions 8.0 - therefore it should work on the following plaforms:
* .NET Framework 4.6 and newer
* .NET Core 8 or newer
* Universal Windows Platform (uap)
* Windows 8.0 and newer
* Windows Phone (WinRT, not Silverlight)
* Mono / Xamarin

## Getting started

You'll need a OneLogin account and a set of API credentials before you get started.

If you don't have an account you can [sign up for a free developer account here](https://www.onelogin.com/developer-signup).

|               |                                                             |
|---------------|-------------------------------------------------------------|
| client_id     | Required: A valid OneLogin API client_id                    |
| client_secret | Required: A valid OneLogin API client_secret                |
| api_domain    | Required: It should look like youraccountname.onelogin.com) |

```dotnet
using OneLogin;

var client = new OneLoginClient("client_id", "client_secret", "api_domain");

# Now you can make requests
var list_users = await client.ListUsers();
```
