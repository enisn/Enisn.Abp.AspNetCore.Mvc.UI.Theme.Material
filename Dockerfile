#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["sandbox/src/Sandbox.Web/Sandbox.Web.csproj", "sandbox/src/Sandbox.Web/"]
COPY ["sandbox/src/Sandbox.Application/Sandbox.Application.csproj", "sandbox/src/Sandbox.Application/"]
COPY ["sandbox/src/Sandbox.Application.Contracts/Sandbox.Application.Contracts.csproj", "sandbox/src/Sandbox.Application.Contracts/"]
COPY ["sandbox/src/Sandbox.Domain.Shared/Sandbox.Domain.Shared.csproj", "sandbox/src/Sandbox.Domain.Shared/"]
COPY ["sandbox/src/Sandbox.Domain/Sandbox.Domain.csproj", "sandbox/src/Sandbox.Domain/"]
COPY ["sandbox/src/Sandbox.HttpApi/Sandbox.HttpApi.csproj", "sandbox/src/Sandbox.HttpApi/"]
COPY ["sandbox/src/Sandbox.EntityFrameworkCore/Sandbox.EntityFrameworkCore.csproj", "sandbox/src/Sandbox.EntityFrameworkCore/"]
COPY ["themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.csproj", "themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/"]
RUN dotnet restore "sandbox/src/Sandbox.Web/Sandbox.Web.csproj"
COPY . .
WORKDIR "/src/sandbox/src/Sandbox.Web"
RUN dotnet build "Sandbox.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sandbox.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Heroku Adaptation
#ENTRYPOINT ["dotnet", "Sandbox.Web.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Sandbox.Web.dll