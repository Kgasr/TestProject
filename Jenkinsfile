node {
 stage('SCM') {
  git 'https://github.com/Kgasr/TestProject'
  }
 stage('SonarQube Analysis') {
  
  withSonarQubeEnv('sonarqube') {
   bat "C:/Users/120054/Documents/SonarQube7/sonar-scanner-3.0.3.778-windows/bin/sonar-scanner"
  }
 }
 stage('UnitTest') {
  bat '"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\mstest.exe" /resultsfile:"%WORKSPACE%\TestProject\Results.trx" /testcontainer:"%WORKSPACE%\TestProject\bin\Debug\TestProject.dll" /nologo'
  mstest testResultsFile:"TestProject/Unittest.trx", keepLongStdio: true
 }
}
