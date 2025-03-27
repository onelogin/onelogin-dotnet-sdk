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

|||
|---|---|
|client_id|Required: A valid OneLogin API client_id|
|client_secret|Required: A valid OneLogin API client_secret|
|api_domain| Required: It should look like youraccountname.onelogin.com) |

```dotnet
using OneLogin;

var client = new OneLoginClient("client_id", "client_secret", "api_domain");

# Now you can make requests
var list_users = await client.ListUsers();
```

**[Usage]**

**Errors and Exceptions**

OneLogin\'s API can return 400, 401, 403 or 404 when there was any issue
executing the action. 

**[Code]**

**Authentication**

By default methods call internally to get_access_token if there is no
valid access_token. You can also get tokens etc directly if needed.

\# Get an AccessToken

var generateToken = await client.GenerateTokens();

\# Revoke an AccessToken

var RevokeToken = await client.RevokeToken();


**[Methods and Examples]{.underline}**

**1.  [Users]**

**Method**

list_users

**Endpoint**

**GET** /api/2/users

**Query Parameters**

+-------------------------+--------------------------------------------+
| Name/Type               | Description                                |
+=========================+============================================+
| **created_since**       | An ISO8601 timestamp value that returns    |
|                         | all users created after a given date &     |
| string                  | time. e.g. 2020-07-01T20:38:24Z            |
+-------------------------+--------------------------------------------+
| **created_until**       | An ISO8601 timestamp value that returns    |
|                         | all users created before a given date &    |
| string                  | time.                                      |
+-------------------------+--------------------------------------------+
| **updated_since**       | An ISO8601 timestamp value that returns    |
|                         | all users updated after a given date &     |
| string                  | time.                                      |
+-------------------------+--------------------------------------------+
| **updated_until**       | An ISO8601 timestamp value that returns    |
|                         | all users updated before a given date &    |
| string                  | time.                                      |
+-------------------------+--------------------------------------------+
| **last_login_since**    | An ISO8601 timestamp value that returns    |
|                         | all users that logged in after a given     |
| string                  | date & time.                               |
+-------------------------+--------------------------------------------+
| **last_login_until**    | An ISO8601 timestamp value that returns    |
|                         | all users that logged in before a given    |
| string                  | date & time.                               |
+-------------------------+--------------------------------------------+
| **firstname**           | The first name of the user                 |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **lastname**            | The last name of the user                  |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **email**               | The email address of the user              |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **username**            | The username for the user                  |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **samaccountname**      | The AD login name for the user             |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **directory_id**        | The ID in OneLogin of the Directory that   |
|                         | the user belongs to                        |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **external_id**         | An external identifier that has be set on  |
|                         | the user                                   |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **app_id**              | The ID of a OneLogin Application           |
|                         |                                            |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **user_ids**            | A comma separated list of OneLogin User    |
|                         | IDs                                        |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **custom_attrib         | The short name of a custom attribute. Note |
| utes.{attribute_name}** | that the attribute name is prefixed        |
|                         | with **custom_attributes.**                |
| string                  |                                            |
+-------------------------+--------------------------------------------+
| **fields**              | A comma separated list user attributes     |
|                         | to return.                                 |
| string                  |                                            |
|                         | e.g.                                       |
|                         |  id,firstname,lastname,profile_picture_url |
+-------------------------+--------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  400         Bad Request               **-**

  401         Unauthorized              **-**

  422         Unprocessable Entity      **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var listUser = await client.ListUsers();

listUser.Data\[0\]

{OneLogin.Responses.ListUserResponse}

ActivatedAt: {12/18/2024 2:45:19 PM}

CreatedAt: {12/18/2024 2:45:20 PM}

DirectoryId: null

DistinguishedName: null

Email: \"roma.rathi@accolitedigital.com\"

ExternalId: null

FirstName: \"Roma\"

GroupId: null

Id: 245015075

InvalidLoginAttempts: 0

InvitationSentAt: {12/18/2024 2:45:19 PM}

LastLogin: {2/10/2025 3:35:35 PM}

LastName: \"Rathi\"

LockedUntil: null

MemberOf: null

PasswordChangedAt: {12/18/2024 2:46:46 PM}

Phone: \"+917696102933\"

PreferredLocaleCode: null

SamAccountName: null

UpdatedAt: {2/10/2025 3:43:59 PM}

