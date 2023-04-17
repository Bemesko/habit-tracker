FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HabitTracker.Api/HabitTracker.Api.csproj", "src/HabitTracker.Api/"]
RUN dotnet restore "src/HabitTracker.Api/HabitTracker.Api.csproj"
COPY . .
WORKDIR "/src/HabitTracker.Api/"
RUN dotnet build "HabitTracker.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HabitTracker.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "HabitTracker.Api.dll"]