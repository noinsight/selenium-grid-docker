#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Base runtime image (not used directly but can be helpful for multi-stage)
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

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
CMD ["dotnet", "test", "EAAppTest.csproj", "--no-build", "--logger:trx;LogFileName=test-results.trx"]
