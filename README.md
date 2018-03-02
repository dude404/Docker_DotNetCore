# Docker_DotNetCore

# Pré requis
Docker
.NET CORE Sdk

# Run local
Terminal
go in MyApp folder
dotnet run

On another terminal
kill the process
-> observe graceful stop

# Run via Docker

## Build
docker build -t dotnetapp-dev .

## Run
docker run dotnetapp-dev

On another terminal
docker stop [CONTAINER ID]
-> observe graceful stop