UserName: \"\"

UserPrincipalName: null

**Error Response**

listUser.Status

{OneLogin.Responses.BaseErrorResponse}

Field: \"fisrtName\"

Message: \"Invalid display field(s) for User: fisrtName\"

Name: \"UnprocessableEntityFieldError\"

StatusCode: 422

**Method**

get_user

**Endpoint**

**GET** /api/2/users/:id

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the user that you want to return.       |
| (**       |                                                          |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var getUser = await client.GetUserById(id)

getUser.Data

{OneLogin.Responses.GetUserResponse}

ActivatedAt: null

Comment: \"New user\"

Company: \"Acme Corp\"

CreatedAt: {1/21/2025 6:50:51 AM}

CustomAttributes: Count = 1

Department: \"Engineering\"

DirectoryId: null

DistinguishedName: \"CN=John Doe,OU=Users,DC=example,DC=com\"

Email: \"johndoe@example.com\"

ExternalId: \"ext-id-123\"

FirstName: \"Tesr\"

GroupId: null

Id: 246572113

InvalidLoginAttempts: 0

InvitationSentAt: null

LastLogin: {1/27/2025 7:11:26 AM}

LastName: \"User\"

LockedUntil: null

ManagerAdId: null

ManagerUserId: null

MemberOf: \"EngineeringTeam\"

PasswordChangedAt: {1/27/2025 7:11:05 AM}

Phone: \"+12345692390\"

PreferredLocaleCode: \"en\"

RoleId: null

SamAccountName: \"johndoe_ad\"

State: Approved

Status: Unactivated

Title: \"Software Engineer\"

TrustedIdpId: 789

UpdatedAt: {2/10/2025 5:59:42 AM}

UserName: \"johndoe\"

UserPrincipalName: \"johndoe@company.com\"

**Error Response**

getUser.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

get_user_apps

**Endpoint**

**GET** /api/2/users/:id/apps

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the user that you want to return apps   |
| (**       | for.                                                     |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**Query Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+==========:+==========================================================+
| **i       | Defaults to \`false\`. When \`true\` get all apps that   |
| gnore_vis | are assigned to a user regardless of their portal        |
| ibility** | visibility setting.                                      |
|           |                                                          |
| boolean   |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var getUserApps = await client.GetUserApps(245015075);

getUserApps.Data\[0\]

{OneLogin.Responses.GetUserAppsResponse}

Extension: true

Iconurl:
\"https://cdn01.onelogin.com/images/icons/square/almanacFederalJudiciary/mobile_50.png?1463607258\"

Id: 3701577

LoginId: 2166884354

Name: \"Almanac of the Federal Judiciary\"

ProvisioningState: Unknown

**Error Response**

getUserApps.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

create_user

**Endpoint**

**POST** /api/2/users

**Query Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **m       | Controls how mappings will be applied to the user on     |
| appings** | creation.                                                |
|           |                                                          |
|           | Defaults to **async**.                                   |
|           |                                                          |
|           | **async**: Mappings run after the API returns a          |
|           | response\                                                |
|           | **sync**: Mappings run before the API returns a          |
|           | response\                                                |
|           | **disabled**: Mappings don't run for this user.          |
+-----------+----------------------------------------------------------+
| *         | Will passwords validate against the User Policy?         |
| *validate |                                                          |
| _policy** | Defaults to **true**.                                    |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  201         Created                   **-**

  400         Bad Request               **-**

  401         Unauthorized              

  422         Unprocessable Entity      **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var createUser = await client.CreateUser(createUserRequest);

createUser.Data

{OneLogin.Responses.GetUserResponse}

ActivatedAt: {2/11/2025 12:16:47 PM}

Comment: \"New user\"

Company: \"Acme Corp\"

CreatedAt: {2/11/2025 12:16:47 PM}

CustomAttributes: Count = 1

Department: \"Engineering\"

DirectoryId: null

DistinguishedName: \"CN=John Doe,OU=Users,DC=example,DC=com\"

Email: \"testjohndoe@examwple.com\"

ExternalId: \"ext-id-123\"

FirstName: \"John\"

GroupId: null

Id: 247075987

InvalidLoginAttempts: 0

InvitationSentAt: null

LastLogin: null

LastName: \"Doe\"

LockedUntil: null

ManagerAdId: null

ManagerUserId: null

MemberOf: \"EngineeringTeam\"

PasswordChangedAt: {2/11/2025 12:16:47 PM}

Phone: \"+1234567890\"

PreferredLocaleCode: \"en\"

RoleId: null

SamAccountName: \"johndoe_ad\"

State: Approved

Status: ActiveOnly

Title: \"Software Engineer\"

TrustedIdpId: 789

UpdatedAt: {2/11/2025 12:16:47 PM}

UserName: \"testjohndoe\"

UserPrincipalName: \"johndoe@examwple.com\"

**Error Response**

createUser.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Validation failed: Email must be unique within romarathi,
Username must be unique within romarathi\"

Name: \"UnprocessableEntityError\"

StatusCode: 422

**Method**

update_user

**Endpoint**

**PUT** /api/2/users/:id

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the user that you want to update.       |
| (**       |                                                          |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**Query Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **m       | Controls how mappings will be applied to the user on     |
| appings** | update.                                                  |
|           |                                                          |
|           | Defaults to **async**                                    |
|           |                                                          |
|           | **async**: Mappings will be run after the API returns a  |
|           | response\                                                |
|           | **sync**: Mappings will be run before the API returns a  |
|           | response\                                                |
|           | **disabled**: Mappings will not be run for this user     |
+-----------+----------------------------------------------------------+
| *         | Will passwords be validated against the User Policy?     |
| *validate |                                                          |
| _policy** | Defaults to **true**                                     |
+-----------+----------------------------------------------------------+

**Request Parameters**

+----------------+-----+-----------------------------------------------+
| Name           | T   | Description                                   |
|                | ype |                                               |
+================+=====+===============================================+
| **username**   | str | A username for the user                       |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **email**      | str | A valid email for the user                    |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **firstname**  | str | The users first name                          |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **lastname**   | str | The users last name                           |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **password**   | str | The password to set for a user.               |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **password_    | str | Required if the password is being set         |
| confirmation** | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **passwo       | str | Use this when importing a password has        |
| rd_algorithm** | ing | already been hashed.                          |
|                |     |                                               |
|                |     | **salt+sha256 or sha256+salt**\               |
|                |     | Set to the password value using a             |
|                |     | SHA-256-encoded value.\                       |
|                |     | If you are including your own salt value in   |
|                |     | your request, prepend the salt value to the   |
|                |     | cleartext password value before               |
|                |     | SHA-256-encoding it.\                         |
|                |     | \                                             |
|                |     | *For example, if your salt value              |
|                |     | is **hello** and your cleartext password      |
|                |     | value is **password**, the value you need to  |
|                |     | SHA-256-encode is **hellopassword**. The      |
|                |     | resulting encoded value would be\             |
|                |     | 9fb8dc1cdabee85d13f5b                         |
|                |     | 4ba680a5e71cb8c80e78e5ffe8c01b698fa39346006.* |
|                |     |                                               |
|                |     | **b​crypt**\                                   |
|                |     | Set to the password value using a             |
|                |     | bcrypt-encoded value that produces a bcrypt   |
|                |     | hash with **\$2a** at the beginning. We       |
|                |     | currently only support bcrypt values that     |
|                |     | begin with **\$2a**.                          |
+----------------+-----+-----------------------------------------------+
| **salt**       | str | The salt value that was used with the         |
|                | ing | password_algorithm.                           |
+----------------+-----+-----------------------------------------------+
| **title**      | str | The users job title                           |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **department** | str | The users department                          |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **company**    | str | The company the user belongs to               |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **comment**    | str | Free text related to the user                 |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **group_id**   | i   | The ID of the Group in OneLogin that the user |
|                | nte | will be assigned to                           |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **role_ids**   | ar  | A list of OneLogin Role IDs the user will be  |
|                | ray | assigned to.                                  |
+----------------+-----+-----------------------------------------------+
| **phone**      | str | The [E.164                                    |
|                | ing | forma                                         |
|                |     | t](https://en.wikipedia.org/wiki/E.164) phone |
|                |     | number for a user.                            |
+----------------+-----+-----------------------------------------------+
| **state**      | i   | 0: Unapproved\                                |
|                | nte | 1: Approved\                                  |
|                | ger | 2: Rejected\                                  |
|                |     | 3: Unlicensed                                 |
+----------------+-----+-----------------------------------------------+
| **status**     | i   | 0: Unactivated\                               |
|                | nte | 1: Active\                                    |
|                | ger | 2: Suspended\                                 |
|                |     | 3: Locked\                                    |
|                |     | 4: Password expired\                          |
|                |     | 5: Awaiting password reset\                   |
|                |     | 7: Password Pending\                          |
|                |     | 8: Security questions required                |
+----------------+-----+-----------------------------------------------+
| **             | i   | The ID of the OneLogin Directory the user     |
| directory_id** | nte | will be assigned to                           |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **tr           | i   | The ID of the OneLogin Trusted IDP the user   |
| usted_idp_id** | nte | will be assigned to                           |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **m            | i   | The ID of the users manager in Active         |
| anager_ad_id** | nte | Directory                                     |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **man          | i   | The OneLogin User ID of the users manager     |
| ager_user_id** | nte |                                               |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **sa           | str | The users Active Directory username           |
| maccountname** | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **member_of**  | str | The users directory membership                |
|                | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **userp        | str | The principle name of the user                |
| rincipalname** | ing |                                               |
+----------------+-----+-----------------------------------------------+
| **distin       | str | The distinguished name of the user            |
| guished_name** | ing |                                               |
+----------------+-----+-----------------------------------------------+
| *              | str | The ID of the user in an external directory   |
| *external_id** | ing |                                               |
+----------------+-----+-----------------------------------------------+
| *              | str | The name configured for use in other          |
| *openid_name** | ing | applications that accept OpenID for sign-in.  |
+----------------+-----+-----------------------------------------------+
| **invalid_lo   | i   | The number of sequential invalid login        |
| gin_attempts** | nte | attempts the user has made.                   |
|                | ger |                                               |
+----------------+-----+-----------------------------------------------+
| **preferred    | str | The 2-character language locale for the user, |
| _locale_code** | ing | such as en for English or es for Spanish.     |
+----------------+-----+-----------------------------------------------+
| **custo        | obj | An object to contain any other custom         |
| m_attributes** | ect | attributes you have configured.               |
+----------------+-----+-----------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  400         Bad Request               **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**

  422         Unprocessable Entity      
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var updateUser = await client.UpdateUserById(245015075, newUserRequest);

updateUser.Data

{OneLogin.Responses.GetUserResponse}

ActivatedAt: {2/11/2025 12:16:47 PM}

Comment: \"New user\"

Company: \"Acme Corp\"

CreatedAt: {2/11/2025 12:16:47 PM}

CustomAttributes: Count = 1

Department: \"Engineering\"

DirectoryId: null

DistinguishedName: \"CN=John Doe,OU=Users,DC=example,DC=com\"

Email: \"username@example.com\"

ExternalId: \"ext-id-123\"

FirstName: \"Tesr\"

GroupId: null

Id: 247075987

InvalidLoginAttempts: 0

InvitationSentAt: null

LastLogin: null

LastName: \"User\"

LockedUntil: null

ManagerAdId: null

ManagerUserId: null

MemberOf: \"EngineeringTeam\"

PasswordChangedAt: {2/11/2025 12:16:47 PM}

Phone: \"+12345692390\"

PreferredLocaleCode: \"en\"

RoleId: null

SamAccountName: \"johndoe_ad\"

State: Approved

Status: ActiveOnly

Title: \"Software Engineer\"

TrustedIdpId: 789

UpdatedAt: {2/11/2025 12:18:13 PM}

UserName: \"usernae\"

UserPrincipalName: \"johndoe@examwple.com\"

**Error Response**

updateUser.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Validation failed: cannot modify Account owner\"

Name: \"UnprocessableEntityError\"

StatusCode: 422

**Method**

delete_user

**Endpoint**

**DEL** /api/2/users/:id

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the user that you want to delete.       |
| (**       |                                                          |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  204         No Content                **-**

  401         Unauthorized              

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var deleteUser = await client.DeleteUserById(1);

DeleteUser.Data = null

**Error Response**

deleteUser.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

list_custom_attributes

**Endpoint**

**GET** /api/2/users/custom_attributes

**Parameters**

This endpoint does not need any parameter.

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  400         Bad Request               **-**

  401         Unauthorized              **-**

  422         Unprocessable Entity      **-**
  -----------------------------------------------------------------------

**Example:**

**Success Response**

var listCustomAttributes = await client.ListCustomAttributes();

{OneLogin.Responses.GetCustomAttributesResponse}

Id: 106606

Name: \"Custom7 Field\"

Position: null

Shortname: \"custom7field\"

listCustomField.Data\[0\]

{OneLogin.Responses.GetCustomAttributesResponse}

Id: 106606

Name: \"Custom7 Field\"

Position: null

Shortname: \"custom7field\"

**Method**

get_custom_attribute

**Endpoint**

**GET** /api/2/custom_attributes/:id

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the custom attribute that you want      |
| (**       | to return.                                               |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var getCustomAttributes = await client.GetCustomAttribute(106606);

{OneLogin.Responses.GetCustomAttributesResponse}

Id: 106606

Name: \"Custom7 Field\"

Position: null

Shortname: \"custom7field\"

**Error Response**

getCustomField.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Shortname has already been taken\"

Name: \"BadRequestError\"

StatusCode: 400

**Method**

create_custom_attribute

**Endpoint**

**POST** /api/2/custom_attributes

**Request Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **Name           | A descriptive name for the custom field.          |
| (**required)     |                                                   |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+
| **Shortname**    | A unique identifier for the custom field.         |
| (required)       |                                                   |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  400         Bad Request               **-**

  401         Unauthorized              **-**

  422         Unprocessable Entity      **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var createCustomAttributes = await
client.CreateCustomAttribute(customFieldResponse);

{OneLogin.Responses.GetCustomAttributesResponse}

Id: 106606

Name: \"Custom7 Field\"

Position: null

Shortname: \"custom7field\"

**Error Response**

createCustomAttributes.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

update_custom_attribute

**Endpoint**

**PUT** /api/2/custom_attributes/:id

**Resource Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **id      | Set to the id of the custom attribute that you want to   |
| (**       | update                                                   |
| required) |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+

**Request Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **Name           | A descriptive name for the custom field.          |
| (**required)     |                                                   |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+
| **Shortname**    | A unique identifier for the custom field.         |
| (required)       |                                                   |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var updateCustomAttributes = await
client.UpdateCustomAttributeValue(106606, customFieldResponse);

{OneLogin.Responses.GetCustomAttributesResponse}

Id: 106606

Name: \"Custom7 Field\"

Position: null

Shortname: \"custom7field\"

**Error Response**

updateCustomField.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

delete_custom_attribute

**Endpoint**

**DEL** /api/2/custom_attributes/:id

**Resource Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **id**           | Set to the id of the custom attribute that you    |
| (required)       | want to delete.                                   |
|                  |                                                   |
| integer          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  204         No Content                **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var deleteCustomAttributes = await client.DeleteCustomAttributeById(1);

deleteCustomField.Data

null

**Error Response**

deleteCustomField.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

2.  **[Roles]{.underline}**

**Method**

get_role

**Endpoint**

**GET** /api/2/roles/:id

**Resource Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **id**           | Set to the id of the role you want to return.     |
| (required)       |                                                   |
|                  |                                                   |
| integer          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         SAML                      **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var getRole = await client.GetRole(791332)

getRole.Data

{OneLogin.Responses.GetRoleResponse}

Admins: Count = 1

Apps: Count = 2

Id: 791332

Name: \"updaterole\"

Users: Count = 1

**Error Response**

getRole.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"The resource with the given id could not be found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

list_roles

**Endpoint**

**GET** /api/2/roles

**Query Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **name**  | Optional. Filters by role name.                          |
|           |                                                          |
| string    |                                                          |
+-----------+----------------------------------------------------------+
| *         | Optional. Returns roles that contain this app ID.        |
| *app_id** |                                                          |
|           |                                                          |
| integer   |                                                          |
+-----------+----------------------------------------------------------+
| **a       | Optional. Returns roles that contain this app name.      |
| pp_name** |                                                          |
|           |                                                          |
| string    |                                                          |
+-----------+----------------------------------------------------------+
| *         | Optional. Comma delimited list of fields to return.      |
| *fields** |                                                          |
|           | Valid options are apps, users, admins.                   |
| string    |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var listRoles = await client.ListRoles();

listRoles.Data\[0\] (Success Response)

{OneLogin.Responses.GetRoleResponse}

Admins: Count = 1

Apps: Count = 2

Id: 791332

Name: \"updaterole\"

Users: Count = 1

**Error Response**

listRoles.Status

{OneLogin.Responses.BaseErrorResponse}

Field: \"fisrtName\"

Message: \"Invalid display field(s) for User: fisrtName\"

Name: \"UnprocessableEntityFieldError\"

StatusCode: 422

**Method**

create_roles

**Endpoint**

**POST** /api/2/roles

**Request Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **name**( | The name of the role.                                    |
| required) |                                                          |
|           |                                                          |
| string    |                                                          |
+-----------+----------------------------------------------------------+
| **apps**  | A list of app IDs that will be assigned to the role.     |
|           |                                                          |
| array     | E.g. \[234, 567, 777\]                                   |
+-----------+----------------------------------------------------------+
| **users** | A list of user IDs to assign to the role.                |
|           |                                                          |
| array     |                                                          |
+-----------+----------------------------------------------------------+
| *         | A list of user IDs to assign as role administrators.     |
| *admins** |                                                          |
|           |                                                          |
| array     |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  201         Created                   **-**

  401         Unauthorized              
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

createRole.Data

{OneLogin.Responses.GetIdResponse}

Id: 804158

**Error Response**

createRole.Status

null

**Method**

update_role

**Endpoint**

**PUT** /api/2/roles/:id

**Request Parameters**

+-----------+----------------------------------------------------------+
| Name/Type | Description                                              |
+===========+==========================================================+
| **name**( | Name of the role to be updated                           |
| required) |                                                          |
|           |                                                          |
| string    |                                                          |
+-----------+----------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              

  422         Unprocessable Entity      
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

{OneLogin.Responses.GetIdResponse}

Id: 791332

**Error Response**

updateRole.Status

null

**Method**

delete_role

**Endpoint**

**DEL** /api/2/roles/:id

**Resource Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **id**           | Set to the id of the role you want to delete.     |
| (required)       |                                                   |
|                  |                                                   |
| integer          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  204         No Content                **-**

  401         Unauthorized              

  404         Not Found                 
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

deleteRole.Data

null

**Error Response**

deleteRole.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Resource not found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

list_role_apps

**Endpoint**

**GET** /api/2/roles/:id/apps

**Request Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **assigned**     | Optional. Defaults to true. Returns all apps not  |
|                  | yet assigned to the role.                         |
| boolean          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var listRoleApps = await client.ListRoleApps(791332,
GetRoleAppsRequest);

listRoleApps.Data\[0\](Success Response)

{OneLogin.Responses.GetRoleAppsResponse}

IconUrl:
\"https://cdn01.onelogin.com/images/icons/square/google_apps/original.png?1475190219\"

Id: 3713247

Name: \"G Suite\"

**Error Response**

listRoleApps.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Not authorized\"

Name: \"UnauthorizedError\"

StatusCode: 401

**Method**

set_role_apps

**Endpoint**

**PUT** /api/2/roles/:id/apps

**Request Parameters**

+-------------+--------------------------------------------------------+
| Name/Type   | Description                                            |
+=============+========================================================+
| **app_id**  | The complete list of app_id values to assign to the    |
| (required)  | role. To add or remove additional apps, submit the     |
|             | complete list in your request. Don't submit a partial  |
| array       | list of app IDs, to add or remove, in your request.    |
+-------------+--------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              

  404         Not Found                 
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var setroleApps = await client.SetRoleApps(791332, apps)

setroleApps.Data\[0\]

**Error Response**

setroleApps.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Invalid id(s): 1, 2, 3\"

Name: \"BadRequestError\"

StatusCode: 400

**Method**

list_role_users

**Endpoint**

**GET** /api/2/roles/:id/users

**Request Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **name**         | Allows you to filter on first name, last          |
| (required)       | name, username, and email address.                |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+
| **incl           | Optional. Defaults to false. Include users that   |
| ude_unassigned** | aren't assigned to the role.                      |
|                  |                                                   |
| boolean          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var listRoleUsers = await client.ListRoleUsers(791332);

listRoleUsers.Data\[0\] (Success Response)

{OneLogin.Responses.GetRoleUsersAdminResponse}

AddedAt: {2/19/2025 11:13:23 AM}

AddedBy: {OneLogin.Responses.AddedByUser}

Assigned: true

Email: \"roma.rathi@accolitedigital.com\"

Id: 245015075

Name: \"Roma Rathi\"

Username: \"\"

**Error Response**

listRoleUsers.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Resource not found\"

Name: \"NotFoundError\"

StatusCode: 404

**Method**

add_role_users

**Endpoint**

**POST** /api/2/roles/:id/users

**Request Parameters**

+--------------+-------------------------------------------------------+
| Name/Type    | Description                                           |
+==============+=======================================================+
| **user_id**  | Set user_id values in array, for example: \[123,      |
| (required)   | 456, 678\]                                            |
|              |                                                       |
| array        |                                                       |
+--------------+-------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  401         Unauthorized              **-**

  422         Unprocessable Entity      **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var AddRoleUsers = await client.AddRoleUsers(791332, apps);

AddRoleUser (Success Response)

AddRoleUsers.Data\[0\]

**Error Response**

AddRoleUsers.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Invalid id(s): 1, 2, 3\"

Name: \"BadRequestError\"

StatusCode: 400

**Method**

delete_role_users

**Endpoint**

**DEL** /api/2/roles/:id/users

**Request Parameters**

+--------------+-------------------------------------------------------+
| Name/Type    | Description                                           |
+==============+=======================================================+
| **user_id**  | Set user_id values in array, for example: \[123,      |
| (required)   | 456, 678\]                                            |
|              |                                                       |
| array        |                                                       |
+--------------+-------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  204         No Content                **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var deleteRoleUsers = await client.DeleteRoleUsers(791332, apps);

deleteRoleUser (Success Response)

deleteRoleUsers.Data

null

**Error Response**

deleteRoleUsers.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Invalid id(s): 1, 2, 3\"

Name: \"BadRequestError\"

StatusCode: 400

**Method**

list_role_admins

**Endpoint**

**GET** /api/2/roles/:id/admins

**Request Parameters**

+------------------+---------------------------------------------------+
| Name/Type        | Description                                       |
+==================+===================================================+
| **name**         | Filters on first name, last name, username, and   |
| (required)       | email address.                                    |
|                  |                                                   |
| string           |                                                   |
+------------------+---------------------------------------------------+
| **incl           | Optional. Include admins that aren't assigned to  |
| ude_unassigned** | the role.                                         |
|                  |                                                   |
| boolean          |                                                   |
+------------------+---------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Success                   **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var listRoleAdmin = await client.ListRoleAdmins(791332,
\"updatedrole\");

listRoleAdmin (Success Response)

listRoleAdmin.Data\[0\]

**Error Response**

listRoleAdmin.Status

null

**Method**

add_role_admins

**Endpoint**

**POST** /api/2/roles/:id/admins

**Request Parameters**

+--------------+-------------------------------------------------------+
| Name/Type    | Description                                           |
+==============+=======================================================+
| **user_id**  | Set user_id values in array, for example: \[123,      |
| (required)   | 456, 678\]                                            |
|              |                                                       |
| array        |                                                       |
+--------------+-------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  200         Successful response       **-**

  401         Unauthorized              **-**
  -----------------------------------------------------------------------

**Method**

delete_role_admins

**Endpoint**

**DEL** /api/2/roles/:id/admins

**Request Parameters**

+--------------+-------------------------------------------------------+
| Name/Type    | Description                                           |
+==============+=======================================================+
| **user_id**  | Set user_id values in array, for example: \[123,      |
| (required)   | 456, 678\]                                            |
|              |                                                       |
| array        |                                                       |
+--------------+-------------------------------------------------------+

**HTTP request headers**

**Content-Type:** not defined (recommended: application/json;
charset=utf-8)

**Accept:** application/json

**HTTP response details**

  -----------------------------------------------------------------------
  **Status    **Description**           **Response Headers**
  Code**                                
  ----------- ------------------------- ---------------------------------
  204         No Content                **-**

  401         Unauthorized              **-**

  404         Not Found                 **-**
  -----------------------------------------------------------------------

**Examples:**

**Success Response**

var deleteRoleAdmin = await client.DeleteRoleAdmins(791332, apps);

deleteRoleAdmin.Data(Success Response)

null

**Error Response**

deleteRoleAdmin.Status

{OneLogin.Responses.BaseErrorResponse}

Field: null

Message: \"Invalid id(s): 1, 2, 3\"

Name: \"BadRequestError\"

StatusCode: 400
