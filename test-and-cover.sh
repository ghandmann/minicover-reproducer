#!/bin/bash

# restore and build the whole solution
dotnet restore
dotnet build

# Init minicover
cd Coverage
dotnet minicover instrument --workdir ../
dotnet minicover reset --workdir ../

# run the test, don't re-build!
cd ..
dotnet test --no-build WebAPITests/WebAPITests.csproj


cd Coverage
# De-Init minicover
dotnet minicover uninstrument --workdir ../

# Generate the report
dotnet minicover report --workdir ../
