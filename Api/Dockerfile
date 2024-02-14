FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.sln .
COPY Models/*.csproj Models/
COPY Services/*.csproj Services/
COPY Data/*.csproj Data/
COPY Api/*.csproj Api/
RUN dotnet restore learnApi.sln

COPY . .
RUN dotnet publish learnApi.sln -c Release -o Api/out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/Api/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "learnApi.Api.dll"]