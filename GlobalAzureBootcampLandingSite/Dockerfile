FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["GlobalAzureBootcampLandingSite/GlobalAzureBootcampLandingSite.csproj", "GlobalAzureBootcampLandingSite/"]
RUN dotnet restore "GlobalAzureBootcampLandingSite/GlobalAzureBootcampLandingSite.csproj"
COPY . .
WORKDIR "/src/GlobalAzureBootcampLandingSite"
RUN dotnet build "GlobalAzureBootcampLandingSite.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GlobalAzureBootcampLandingSite.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GlobalAzureBootcampLandingSite.dll"]