node {
 stage('SCM') {
  git 'https://github.com/Kgasr/TestProject'
  }
 stage('SonarQube Analysis') {
  withSonarQubeEnv('My SonarQube Server') {
   sh './gradlew --info sonarqube'
  }
 }
}
