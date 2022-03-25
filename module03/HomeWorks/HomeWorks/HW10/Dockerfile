FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW10/HW10.csproj", "HW10/"]
RUN dotnet restore "HW10/HW10.csproj"
COPY . .
WORKDIR "/src/HW10"
RUN dotnet build "HW10.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW10.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW10.dll"]
