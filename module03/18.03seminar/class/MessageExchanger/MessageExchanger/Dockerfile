﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MessageExchanger/MessageExchanger.csproj", "MessageExchanger/"]
RUN dotnet restore "MessageExchanger/MessageExchanger.csproj"
COPY . .
WORKDIR "/src/MessageExchanger"
RUN dotnet build "MessageExchanger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MessageExchanger.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MessageExchanger.dll"]
