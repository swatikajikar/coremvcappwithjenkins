pipeline {
    agent any

    stages {

        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/swatikajikar/coremvcappwithjenkins.git'
            }
        }

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
                bat 'dotnet publish --configuration Release --output publish'
            }
        }

        stage('Deploy') {
            steps {
                bat 'xcopy /E /Y /I publish\\* C:\\inetpub\\wwwroot\\CoreMVCAppWithJenkins\\'
            }
        }
    }
}