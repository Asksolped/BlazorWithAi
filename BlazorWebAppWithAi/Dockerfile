FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BlazorWebAppWithAi/BlazorWebAppWithAi.csproj", "BlazorWebAppWithAi/"]
RUN dotnet restore "BlazorWebAppWithAi/BlazorWebAppWithAi.csproj"
COPY . .
WORKDIR "/src/BlazorWebAppWithAi"
RUN dotnet build "./BlazorWebAppWithAi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BlazorWebAppWithAi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorWebAppWithAi.dll"]
