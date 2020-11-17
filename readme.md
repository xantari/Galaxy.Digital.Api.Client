# Galaxy Digital Interaction Library [![Build status](https://ci.appveyor.com/api/projects/status/hitn2ovkjxy5lnrm/branch/main?svg=true)](https://ci.appveyor.com/project/xantari/galaxy-digital-api-client/branch/main) [![NuGet tag](https://img.shields.io/badge/nuget-Galaxy.Digital.Api.Client-blue.svg)](https://www.nuget.org/packages?q=Galaxy.Digital.Api.Client)

This library provides all the user functions for interacting with Galaxy Digital's API Endpoint.

This is for their V2 API here: http://api2.galaxydigital.com/volunteer/docs/

# Requirements

This library is .NET Standard 2.0 compliant so it is cross platform supported in both .NET Full Framework and .NET Core

# Getting Started

You need to provide your API key one time during application startup as follows:

GalaxyDigitalApiClientConfig.ApiKey = "your_key_here";

# Methods

All methods have synchronous and asynchronous versions avilable.

- GetUserList (Returns a paged user list)
- GetById (Returns a user by one of the IdType values)
- AddUser (Adds a new user)
- UpdateUser (Updates a user)
- GetUserOneClickLogin (Gets a 15 minute time expiring login link)
- UserAuthenticate (Authenticates a user)

# Samples

```
//Gets the paged user list
var results = _userClient.GetUserList(new UserListRequest()
{
    Return = new List<string>()
    { "extras", "tags", "interests", "stats", "qualifications", "favoriteAgencies", "registration", "skills" }
});

//Gets a user by ID
var results = _userClient.GetById(new UserGetByIdRequest() { Id = "123456", IdType = "id",
        Return = new List<string>()
        { "extras", "tags", "interests", "stats", "qualifications", "favoriteAgencies", "registration", "skills" }});

//Adds a User
var results = _userClient.AddUser(new UserAddRequest() { FirstName = "John", LastName = "Smith", Email = "foo@bar.net", Password = "1234", Status = "Active" });

//Update a User
var extras = new Dictionary<string, string>();
extras.Add("my-extra-data", "test");
var results = _userClient.UpdateUser(new UserUpdateRequest() { Id = 123456, ReferenceId = "123456", State = "MN", Postal = "56601-1234", Gender = "M", ExtraAdd = extras });

//Get User One Click Login
var results = _userClient.GetUserOneClickLogin(new UserOneClickLoginRequest() { Id = 123456,
    Return = new List<string>()
        { "extras", "tags", "interests", "stats", "qualifications", "favoriteAgencies", "registration", "skills" }});

//Authenticate a User (returns a message indicating authentication failure if it does not succeed)
var results = _userClient.UserAuthenticate(new UserAuthenticateRequest() { Email = "foo@bar.com", Password = "1234" });
```

# Future

Implement the other API interactions. However I have requested that they instead implement an Open API Spec compliant API instead of the manual way they implemented it, which has lots of 
undocumented features I have found out.

Go vote up that feature request here: https://galaxydigital.freshdesk.com/support/discussions/topics/36000018282