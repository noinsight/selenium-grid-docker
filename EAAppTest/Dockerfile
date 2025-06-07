#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Base runtime image (not used directly but can be helpful for multi-stage)
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Install ping utility
#RUN apt-get update && apt-get install -y iputils-ping

# Copy only the test first for layer caching
COPY ["EAAppTest/EAAppTest.csproj", "EAAppTest/"]
RUN dotnet restore "EAAppTest/EAAppTest.csproj"

# Copy the rest of the files
COPY . .

# Build the test project
WORKDIR "/src/EAAppTest"
RUN dotnet build "EAAppTest.csproj" -c Release

# Run the tests
FROM build AS test-runner
WORKDIR "/src/EAAppTest"

# Debug: list contents of build output directory
RUN ls -l /src/EAAppTest/bin/Release/net6.0/

# Run the tests using the .csproj and explicitly set Release config
CMD ["dotnet", "test", "EAAppTest.csproj", "--configuration", "Release", "--logger:trx;LogFileName=test-results.trx"]

