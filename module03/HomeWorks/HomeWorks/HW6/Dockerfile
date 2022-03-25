FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW6/HW6.csproj", "HW6/"]
RUN dotnet restore "HW6/HW6.csproj"
COPY . .
WORKDIR "/src/HW6"
RUN dotnet build "HW6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW6.dll"]
