FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW14_Linq/HW14_Linq.csproj", "HW14_Linq/"]
RUN dotnet restore "HW14_Linq/HW14_Linq.csproj"
COPY . .
WORKDIR "/src/HW14_Linq"
RUN dotnet build "HW14_Linq.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW14_Linq.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW14_Linq.dll"]
