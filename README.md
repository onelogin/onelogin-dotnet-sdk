# onelogin-dotnet-sdk
OneLogin Ruby Library (NuGet)
Introduction
This is a portable library for consuming the OneLogin REST-API in (almost) any C# application. This SDK will let you execute all the API methods in version/2. Link
The toolkit is hosted on GitHub. You can download it from:
•	Latest release:  Link
•	Master repo:  Link

Installation
The OneLogin is avaiable through NuGet:
> Install-Package OneLogin

Supported Platforms
OneLogin API is built on top of the new .NET Standard targeting netstandard versions 8- therefore it should work on the following plaforms:
•	.NET Framework 8 and newer
•	Universal Windows Platform (uap)
•	Windows 8.0 and newer
•	Windows Phone (WinRT, not Silverlight)
•	Mono / Xamarin

Dependencies
To Add

Getting started
You'll need a OneLogin account and a set of API credentials before you get started.
client_id	Required: A valid OneLogin API client_id
client_secret	Required: A valid OneLogin API client_secret
region	Optional: us or eu. Defaults to us

Using the API Wrapper
// Initialize
var client = new OneLoginClient("Your Onelogin client id", "Your Onelogin client secret");
That's it! The token will be generated and managed for you by the OneLoginClient.
 
// Users
var userResponse = await _oneLoginClient.GetUserById(userId);
var userAppsResponse = await _oneLoginClient.GetAppsForUser(userId);
Usage
Errors and Exceptions
OneLogin's API can return 400, 401, 403 or 404 when there was any issue executing the action. 

Code:

Authentication
By default methods call internally to get_access_token if there is no valid access_token. You can also get tokens etc directly if needed.

# Get an AccessToken
token = client.get_access_token

# Refresh an AccessToken
token2 = client.regenerate_token

# Revoke an AccessToken
token3 = client.get_access_token

Methods and Examples
1.	 Users

Method
list_users
Endpoint
GET /api/2/users
Query Parameters
Name/Type	Description 
created_since
string	An ISO8601 timestamp value that returns all users created after a given date & time. e.g. 2020-07-01T20:38:24Z
created_until
string	An ISO8601 timestamp value that returns all users created before a given date & time.
updated_since
string	An ISO8601 timestamp value that returns all users updated after a given date & time.
updated_until
string	An ISO8601 timestamp value that returns all users updated before a given date & time.
last_login_since
string	An ISO8601 timestamp value that returns all users that logged in after a given date & time.
last_login_until
string	An ISO8601 timestamp value that returns all users that logged in before a given date & time.
firstname
string	The first name of the user
lastname
string	The last name of the user
email
string	The email address of the user
username
string	The username for the user
samaccountname
string	The AD login name for the user
directory_id
string	The ID in OneLogin of the Directory that the user belongs to
external_id
string	An external identifier that has be set on the user
app_id
string	The ID of a OneLogin Application
user_ids
string	A comma separated list of OneLogin User IDs
custom_attributes.{attribute_name}
string	The short name of a custom attribute. Note that the attribute name is prefixed with custom_attributes.
fields
string	A comma separated list user attributes to return.
e.g. id,firstname,lastname,profile_picture_url

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
400	Bad Request	-
401	Unauthorized	-
422	Unprocessable Entity	-

Examples:
 Success Response
var listUser = await client.ListUsers();
listUser.Data[0]
{OneLogin.Responses.ListUserResponse}
    ActivatedAt: {12/18/2024 2:45:19 PM}
    CreatedAt: {12/18/2024 2:45:20 PM}
    DirectoryId: null
    DistinguishedName: null
    Email: "roma.rathi@accolitedigital.com"
    ExternalId: null
    FirstName: "Roma"
    GroupId: null
    Id: 245015075
    InvalidLoginAttempts: 0
    InvitationSentAt: {12/18/2024 2:45:19 PM}
    LastLogin: {2/10/2025 3:35:35 PM}
    LastName: "Rathi"
    LockedUntil: null
    MemberOf: null
    PasswordChangedAt: {12/18/2024 2:46:46 PM}
    Phone: "+917696102933"
    PreferredLocaleCode: null
    SamAccountName: null
    UpdatedAt: {2/10/2025 3:43:59 PM}
    UserName: ""
    UserPrincipalName: null

Error Response
listUser.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: "fisrtName"
    Message: "Invalid display field(s) for User: fisrtName"
    Name: "UnprocessableEntityFieldError"
    StatusCode: 422

Method
get_user
Endpoint
GET /api/2/users/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the user that you want to return.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
401	Unauthorized	-
404	Not Found	-

