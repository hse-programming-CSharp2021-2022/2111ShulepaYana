FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW6_Point/HW6_Point.csproj", "HW6_Point/"]
RUN dotnet restore "HW6_Point/HW6_Point.csproj"
COPY . .
WORKDIR "/src/HW6_Point"
RUN dotnet build "HW6_Point.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW6_Point.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW6_Point.dll"]
