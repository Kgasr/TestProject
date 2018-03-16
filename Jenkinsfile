node {
 stage('SCM') {
  git 'https://github.com/Kgasr/TestProject'
  }
 stage('SonarQube Analysis') {
  def scannerHome = tool 'SonarQube Scanner 3.0';
  withSonarQubeEnv('sonar scanner') {
   sh "${scannerHome}/bin/sonar-scanner"
  }
 }
}
