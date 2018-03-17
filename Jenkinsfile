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
  try  {
		bat '"C:/Program Files (x86)/Microsoft Visual Studio 12.0/Common7/IDE/mstest.exe" /resultsfile:"%WORKSPACE%/TestProject/Results.trx" /testcontainer:"%WORKSPACE%/TestProject/bin/Debug/TestProject.dll" /nologo'
	}
  catch(exc) {
    stage('JiraBugLog'){
     echo"test"    
# Look at IssueInput class for more information.
    def testIssue = [fields: [ // id or key must present for project.
                               project: [id: 'TESTPROJ1'],
                               summary: 'New JIRA Created from Jenkins.',
                               description: 'New JIRA Created from Jenkins.',
                               customfield_1000: 'customValue',
                               // id or name must present for issueType.
                               issuetype: [id: '3']]]

    response = jiraNewIssue issue: testIssue

    echo response.successful.toString()
    echo response.data.toString()
	    
	    
	    
	    
	    

   }
   }
 }
}
