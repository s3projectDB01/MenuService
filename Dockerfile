FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY MenuApp.MenuService/*.csproj ./MenuApp.MenuService/
COPY MenuApp.MenuService.EntityFramework/*.csproj ./MenuApp.MenuService.EntityFramework/
COPY MenuApp.MenuService.Logic/*.csproj ./MenuApp.MenuService.Logic/
#
RUN dotnet restore 
#
# copy everything else and build app
COPY MenuApp.MenuService/. ./MenuApp.MenuService/
COPY MenuApp.MenuService.EntityFramework/. ./MenuApp.MenuService.EntityFramework/
COPY MenuApp.MenuService.Logic/. ./MenuApp.MenuService.Logic/
#
WORKDIR /app/MenuApp.MenuService
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/MenuApp.MenuService/out ./

EXPOSE 80
ENTRYPOINT ["dotnet", "MenuApp.MenuService.dll"]