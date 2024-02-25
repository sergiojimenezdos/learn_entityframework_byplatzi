## Proyecto con EntityFramework


## Análisis

El proyecto que crearemos para *jugar* con EntityFramework simulará una API para la gestión de tareas diarias.

Se creará un proyecto simple con *Minimal API* para enfocarnos 100% en el manejo de EF.

Las entidades que manejaremos son *Tarea* y *Categoría*

|Task|
|---|
|TaskId|
|CategoryId|
|Title|
|Description|
|Priority|
|CreationDate|


|Category|
|---|
|CategoryId|
|Name|
|Description|


## Creación y configuración del proyecto

### Creación

Nos ubicamos en el directorio donde queramos almacenar el proyecto y ejecutamos el comando necesario para crear un proyecto base de tipo *Minimal API*

> dotnet new web -o projectef

\* *projectef* en el nombre para nuestro proyecto

### Instalación EF

1. Accedemos al portal de [Nuget](https://www.nuget.org/) y buscamos la librería de EF que necesitamos: **Microsoft.EntityFrameworkCore**
2. Seleccionamos e instalamos la última versión disponible que no sea *PREVIEW* y copiamos el comando *.NET CLI*
3. Abrimos el proyecto el VSCode
4. Abrimos una terminal y ejecutamos el comando de instalación.
5. Verificamos que en el archivo *projectef.csproj* nos aparece la referencia al paquete instalado.
6. Realizamos la misma operación para instalar los paquetes:
   1. **Microsoft.EntityFrameworkCore.InMemory** (para crear una base de datos en memoria y poder probar el modelo que vamos a utilizar)
   2. **Microsoft.EntityFrameworkCore.SqlServer** (para conectarnos al motor *SQL Server*)