#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SharpCode.PerformanceCounterApi.Pi4/SharpCode.PerformanceCounterApi.Pi4.csproj", "SharpCode.PerformanceCounterApi.Pi4/"]
RUN dotnet restore "SharpCode.PerformanceCounterApi.Pi4/SharpCode.PerformanceCounterApi.Pi4.csproj"
COPY . .
WORKDIR "/src/SharpCode.PerformanceCounterApi.Pi4"
RUN dotnet build "SharpCode.PerformanceCounterApi.Pi4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SharpCode.PerformanceCounterApi.Pi4.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SharpCode.PerformanceCounterApi.Pi4.dll"]