run:
    dotnet run --project ConsoleApp/ConsoleApp.csproj

test:
    DOTNET_ROLL_FORWARD=Major dotnet test ConsoleApp.Tests/ConsoleApp.Tests.csproj

build:
    dotnet build CommonAlgorithm.sln
