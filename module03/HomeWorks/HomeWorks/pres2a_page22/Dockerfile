FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["pres2a_page22/pres2a_page22.csproj", "pres2a_page22/"]
RUN dotnet restore "pres2a_page22/pres2a_page22.csproj"
COPY . .
WORKDIR "/src/pres2a_page22"
RUN dotnet build "pres2a_page22.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pres2a_page22.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pres2a_page22.dll"]
