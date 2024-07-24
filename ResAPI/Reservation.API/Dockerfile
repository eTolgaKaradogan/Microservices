#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ResAPI/Reservation.API/Reservation.API.csproj", "ResAPI/Reservation.API/"]
COPY ["ResAPI/Reservation.API.Services/Reservation.API.Services.csproj", "ResAPI/Reservation.API.Services/"]
COPY ["ResAPI/Reservation.API.Infrastructure/Reservation.API.Infrastructure.csproj", "ResAPI/Reservation.API.Infrastructure/"]
COPY ["ResAPI/Reservation.API.Models/Reservation.API.Models.csproj", "ResAPI/Reservation.API.Models/"]
RUN dotnet restore "./ResAPI/Reservation.API/./Reservation.API.csproj"
COPY . .
WORKDIR "/src/ResAPI/Reservation.API"
RUN dotnet build "./Reservation.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Reservation.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]