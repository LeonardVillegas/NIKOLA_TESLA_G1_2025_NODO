

# Codename: Nikola Tesla's ACDC
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/dracvs/NIKOLA_TESLA_G1_2025_NODO/.github%2Fworkflows%2Fdotnet.yml)


## Abstract

---
Este readme tendrá los comandos resumidos de todo lo hecho hasta la fecha de forma cronológica

### 2025-01-15

```shell
# Verificar que mi .net está en la versión correcta
dotnet --info
dotnet --version

# Crear una solución nueva
dotnet new sln -n TeslaACDC
# Crear un api nuevo
dotnet new webapi -o TeslaACDC.API
# Agregar el api a la solucion
dotnet sln add TeslaACDC.API

# Compilar mi proyecto y revisar que está bien escrito
dotnet build

# Ejecutar mi proyecto
dotnet watch # si estoy en la carpeta del api
dotnet watch --project TeslaACDC.API # si estoy en la carpeta raíz del proyecto donde está la solución.

# Eliminar todos los archivos temporales de construcción
dotnet clean

# Agregar una librería de clase
dotnet new classlib -o TeslaACDC.Business

#Registrar eso en la solución 
dotnet sln add TeslaACDC.Business/

```
