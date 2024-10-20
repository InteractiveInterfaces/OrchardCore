REM Publish web project; 
dotnet publish -c Release -f net8.0 

echo off
IF %ERRORLEVEL% NEQ 0 (  
  echo "Publishing failed; exiting the process!"  
  goto endscirpt
)

REM Build docker image
docker build -t intintcms-prod -f Dockerfile-Prod --rm .

REM no need to run container in production; once image is build/updated push that 
REM to the Azure or Docker repository

:endscirpt