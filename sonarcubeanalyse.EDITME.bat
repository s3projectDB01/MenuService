dotnet sonarscanner begin /k:"s3projectDB01_MenuService" /d:sonar.host.url="https://sonarqube.tycho.dev" /d:sonar.login="YOURTOKEN"
dotnet build MenuApp.MenuService.sln
dotnet sonarscanner end /d:sonar.login="YOURTOKEN"