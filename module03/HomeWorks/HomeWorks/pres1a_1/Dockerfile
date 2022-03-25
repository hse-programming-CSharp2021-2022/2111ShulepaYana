FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["pres1a_1/pres1a_1.csproj", "pres1a_1/"]
RUN dotnet restore "pres1a_1/pres1a_1.csproj"
COPY . .
WORKDIR "/src/pres1a_1"
RUN dotnet build "pres1a_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pres1a_1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pres1a_1.dll"]
