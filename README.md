# CF Sample App .NET Core

A sample [ASP.NET Core](https://www.asp.net/core) application to deploy to Cloud Foundry which works out of the box.

## Run locally

1. Install [.NET Core](https://www.microsoft.com/net/core)
1. Run `dotnet restore`
1. Run `dotnet run`
1. Visit [http://localhost:5000](http://localhost:5000)

## Run in the cloud

1. Install the [cf CLI](https://github.com/cloudfoundry/cli#downloads)
1. Run `cf create-service mongodb small my-mongodb`
1. Wait about 3 minutes until the MongoDB is ready
1. Run `cf push --random-route`
1. Visit the given URL

