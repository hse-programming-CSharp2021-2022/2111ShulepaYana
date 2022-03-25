FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW7_person/HW7_person.csproj", "HW7_person/"]
RUN dotnet restore "HW7_person/HW7_person.csproj"
COPY . .
WORKDIR "/src/HW7_person"
RUN dotnet build "HW7_person.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW7_person.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW7_person.dll"]
