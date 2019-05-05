@echo off
pushd "%~dp0"

docker build -t gabsite:latest -f .\Dockerfile ..

:exit
popd
@echo on