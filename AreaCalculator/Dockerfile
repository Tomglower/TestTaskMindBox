FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AreaCalculator/AreaCalculator.csproj", "AreaCalculator/"]
RUN dotnet restore "AreaCalculator/AreaCalculator.csproj"
COPY . .
WORKDIR "/src/AreaCalculator"
RUN dotnet build "AreaCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AreaCalculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AreaCalculator.dll"]
