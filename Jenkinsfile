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
  }
}