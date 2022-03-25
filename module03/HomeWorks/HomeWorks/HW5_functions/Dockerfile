FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW5_functions/HW5_functions.csproj", "HW5_functions/"]
RUN dotnet restore "HW5_functions/HW5_functions.csproj"
COPY . .
WORKDIR "/src/HW5_functions"
RUN dotnet build "HW5_functions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW5_functions.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW5_functions.dll"]
