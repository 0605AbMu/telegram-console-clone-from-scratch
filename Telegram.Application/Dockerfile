FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Telegram.Application/Telegram.Application.csproj", "Telegram.Application/"]
RUN dotnet restore "Telegram.Application/Telegram.Application.csproj"
COPY . .
WORKDIR "/src/Telegram.Application"
RUN dotnet build "Telegram.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Telegram.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Telegram.Application.dll"]
