FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW11_Numbers/HW11_Numbers.csproj", "HW11_Numbers/"]
RUN dotnet restore "HW11_Numbers/HW11_Numbers.csproj"
COPY . .
WORKDIR "/src/HW11_Numbers"
RUN dotnet build "HW11_Numbers.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW11_Numbers.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW11_Numbers.dll"]
