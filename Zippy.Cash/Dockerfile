#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Zippy.Cash/Zippy.Cash.API.csproj Zippy.Cash/
COPY Zippy.Cash.Repository/Zippy.Cash.Repository.csproj Zippy.Cash.Repository/
COPY Zippy.Model/Zippy.Model.csproj Zippy.Model/
RUN dotnet restore Zippy.Cash/Zippy.Cash.API.csproj
COPY . .
RUN dotnet build Zippy.Cash/Zippy.Cash.API.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Zippy.Cash/Zippy.Cash.API.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zippy.Cash.API.dll"]