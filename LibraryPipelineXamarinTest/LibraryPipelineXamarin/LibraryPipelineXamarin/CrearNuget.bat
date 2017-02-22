@echo off
echo Creando nuget LibrayPipeline
echo ....espere por favor
//rem nuget  spec 
nuget pack  LibraryPipelineXamarin.csproj
if errorlevel 0 goto fin
if errorlevel 1 goto error
:error
echo Error en compilacion.
:fin
echo realizado con exito el Nuget.
pause