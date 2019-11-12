#!/bin/sh

dotnet new sln --name Challenge
dotnet new console --name Challenge.Client
dotnet new classlib --name Challenge.Domain

dotnet add Challenge.Client/Challenge.Client.csproj reference Challenge.Domain/Challenge.Domain.csproj

dotnet sln add **/*.csproj
