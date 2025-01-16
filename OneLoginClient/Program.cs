// See https://aka.ms/new-console-template for more information
using OneLogin.Requests;
using OneLogin.Responses;
using OneLogin;

Console.WriteLine("Hello, World!");
var client = new OneLoginClient("3966e03975694e24db3425a8f7befe4061e540a894f067ba02a692c14b8f4036", "7a39ddae50f96585d6ce08d02b8877d796f296a42828cc948098786e911a6b0d");
var tokenResponse = await client.GenerateTokens();
Console.WriteLine(tokenResponse);

//var userResponse = await client.GetUserById("roma.rathi@accolitedigital.com");
//var userAppsResponse = await client.GetAppsForUser(userId);

// Events
var listUsers = await client.ListUsers();
var listUsers2 = await client.ListUsers();
//var getUsers = await client.GetUserById(245015075);
//var getUsers = await client.GetUserById(36216766);
//var eventById = (await client.GetEventById(eventId);
//var manyEvents = await client.CreateEvent(new CreateEventRequest
//{
//    EventTypeId = eventTypeId,
//    UserId = userId,
//    AppId = appId,
//});
///var eventById = await client.GetEventById(51590674642);

// Interpolate Event data
//var eventsResponse = await client.GetEvents();

//var results = eventsResponse
//    .SelectMany(response => response.Data)
//    .Select(@event => @event.InterpolateEvent(allEventTypes.Data))
//    .ToList();