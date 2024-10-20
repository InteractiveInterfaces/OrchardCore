REM Publish web project; 
dotnet publish -c Release -f net8.0 

echo off
IF %ERRORLEVEL% NEQ 0 (  
  echo "Publishing failed; exiting the process!"  
  goto endscirpt
)

REM Build docker image
docker build -t intintcms-dev -f Dockerfile-Dev --rm .

echo off
IF %ERRORLEVEL% NEQ 0 (
  echo "Building the docker image failed; exiting the process!"
  goto endscirpt
)

REM Run container
docker run --rm -it -p 8000:80 -p 8001:443 -v %USERPROFILE%\.aspnet\https:/https/ -v %USERPROFILE%\.aspnet\appdata:/app/App_Data intintcms-dev

:endscirpt