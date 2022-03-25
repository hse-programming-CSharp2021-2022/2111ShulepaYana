FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["pres2b_6/pres2b_6.csproj", "pres2b_6/"]
RUN dotnet restore "pres2b_6/pres2b_6.csproj"
COPY . .
WORKDIR "/src/pres2b_6"
RUN dotnet build "pres2b_6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pres2b_6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pres2b_6.dll"]
