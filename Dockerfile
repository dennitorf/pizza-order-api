#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Src/Restaurant.Pizza.WebApi/Restaurant.Pizza.WebApi.csproj", "Src/Restaurant.Pizza.WebApi/"]
COPY ["Src/Restaurant.Pizza.Application/Restaurant.Pizza.Application.csproj", "Src/Restaurant.Pizza.Application/"]
COPY ["Src/Restaurant.Pizza.Persistence/Restaurant.Pizza.Persistence.csproj", "Src/Restaurant.Pizza.Persistence/"]
COPY ["Src/Restaurant.Pizza.Domain/Restaurant.Pizza.Domain.csproj", "Src/Restaurant.Pizza.Domain/"]
COPY ["Src/Restaurant.Pizza.Infrastructure/Restaurant.Pizza.Infrastructure.csproj", "Src/Restaurant.Pizza.Infrastructure/"]
RUN dotnet restore "Src/Restaurant.Pizza.WebApi/Restaurant.Pizza.WebApi.csproj"
COPY . .
WORKDIR "/src/Src/Restaurant.Pizza.WebApi"
RUN dotnet build "Restaurant.Pizza.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Restaurant.Pizza.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Restaurant.Pizza.WebApi.dll"]
