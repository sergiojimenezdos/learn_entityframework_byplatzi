# Entity Framework (introducción)

## Introducción

- ORM de **código abierto** de .NET
- Utiliza **ADO.NET** para establecer la conexión a las bases de datos
- Es compatible con 
  - SQL Server
  - Azure SQL Database
  - SQLLite
  - Azure Cosmos DB
  - MySQL
  - PostgreSQL
- Existen 2 versiones
  - Entity Framework (para .Net Framework)
  - Entity Framework Core (para .Net Core). Este nombre está siendo modificado a *Entity Framework* a secas dado que .Net Framework está quedando en desuso.


## Ventajas de EF
- **Permite manejar un único repositorio** para 
backend y base de datos. Si no queremos no es necesario ir a la base de datos directamente a crear componentes, se puede manejar todo desde un único punto.
- **Mejora la seguridad**. Control fácil para el tipado de datos, control de *SQL Injection*, seguridad de conexión.
- **Abstracción de la base de datos**: EF proporciona una abstracción de alto nivel sobre la base de datos subyacente. Los desarrolladores pueden trabajar con objetos y relaciones en lugar de escribir consultas SQL directamente. Esto simplifica el desarrollo y reduce la cantidad de código necesario.
- **Productividad**: Al utilizar EF, los desarrolladores pueden centrarse en la lógica de negocio y no en los detalles de acceso a datos. Las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) se realizan de manera más eficiente y con menos código.
- **Consultas LINQ**: EF permite escribir consultas LINQ (Language Integrated Query) para recuperar datos. Esto facilita la escritura de consultas de manera declarativa y legible.
- **Seguimiento de cambios**: EF realiza un seguimiento automático de los cambios en las entidades. Cuando se llama al método SaveChanges(), los cambios se sincronizan con la base de datos. También proporciona el método asíncrono SaveChangesAsync().
- **Concurrencia optimista**: EF maneja la concurrencia de manera predeterminada. Esto significa que detecta conflictos cuando varios usuarios intentan modificar los mismos datos al mismo tiempo.
- **Soporte multiplataforma**: EF es compatible con varias bases de datos, incluyendo SQL Server, MySQL, PostgreSQL, SQLite y Azure Cosmos DB.