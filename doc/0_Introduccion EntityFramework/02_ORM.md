# ORM

Acceder y manejar una base de datos conlleva los siguientes retos:
- Mantenimientos del esquema
- Creación de consultas SQL para comunicarnos con la base de datos
- Transformar los datos para ser consumidos por el backend
- Garantizar la seguridad de los datos. Incluye controlar el acceso no autorizado y la manipulación indebida. Especial atención la técnica de hacking *SQL Injection*.

## ¿Qué es un ORM?

> **O**bject **R**elational **M**apping

Un ORM es un modelo de programación que permite mapear las estructuras de una base de datos relacional (como SQL Server, Oracle o MySQL) sobre una estructura lógica de entidades. Su objetivo es simplificar y acelerar el desarrollo de aplicaciones.

En otras palabras, un ORM actúa como un puente entre el mundo de las bases de datos relacionales y los lenguajes de programación orientados a objetos, como Java o C#. Algunas de sus características clave son:

1. Mapeo: El ORM asigna las tablas y relaciones de la base de datos a objetos en el código, lo que facilita la manipulación de datos.
2. Eliminación de SQL manual: Los ORMs nos liberan de escribir o generar manualmente código SQL para realizar consultas y gestionar la persistencia de datos en la base de datos. Las acciones CRUD (Create, Read, Update, Delete) se realizan de forma indirecta a través del ORM. 
3. Persistencia automática: Los ORMs ofrecen servicios para persistir cambios en las entidades sin necesidad de escribir una sola línea de SQL.
4. Ejemplos de ORM en el mercado:
   1. Hibernate (usado por Java)
   2. NHibernate (versión de Hibernate para c# y .NET)
   3. Dapper (open source, no es el más completo o poderoso)
   4. Django ORM (dentro del mundo python)
   5. **Microsoft Entity Framework** (ORM principal en .NET, es más popular y completo)

En resumen, los ORMs son herramientas valiosas para desarrolladores, ya que simplifican la interacción con bases de datos relacionales y agilizan el proceso de creación de aplicaciones. Aunque no nos olvidamos completamente del SQL al usar un ORM, su uso puede mejorar significativamente la productividad y el rendimiento global de nuestras aplicaciones.