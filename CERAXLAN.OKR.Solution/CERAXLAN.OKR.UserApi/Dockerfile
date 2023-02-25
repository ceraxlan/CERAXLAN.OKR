#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CERAXLAN.OKR.UserApi/CERAXLAN.OKR.UserApi.csproj", "CERAXLAN.OKR.UserApi/"]
COPY ["CorePackages/CERAXLAN.Core.Application/CERAXLAN.Core.Application.csproj", "CorePackages/CERAXLAN.Core.Application/"]
COPY ["CorePackages/CERAXLAN.Core.CrossCuttingConcerns/CERAXLAN.Core.CrossCuttingConcerns.csproj", "CorePackages/CERAXLAN.Core.CrossCuttingConcerns/"]
COPY ["CorePackages/CERAXLAN.Core.Security/CERAXLAN.Core.Security.csproj", "CorePackages/CERAXLAN.Core.Security/"]
COPY ["CorePackages/CERAXLAN.Core.Persistence/CERAXLAN.Core.Persistence.csproj", "CorePackages/CERAXLAN.Core.Persistence/"]
RUN dotnet restore "CERAXLAN.OKR.UserApi/CERAXLAN.OKR.UserApi.csproj"
COPY . .
WORKDIR "/src/CERAXLAN.OKR.UserApi"
RUN dotnet build "CERAXLAN.OKR.UserApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CERAXLAN.OKR.UserApi.csproj" -c Release -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CERAXLAN.OKR.UserApi.dll"]