Examples:
Success Response
var getUser = await client.GetUserById(id)
getUser.Data
{OneLogin.Responses.GetUserResponse}
    ActivatedAt: null
    Comment: "New user"
    Company: "Acme Corp"
    CreatedAt: {1/21/2025 6:50:51 AM}
    CustomAttributes: Count = 1
    Department: "Engineering"
    DirectoryId: null
    DistinguishedName: "CN=John Doe,OU=Users,DC=example,DC=com"
    Email: "johndoe@example.com"
    ExternalId: "ext-id-123"
    FirstName: "Tesr"
    GroupId: null
    Id: 246572113
    InvalidLoginAttempts: 0
    InvitationSentAt: null
    LastLogin: {1/27/2025 7:11:26 AM}
    LastName: "User"
    LockedUntil: null
    ManagerAdId: null
    ManagerUserId: null
    MemberOf: "EngineeringTeam"
    PasswordChangedAt: {1/27/2025 7:11:05 AM}
    Phone: "+12345692390"
    PreferredLocaleCode: "en"
    RoleId: null
    SamAccountName: "johndoe_ad"
    State: Approved
    Status: Unactivated
    Title: "Software Engineer"
    TrustedIdpId: 789
    UpdatedAt: {2/10/2025 5:59:42 AM}
    UserName: "johndoe"
    UserPrincipalName: "johndoe@company.com"
	
Error Response
getUser.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

Method
get_user_apps
Endpoint
GET /api/2/users/:id/apps
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the user that you want to return apps for.

Query Parameters
Name/Type	Description 
ignore_visibility
boolean	Defaults to `false`. When `true` get all apps that are assigned to a user regardless of their portal visibility setting.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	SAML	-
401	Unauthorized	-
404	Not Found	-

Examples:
Success Response
var getUserApps = await client.GetUserApps(245015075);
getUserApps.Data[0]
{OneLogin.Responses.GetUserAppsResponse}
    Extension: true
    Iconurl: "https://cdn01.onelogin.com/images/icons/square/almanacFederalJudiciary/mobile_50.png?1463607258"
    Id: 3701577
    LoginId: 2166884354
    Name: "Almanac of the Federal Judiciary"
    ProvisioningState: Unknown

Error Response
getUserApps.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

Method
create_user
Endpoint
POST /api/2/users
Query Parameters
Name/Type	Description 
mappings	Controls how mappings will be applied to the user on creation.
Defaults to async.
async: Mappings run after the API returns a response
sync: Mappings run before the API returns a response
disabled: Mappings don’t run for this user.
validate_policy	Will passwords validate against the User Policy?
Defaults to true.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
201	Created	-
400	Bad Request	-
401	Unauthorized	
422	Unprocessable Entity	-

Examples:
Success Response
var createUser = await client.CreateUser(createUserRequest);
createUser.Data
{OneLogin.Responses.GetUserResponse}
    ActivatedAt: {2/11/2025 12:16:47 PM}
    Comment: "New user"
    Company: "Acme Corp"
    CreatedAt: {2/11/2025 12:16:47 PM}
    CustomAttributes: Count = 1
    Department: "Engineering"
    DirectoryId: null
    DistinguishedName: "CN=John Doe,OU=Users,DC=example,DC=com"
    Email: "testjohndoe@examwple.com"
    ExternalId: "ext-id-123"
    FirstName: "John"
    GroupId: null
    Id: 247075987
    InvalidLoginAttempts: 0
    InvitationSentAt: null
    LastLogin: null
    LastName: "Doe"
    LockedUntil: null
    ManagerAdId: null
    ManagerUserId: null
    MemberOf: "EngineeringTeam"
    PasswordChangedAt: {2/11/2025 12:16:47 PM}
    Phone: "+1234567890"
    PreferredLocaleCode: "en"
    RoleId: null
    SamAccountName: "johndoe_ad"
    State: Approved
    Status: ActiveOnly
    Title: "Software Engineer"
    TrustedIdpId: 789
    UpdatedAt: {2/11/2025 12:16:47 PM}
    UserName: "testjohndoe"
    UserPrincipalName: "johndoe@examwple.com"
	
Error Response
createUser.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "Validation failed: Email must be unique within romarathi, Username must be unique within romarathi"
    Name: "UnprocessableEntityError"
    StatusCode: 422

Method
update_user
Endpoint
PUT /api/2/users/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the user that you want to update.

Query Parameters
Name/Type	Description 
mappings	Controls how mappings will be applied to the user on update.
Defaults to async
async: Mappings will be run after the API returns a response
sync: Mappings will be run before the API returns a response
disabled: Mappings will not be run for this user
validate_policy	Will passwords be validated against the User Policy?
Defaults to true

