# DataAnnotations 

DataAnnotations en .NET son atributos que se pueden aplicar a clases de entidades o propiedades para anular las convenciones predeterminadas en Entity Framework. Estos atributos están incluidos en los espacios de nombres 
> System.ComponentModel.DataAnnotations 

y

> System.ComponentModel.DataAnnotations.Schema 
 
tanto en EF 6 como en EF Core12.

Aquí hay algunos ejemplos de atributos de DataAnnotations y su función:

- **KeyAttribute**: Indica una o más propiedades que identifican de manera única una entidad.
- **StringLengthAttribute**: Especifica la longitud mínima y máxima permitida para datos de cadena en una propiedad.
- **RequiredAttribute**: Indica que un valor de campo de datos es obligatorio.
- **RegularExpressionAttribute**: Especifica que un valor de campo de datos en ASP.NET Dynamic Data debe coincidir con una expresión regular específica.
- **RangeAttribute**: Define restricciones numéricas para el valor de un campo de datos.
- **DisplayAttribute**: Proporciona una forma de especificar cadenas localizables para tipos y miembros de clases de entidad parciales.
- **EnumDataTypeAttribute**: Permite asignar un enumerado de .NET a una columna de datos.
  
Estos atributos te permiten personalizar la validación, la longitud, las relaciones y otros aspectos del mapeo de tus modelos de datos. Puedes aplicarlos directamente a tus clases o propiedades para influir en cómo Entity Framework interpreta y crea la base de datos subyacente.