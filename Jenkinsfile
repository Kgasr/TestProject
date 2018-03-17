node {

 stage('Checkout') {
  		git 'https://github.com/Kgasr/TestProject'
  	}

 stage('SonarQube Analysis') {

		withSonarQubeEnv('sonarqube') {
   		bat "C:/Users/120054/Documents/SonarQube7/sonar-scanner-3.0.3.778-windows/bin/sonar-scanner"
  		}
	}
 
 stage('UnitTest') {
 	 try  {
			bat '"C:/Program Files (x86)/Microsoft Visual Studio 12.0/Common7/IDE/mstest.exe" /resultsfile:"%WORKSPACE%/TestProject/Results.trx" /testcontainer:"%WORKSPACE%/TestProject/bin/Debug/TestProject.dll" /nologo'
	 }
  	 catch(exc) {
     	stage('JiraBugLog'){
     	withEnv(['JIRA_SITE=LOCAL']){
    		def testIssue = [fields: [ project: [key: 'TESTPROJ1'],
                           summary: 'New JIRA Created from Jenkins for build 1.0.0.${BUILD_URL}.',
                           description: 'New JIRA Created from Jenkins for build 1.0.0.${BUILD_URL}.',
                           issuetype: [name: 'Bug']]]

			response = jiraNewIssue issue: testIssue
			echo response.successful.toString()
			echo response.data.toString()
 	   		}    
		}
	  System.exit(-1)
   	}
	 stage('Build'){
  	 bat "\"${tool 'MSBuild'}\" TestProject.sln /p:Configuration=Debug /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
  }
  } 
}

