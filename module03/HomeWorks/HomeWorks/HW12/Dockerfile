FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW12/HW12.csproj", "HW12/"]
RUN dotnet restore "HW12/HW12.csproj"
COPY . .
WORKDIR "/src/HW12"
RUN dotnet build "HW12.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW12.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW12.dll"]