Request Parameters
Name	Type	Description 
username	string	A username for the user
email	string	A valid email for the user
firstname	string	The users first name
lastname	string	The users last name
password	string	The password to set for a user.
password_confirmation	string	Required if the password is being set
password_algorithm	string	Use this when importing a password has already been hashed.


salt+sha256 or sha256+salt
Set to the password value using a SHA-256-encoded value.
If you are including your own salt value in your request, prepend the salt value to the cleartext password value before SHA-256-encoding it.

For example, if your salt value is hello and your cleartext password value is password, the value you need to SHA-256-encode is hellopassword. The resulting encoded value would be
9fb8dc1cdabee85d13f5b4ba680a5e71cb8c80e78e5ffe8c01b698fa39346006.
bcrypt
Set to the password value using a bcrypt-encoded value that produces a bcrypt hash with $2a at the beginning. We currently only support bcrypt values that begin with $2a.
salt	string	The salt value that was used with the password_algorithm.
title	string	The users job title
department	string	The users department
company	string	The company the user belongs to
comment	string	Free text related to the user
group_id	integer	The ID of the Group in OneLogin that the user will be assigned to
role_ids	array	A list of OneLogin Role IDs the user will be assigned to.
phone	string	The E.164 format phone number for a user.

state	integer	0: Unapproved
1: Approved
2: Rejected
3: Unlicensed
status	integer	0: Unactivated
1: Active
2: Suspended
3: Locked
4: Password expired
5: Awaiting password reset
7: Password Pending
8: Security questions required
directory_id	integer	The ID of the OneLogin Directory the user will be assigned to
trusted_idp_id	integer	The ID of the OneLogin Trusted IDP the user will be assigned to
manager_ad_id	integer	The ID of the users manager in Active Directory
manager_user_id	integer	The OneLogin User ID of the users manager
samaccountname	string	The users Active Directory username
member_of	string	The users directory membership
userprincipalname	string	The principle name of the user
distinguished_name	string	The distinguished name of the user
external_id	string	The ID of the user in an external directory
openid_name	string	The name configured for use in other applications that accept OpenID for sign-in.
invalid_login_attempts	integer	The number of sequential invalid login attempts the user has made.
preferred_locale_code	string	The 2-character language locale for the user, such as en for English or es for Spanish.
custom_attributes	object	An object to contain any other custom attributes you have configured.



HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
400	Bad Request	-
401	Unauthorized	-
404	Not Found	-
422	Unprocessable Entity	

Examples:
Success Response
var updateUser = await client.UpdateUserById(245015075, newUserRequest);
updateUser.Data
{OneLogin.Responses.GetUserResponse}
    ActivatedAt: {2/11/2025 12:16:47 PM}
    Comment: "New user"
    Company: "Acme Corp"
    CreatedAt: {2/11/2025 12:16:47 PM}
    CustomAttributes: Count = 1
    Department: "Engineering"
    DirectoryId: null
    DistinguishedName: "CN=John Doe,OU=Users,DC=example,DC=com"
    Email: "username@example.com"
    ExternalId: "ext-id-123"
    FirstName: "Tesr"
    GroupId: null
    Id: 247075987
    InvalidLoginAttempts: 0
    InvitationSentAt: null
    LastLogin: null
    LastName: "User"
    LockedUntil: null
    ManagerAdId: null
    ManagerUserId: null
    MemberOf: "EngineeringTeam"
    PasswordChangedAt: {2/11/2025 12:16:47 PM}
    Phone: "+12345692390"
    PreferredLocaleCode: "en"
    RoleId: null
    SamAccountName: "johndoe_ad"
    State: Approved
    Status: ActiveOnly
    Title: "Software Engineer"
    TrustedIdpId: 789
    UpdatedAt: {2/11/2025 12:18:13 PM}
    UserName: "usernae"
    UserPrincipalName: "johndoe@examwple.com"
	
Error Response
updateUser.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "Validation failed: cannot modify Account owner"
    Name: "UnprocessableEntityError"
    StatusCode: 422

Method
delete_user
Endpoint
DEL /api/2/users/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the user that you want to delete.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
204	No Content	-
401	Unauthorized	
404	Not Found	-

Examples:
Success Response
var deleteUser = await client.DeleteUserById(1);
DeleteUser.Data = null
	
Error Response
deleteUser.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

Method
list_custom_attributes
Endpoint
GET /api/2/users/custom_attributes
Parameters
This endpoint does not need any parameter.
HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
400	Bad Request	-
401	Unauthorized	-
422	Unprocessable Entity	-

