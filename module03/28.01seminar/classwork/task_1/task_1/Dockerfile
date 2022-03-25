FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["task_1/task_1.csproj", "task_1/"]
RUN dotnet restore "task_1/task_1.csproj"
COPY . .
WORKDIR "/src/task_1"
RUN dotnet build "task_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task_1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task_1.dll"]
