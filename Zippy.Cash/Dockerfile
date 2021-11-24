#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Zippy.Cash/Zippy.Cash.csproj", "Zippy.Cash/"]
RUN dotnet restore "Zippy.Cash/Zippy.Cash.csproj"
COPY . .
WORKDIR "/src/Zippy.Cash"
RUN dotnet build "Zippy.Cash.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zippy.Cash.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zippy.Cash.dll"]