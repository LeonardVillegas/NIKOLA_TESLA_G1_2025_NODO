

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

# Agregar una libreria de clase
dotnet new classlib -o TeslaACDC.Business

# Agregarlo a la solución
dotnet sln add TeslaACDC.Business/

# Agregar una libreria de clase
dotnet new classlib -o TeslaACDC.Data

# Agregarlo a la solución
dotnet sln add TeslaACDC.Data/

# Agregar un proyecto de Testing
# Guardar la colección de Bruno en Ese proyecto.
```

# Convenciones

- Un DTO (Data Transport Object) No tiene métodos.
- Por lo regular se guardan como structs
- un booleano, se debe escribir siempre como un verbo y una pregunta dicotómica i.e:
    - IsAdmin yes/no
    - IsCorrect yes/no
    - IsEnabled yes/no
    - HasAttributes yes/no

## Tarea 
Para la casa, entregable el lunes 20 de Enero de 2025 5:59


1ro: debe devolver una array de albums
2do: debe recibir dos valores y sumarlos, devolver el resultado
3ro: debe calcular el area de un cuadrado.
4to: Calcular area de un triangulo
5to: Calcular el área de un cuadrado recibiendo todos los lados.
Extra Curricular
6to: PONER EL PIPELINE DE GITHUB A FUNCIONAR

# Semana #2

- Corregir el ASYNC y el AWAIT en todos mis métodos y todos mis controladores
- Quitar los metodos del DTO
- Quitar la palabra DTO en el nombre del DTO a los DTOS
- Corregir que los Business solo devuelvan el resultado y nada más. Quitar los mensajes de String.
- LINQ (LINK o LIN-Q)
- acciones de un CRUD
    - Buscar por ID
    - Buscar por Nombre
    - Agregar
    - Editar
    - Eliminar
    - Buscar por Artista

- Instalar BeeKeeper
- Crear una cuenta de SupaBase [https://supabase.com]
- Entity Framework + Migraciones.

- Buscar por nombre
- Buscar por año de publicación
- Buscar por rango de publicación (año de inicio, año final)
- Buscar por nombre de artista
- Buscar por Genero (album)



