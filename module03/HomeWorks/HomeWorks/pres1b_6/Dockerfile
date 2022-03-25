FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["pres1b_6/pres1b_6.csproj", "pres1b_6/"]
RUN dotnet restore "pres1b_6/pres1b_6.csproj"
COPY . .
WORKDIR "/src/pres1b_6"
RUN dotnet build "pres1b_6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pres1b_6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pres1b_6.dll"]
