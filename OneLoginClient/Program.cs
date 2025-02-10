// See https://aka.ms/new-console-template for more information

using OneLogin;

Console.WriteLine("Hello, World!");
var client = new OneLoginClient("e5c59046d306994e3cfcb7b7e7ca6b6d7d5e01b15b4686f4a9a698cd36be00f1", "c03cff3b6e0e54f71cc19b27660788f051ea6ecbfba3527fce9197d1f0bdf8c6");
var tokenResponse = await client.GenerateTokens();
Console.WriteLine(tokenResponse);
var createUserRequest = new CreateUserRequest
{
    Username = "johndoe",
    Email = "johndoe@example.com",
    Firstname = "John",
    Lastname = "Doe",
    Password = "SecurePassword123",
    PasswordConfirmation = "SecurePassword123",
    PasswordAlgorithm = "bcrypt",
    Salt = "randomsalt",
    Title = "Software Engineer",
    Department = "Engineering",
    Company = "Acme Corp",
    Comment = "New user",
    Phone = "+1234567890",
    State = 1, // Approved
    Status = 1, // Active   
    TrustedIdpId = 789,
    Samaccountname = "johndoe_AD",
    MemberOf = "EngineeringTeam",
    Userprincipalname = "johndoe@company.com",
    DistinguishedName = "CN=John Doe,OU=Users,DC=example,DC=com",
    ExternalId = "ext-id-123",
    OpenidName = "john_openid",
    InvalidLoginAttempts = 0,
    PreferredLocaleCode = "en"
};

var customFieldResponse = new CreateCustomAttributesRequest
{
    UserField = new UserField
    {
        Name = "Custom7 Field",
        Shortname = "custom7field"
    }
};

var newUserRequest = new UpdateUserByIdRequest
{
    Username = "johndoe",
    Email = "johndoe@example.com",
    Firstname = "Tesr",
    Lastname = "User",
    Password = "SecurePassword123",
    PasswordConfirmation = "SecurePassword123",
    PasswordAlgorithm = "bcrypt",
    Salt = "randomsalt",
    Title = "Software Engineer",
    Department = "Engineering",
    Company = "Acme Corp",
    Comment = "New user",
    Phone = "+12345692390",
    State = 1,  // Approved
    Status = 1, // Active
    TrustedIdpId = 789,
    Samaccountname = "johndoe_AD",
    MemberOf = "EngineeringTeam",
    Userprincipalname = "johndoe@company.com",
    DistinguishedName = "CN=John Doe,OU=Users,DC=example,DC=com",
    ExternalId = "ext-id-123",
    OpenidName = "john_openid",
    InvalidLoginAttempts = 0,
    PreferredLocaleCode = "en"
};

//var roleRequest = new RoleRequest
//{
//    Name = "AdminRoleUpdated",
//    Apps = new List<int> { 3725441, 3713247 },
//    Users = new List<int> { 245015075 },
//    Admins = new List<int> { 245015075 }
//};
//var listRoleReq = new GetRoleAppsRequest
//{
//    Assigned = true
//};

List<int> setroleApps = new List<int> { 3701577, 3725441, 3713247 };

//create api's
//var createCustom = await client.CreateCustomAttribute(customFieldResponse);
//var updateuser = await client.UpdateUserById(246572113, newUserRequest);
//Delete api's

//var deleteUser = await client.DeleteUserById(245015075);

//List api's
var listUSer = await client.ListUsers(fields:"id,firstname");
var getUSer = await client.GetUserById(245015075);
//var getrateLimit = await client.GetRateLimit();
var getUSer22 = await client.GetGroups();
var getUSergrp = await client.GetGroup(515314);
var getUSer2 = await client.GetUserById(245015075);



//var listcustomeAttributes = await client.ListCustomAttributes();
//var getcustomeAttributes = await client.GetCustomAttribute(106291);
//var getUSer3 = await client.GetCustomAttribute(1);

//Roles aPI
//var listroles = await client.ListRoles();  //error desc is different
//var getrole = await client.GetRole(802170); //
//var CreateRoles = await client.CreateRoles(roleRequest);
//var updateRoles = await client.UpdateRoleById(802170, roleRequest);

//var ListRoleApps = await client.ListRoleApps(802714, listRoleReq);
//var setRoleApps = await client.SetRoleApps(802714, setroleApps);

//var listRoleUsers = await client.ListRoleUsers(802170);//ok
//var setroleUsersdel = await client.DeleteRoleUsers(802170, setroleApps);//ok
//var setroleUsers = await client.AddRoleUsers(802170, setroleApps);//ok

//var listRoleAdmins = await client.ListRoleAdmins(802934, "");   //ok
//var delroleadmin = await client.DeleteRoleAdmins(802934, setroleApps); //ok
//var addroleadmins = await client.AddRoleAdmins(802934, setroleApps); //ok
//var revokeToken = await client.RevokeToken();
//var getUSer32 = await client.GetCustomAttribute(1);
//var ListRoleApps = await client.ListRoleApps(791332, new GetRoleAppsRequest());





