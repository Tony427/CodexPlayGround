# CodexPlayGround

This repository contains a sample **.NET 10** Web API project and an accompanying test project using xUnit and Moq.

## Building and Testing

The `Net10WebApi` project exposes a simple controller with GET and POST endpoints. The test project `Net10WebApi.Tests` demonstrates how to unit test the controller using mocked services.

To build the projects and run the tests:

```bash
# restore dependencies and build
# dotnet build Net10WebApi/Net10WebApi.csproj
# run tests
# dotnet test Net10WebApi.Tests/Net10WebApi.Tests.csproj
```

*(The dotnet CLI must be installed to execute these commands.)*
