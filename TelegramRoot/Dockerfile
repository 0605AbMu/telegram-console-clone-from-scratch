FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Telegregram.Client/Telegregram.Client.csproj", "Telegregram.Client/"]
RUN dotnet restore "Telegregram.Client/Telegregram.Client.csproj"
COPY . .
WORKDIR "/src/Telegregram.Client"
RUN dotnet build "Telegregram.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Telegregram.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Telegregram.Client.dll"]
