#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RestASPNET-NET5/RestASPNET-NET5.csproj", "RestASPNET-NET5/"]
RUN dotnet restore "RestASPNET-NET5/RestASPNET-NET5.csproj"
COPY . .
WORKDIR "/src/RestASPNET-NET5"
RUN dotnet build "RestASPNET-NET5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestASPNET-NET5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestASPNET-NET5.dll"]
