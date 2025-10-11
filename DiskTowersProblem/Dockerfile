#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DiskTowersProblem/DiskTowersProblem.csproj", "DiskTowersProblem/"]
COPY ["DiskTower.Application/DiskTower.Application.csproj", "DiskTower.Application/"]
COPY ["DiskTower.Domain/DiskTower.Domain.csproj", "DiskTower.Domain/"]
COPY ["InfraStructure/InfraStructure.csproj", "InfraStructure/"]
RUN dotnet restore "DiskTowersProblem/DiskTowersProblem.csproj"
COPY . .
WORKDIR "/src/DiskTowersProblem"
RUN dotnet build "DiskTowersProblem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DiskTowersProblem.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DiskTowersProblem.dll"]