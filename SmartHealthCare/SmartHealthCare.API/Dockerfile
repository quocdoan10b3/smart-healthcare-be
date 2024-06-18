FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SmartHealthCare.API/SmartHealthCare.API.csproj", "SmartHealthCare.API/"]
COPY ["SmartHealthCare.Application/SmartHealthCare.Application.csproj", "SmartHealthCare.Application/"]
COPY ["SmartHealthCare.Domain/SmartHealthCare.Domain.csproj", "SmartHealthCare.Domain/"]
COPY ["SmartHealthCare.Infrastructure/SmartHealthCare.Infrastructure.csproj", "SmartHealthCare.Infrastructure/"]
RUN dotnet restore "SmartHealthCare.API/SmartHealthCare.API.csproj"
COPY . .
WORKDIR "/src/SmartHealthCare.API"
RUN dotnet build "SmartHealthCare.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SmartHealthCare.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /src/SmartHealthCare.API/https/aspnetapp.pfx /https/
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartHealthCare.API.dll"]