Example:
Success Response
var listCustomAttributes = await client.ListCustomAttributes();
{OneLogin.Responses.GetCustomAttributesResponse}
    Id: 106606
    Name: "Custom7 Field"
    Position: null
    Shortname: "custom7field"
listCustomField.Data[0]
{OneLogin.Responses.GetCustomAttributesResponse}
    Id: 106606
    Name: "Custom7 Field"
    Position: null
    Shortname: "custom7field"

Method
get_custom_attribute
Endpoint
GET /api/2/custom_attributes/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the custom attribute that you want to return.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
401	Unauthorized	-
404	Not Found	-

Examples:
Success Response
var getCustomAttributes = await client.GetCustomAttribute(106606);

{OneLogin.Responses.GetCustomAttributesResponse}
    Id: 106606
    Name: "Custom7 Field"
    Position: null
    Shortname: "custom7field"	
Error Response
getCustomField.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "Shortname has already been taken"
    Name: "BadRequestError"
    StatusCode: 400

Method
create_custom_attribute
Endpoint
POST /api/2/custom_attributes

Request Parameters
Name/Type	Description 
Name (required)
string	A descriptive name for the custom field.
Shortname (required)

string	A unique identifier for the custom field.


HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-
400	Bad Request	-
401	Unauthorized	-
422	Unprocessable Entity	-

Examples:
Success Response
var createCustomAttributes = await client.CreateCustomAttribute(customFieldResponse);
{OneLogin.Responses.GetCustomAttributesResponse}
    Id: 106606
    Name: "Custom7 Field"
    Position: null
    Shortname: "custom7field"	
Error Response
createCustomAttributes.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

Method
update_custom_attribute
Endpoint
PUT /api/2/custom_attributes/:id

Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the custom attribute that you want to update

Request Parameters
Name/Type	Description 
Name (required)
string	A descriptive name for the custom field.
Shortname (required)

string	A unique identifier for the custom field.


HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Successful response	-

Examples:
Success Response
var updateCustomAttributes = await client.UpdateCustomAttributeValue(106606, customFieldResponse);
{OneLogin.Responses.GetCustomAttributesResponse}
    Id: 106606
    Name: "Custom7 Field"
    Position: null
    Shortname: "custom7field"
	
Error Response
updateCustomField.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

Method
delete_custom_attribute
Endpoint
DEL /api/2/custom_attributes/:id

Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the custom attribute that you want to delete.


HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
204	No Content	-
401	Unauthorized	-
404	Not Found	-

Examples:
Success Response
var deleteCustomAttributes = await client.DeleteCustomAttributeById(1);
deleteCustomField.Data
null
	
Error Response
deleteCustomField.Status
{OneLogin.Responses.BaseErrorResponse}
    Field: null
    Message: "The resource with the given id could not be found"
    Name: "NotFoundError"
    StatusCode: 404

2.	Roles

Method
get_role
Endpoint
GET /api/2/roles/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the role you want to return.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	SAML	-
401	Unauthorized	-
404	Not Found	-

Examples:

Method
list_roles
Endpoint
GET /api/2/roles
Query Parameters
Name/Type	Description 
name
string	Optional. Filters by role name.
app_id
integer	Optional. Returns roles that contain this app ID.
app_name
string	Optional. Returns roles that contain this app name.
fields
string	Optional. Comma delimited list of fields to return.
Valid options are apps, users, admins.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	SAML	-
401	Unauthorized	-

Examples:

Method
create_roles
Endpoint
POST /api/2/roles
Request Parameters
Name/Type	Description 
name(required)
string	The name of the role.
apps
array	A list of app IDs that will be assigned to the role.
E.g. [234, 567, 777]
users
array	A list of user IDs to assign to the role.
admins
array	A list of user IDs to assign as role administrators.


HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
201	Created	-
401	Unauthorized	

Examples:

Method
update_role
Endpoint
PUT /api/2/roles/:id
Request Parameters
Name/Type	Description 
name(required)
string	Name of the role to be updated

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	Success	-
401	Unauthorized	
422	Unprocessable Entity	

Examples:

Method
delete_role
Endpoint
DEL /api/2/roles/:id
Resource Parameters
Name/Type	Description 
id (required)
integer	Set to the id of the role you want to delete.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
204	No Content	-
401	Unauthorized	
404	Not Found	

Examples:

Method
list_role_apps
Endpoint
GET /api/2/roles/:id/apps
Request Parameters
Name/Type	Description 
assigned
boolean	Optional. Defaults to true. Returns all apps not yet assigned to the role.

HTTP request headers
Content-Type: not defined (recommended: application/json; charset=utf-8)
Accept: application/json
HTTP response details
Status Code	Description	Response Headers
200	SAML	-
401	Unauthorized	-
404	Not Found	-

Example:





