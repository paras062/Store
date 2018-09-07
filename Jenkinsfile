pipeline {
  agent any
  stages {
    stage('Restore_Nuget') {
      steps {
        bat 'C:\\ProgramData\\chocolatey\\bin\\nuget.exe restore "C:\\Program Files (x86)\\Jenkins\\workspace\\StoreJob\\store.sln"'
      }
    }
  }
}