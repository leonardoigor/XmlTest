@echo off

 
cmd /k docker compose -f ../docker-compose.yml -p dotnet down --volumes --rmi all

exit