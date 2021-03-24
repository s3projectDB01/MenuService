node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def msbuildHome = tool 'net5sdk'
    def scannerHome = tool 'sonarscannermsbuild'
    withSonarQubeEnv() {
      bat "dotnet \"${scannerHome}\\SonarScanner.MSBuild.dll\" begin /k:\"s3projectDB01_MenuService\""
      bat "dotnet build MenuApp.MenuService.sln"
      bat "dotnet \"${scannerHome}\\SonarScanner.MSBuild.dll\" end"
    }
  }
}