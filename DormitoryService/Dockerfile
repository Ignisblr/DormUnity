FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# mcr.microsoft.com/dotnet/nightly/sdk:7.0

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT [ "dotnet", "DormitoryService.dll" ]

