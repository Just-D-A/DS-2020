@echo off

cd BackendApi
start dotnet BackendApi.dll

cd ..
cd FrontendTask
start dotnet FrontendTask.dll

cd ..
cd JobLogger
start dotnet JobLogger.dll

cd ..