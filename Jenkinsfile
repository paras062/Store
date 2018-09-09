pipeline {
  agent any
  stages {
    stage('Restore_Nuget') {
      steps {
        bat 'C:\\ProgramData\\chocolatey\\bin\\nuget.exe restore "C:\\Program Files (x86)\\Jenkins\\workspace\\StoreJob\\store.sln"'
      }
    }
    stage('MSBuild') {
      steps {
        bat '"C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\amd64\\MSBuild.exe" "C:\\Program Files (x86)\\Jenkins\\workspace\\StoreJob\\Store\\Store.csproj" /t:Rebuild /p:Configuration=Release /p:OutputPath="C:\\Program Files (x86)\\Jenkins\\workspace\\StoreJob\\Store"'
      }
    }
    stage('Nunit') {
      steps {
        bat '"C:\\Program Files (x86)\\NUnit.org\\nunit-console\\nunit3-console.exe" "C:\\Users\\Paras\\Source\\Repos\\Store\\Store.Tests\\bin\\Debug\\Store.Tests.dll"'
      }
    }
    stage('Sonar_Begin') {
      steps {
        bat 'C:\\Users\\Paras\\Downloads\\sonar-scanner-msbuild-4.3.1.1372-net46\\SonarScanner.MSBuild.exe begin /k:"StoreJob_BlueOcean'
      }
    }
  }
}