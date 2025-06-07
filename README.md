# NombreDelProyecto

API RESTful construida con ASP.NET Core (.NET 8) e Identity Core para autenticación y gestión de usuarios.

## Características

- Registro y autenticación de usuarios con ASP.NET Core Identity
- Autenticación basada en JWT (JSON Web Tokens)
- Endpoints seguros y protegidos
- Arquitectura modular y escalable

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (o la base de datos configurada en el proyecto)
- Visual Studio 2022 (opcional, pero recomendado)

## Instalación

1. Clona el repositorio:
- git clone https://github.com/GonzaloFP100786/AuthApi


2. Restaura los paquetes NuGet:
 
- dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

3. Ejecuta la API:

- dotnet run

## Uso

- Accede a los endpoints de autenticación en `/api/auth/register` y `/api/auth/login`.
- Protege tus endpoints usando el atributo `[Authorize]`.

## Estructura del Proyecto

- `Controllers/` — Controladores de la API
- `Models/` — Modelos de datos y DTOs
- `Data/` — Contexto de base de datos y migraciones

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, abre un issue o pull request para sugerencias o mejoras.

## Licencia

Este proyecto está bajo la licencia IngGonzaloDev.
