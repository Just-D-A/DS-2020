@echo off

set DIR_NAME=builded

cd src/BackendApi
dotnet publish --configuration Release
if %ERRORLEVEL% NEQ 0 (
	echo "Build failed in BackendApi"
    exit /b -1
)

cd ..
cd FrontendTask
dotnet publish --configuration Release
if %ERRORLEVEL% NEQ 0 (
	echo "Build failed in FrontendTask"
    exit /b -1
)

cd ..

cd MyJobLogger
dotnet publish --configuration Release
if %ERRORLEVEL% NEQ 0 (
    echo "Build failed"
    exit /b -1
)

cd ..
cd ..
MD "%DIR_NAME%"
cd %DIR_NAME%

mkdir "BackendApi"
mkdir "FrontendTask"
mkdir "config"
mkdir "MyJobLogger"

cd ..

xcopy src\BackendApi\bin\Release\netcoreapp3.1\publish "%DIR_NAME%"\BackendApi\ /s /e
xcopy src\FrontendTask\bin\Release\netcoreapp3.1\publish "%DIR_NAME%"\FrontendTask\ /s /e
xcopy start.cmd "%DIR_NAME%"
xcopy stop.cmd "%DIR_NAME%"
xcopy src\config\shipitsynConfig.json "%DIR_NAME%\config\"
xcopy src\MyJobLogger\bin\Release\netcoreapp3.1\publish "%DIR_NAME%"\MyJobLogger\ /s /e

echo BUILD COMPLITE
