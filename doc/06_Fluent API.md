# Fluent API

🔗 [Microsoft documentation](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties)
  
Fluent API en .NET es una técnica utilizada para configurar y personalizar el mapeo entre objetos de dominio y tablas de base de datos en Entity Framework. A diferencia de DataAnnotations, que utiliza atributos directamente en las clases de dominio, Fluent API permite configurar el mapeo de manera más flexible y expresiva mediante llamadas a métodos encadenados.

Aquí hay algunas características clave de Fluent API:

1. Configuración centralizada: Puedes definir la configuración de tus entidades en un solo lugar, lo que facilita la administración y la comprensión.

2. Personalización avanzada: Puedes especificar detalles específicos del mapeo, como nombres de columnas, relaciones, claves primarias y extranjeras, y más.

3. Flexibilidad: Puedes realizar configuraciones condicionales basadas en ciertas condiciones o reglas de negocio. 

4. Separación de preocupaciones: Fluent API separa la configuración de mapeo de las clases de dominio, lo que mejora la legibilidad y el mantenimiento del código.


``` cs
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Configuración con Fluent API
public class ProductConfiguration : EntityTypeConfiguration<Product>
{
    public ProductConfiguration()
    {
        // Tabla y esquema personalizados
        ToTable("Products", "MySchema");

        // Columna personalizada para la propiedad 'Name'
        Property(p => p.Name)
            .HasColumnName("ProductName")
            .HasMaxLength(100)
            .IsRequired();
    }
}
```

En este ejemplo, hemos personalizado la tabla, el esquema y la columna para la propiedad Name utilizando Fluent API.

En resumen, Fluent API es una herramienta poderosa para personalizar el mapeo de entidades en Entity Framework, y se utiliza cuando necesitas configuraciones más avanzadas o cuando prefieres mantener la configuración separada de las clases de dominio.


## Platzi notes

Es una forma avanzada de configurar los 
modelos de Entity Framework sin utilizar 
atributos o data-annotations, permitiendo diseñar 
la base de datos considerando aspectos 
avanzados. 
Se usan funciones de extensión anidadas para 
configurar tablas, columnas y especificar el 
mapeo de los datos. 

``` cs
builder.Entity<Client>(entity =>
{
    entity.ToTable("Client");
    entity.HasKey(e => e.PersonId);
    entity.Property(e => e.ContactName).IsRequired(false).HasMaxLength(300);
    entity.Property(e => e.ContactPhone).IsRequired(false).HasMaxLength(50);
    entity.Property(e => e.Phone2).IsRequired(false).HasMaxLength(50);
    entity.HasOne(e => e.Person)
        .WithOne(e => e.Client)
        .HasForeignKey<Client>(b => b.PersonId)
        .HasConstraintName("FK_Client_Person")
        .OnDelete(DeleteBehavior.SetNull);
 })
```

Fluent API predomina sobre DataAnnotations. EF prepara los scripts sobre DataAnnotations y luego ejecuta *OnModelCreating()*, así que *Fluent API* manda.

