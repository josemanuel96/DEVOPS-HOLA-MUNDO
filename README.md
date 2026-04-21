# Práctica DevOps - Hola Mundo en C# con Docker

## Descripción
Aplicación web básica en C# usando ASP.NET Core, dockerizada y publicada en Docker Hub.

## Ejecutar localmente con Docker
```bash
docker pull josevicente96/holamundodocker:latest
docker run -d -p 8081:8080 --name holamundoapp josevicente96/holamundodocker:latest