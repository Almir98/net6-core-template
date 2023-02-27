#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Template.API/Template.API.csproj", "Template.API/"]
COPY ["Template.Service/Template.Infrastructure.csproj", "Template.Service/"]
COPY ["Template.Application/Template.Application.csproj", "Template.Application/"]
COPY ["Template.Repository/Template.Domain.csproj", "Template.Repository/"]
RUN dotnet restore "Template.API/Template.API.csproj"
COPY . .
WORKDIR "/src/Template.API"
RUN dotnet build "Template.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Template.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Template.API.dll"]