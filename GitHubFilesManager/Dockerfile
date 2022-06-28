FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GitHubFilesManager/GitHubFilesManager.csproj", "GitHubFilesManager/"]
RUN dotnet restore "GitHubFilesManager/GitHubFilesManager.csproj"
COPY . .
WORKDIR "/src/GitHubFilesManager"
RUN dotnet build "GitHubFilesManager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GitHubFilesManager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GitHubFilesManager.dll"]
