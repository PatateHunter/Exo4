FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Exo4/Exo4.csproj", "Exo4/"]
RUN dotnet restore "Exo4/Exo4.csproj"
COPY . .
WORKDIR "/src/Exo4"
RUN dotnet build "Exo4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exo4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exo4.dll"]
