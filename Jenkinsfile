    pipeline {
        agent any

        stages {

            stage('Restore') {
                steps {
                    bat 'dotnet restore'
                }
            }

            stage('Build') {
                steps {
                    bat 'dotnet build --configuration Release'
                }
            }

            stage('Publish') {
                steps {
                    bat 'dotnet publish --configuration Release -o publish'
                }
            }

            stage('Deploy') {
    steps {
        bat 'iisreset /stop'
        bat 'xcopy /E /Y /I publish\\* C:\\inetpub\\wwwroot\\CoreMVCAppWithJenkins\\'
        bat 'iisreset /start'
    }
}
        }
    }