#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Najot.API/Najot.API.csproj", "src/Najot.API/"]
COPY ["src/Najot.Application/Najot.Application.csproj", "src/Najot.Application/"]
COPY ["src/Najot.Domain/Najot.Domain.csproj", "src/Najot.Domain/"]
COPY ["src/Najot.Infrastructure/Najot.Infrastructure.csproj", "src/Najot.Infrastructure/"]
RUN dotnet restore "src/Najot.API/Najot.API.csproj"
COPY . .
WORKDIR "/src/src/Najot.API"
RUN dotnet build "Najot.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Najot.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Najot.API.dll"]