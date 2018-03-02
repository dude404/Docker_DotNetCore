# Docker_DotNetCore
POC pour executer du code .NET CORE dans un container docker.
Graceful stop : le container s'arrête proprement (finit le job en cours) quand il reçoit un signal

# Pré requis
Docker & .NET CORE Sdk

# Run local
Terminal
go in MyApp folder
```
dotnet run
```

On another terminal
```
kill [PROCESS ID]
```
-> observe graceful stop

# Run via Docker

## Build
```
docker build -t dotnetapp-dev .
```

## Run
```
docker run dotnetapp-dev
```
On another terminal
```
docker stop [CONTAINER ID]
```
-> observe graceful stop
