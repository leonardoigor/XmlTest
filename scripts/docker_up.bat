@echo off

cmd /k docker compose -f ../docker-compose.yml -p dotnet up -d --renew-anon-volumes


exit