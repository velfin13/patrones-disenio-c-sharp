# Patrón de Diseño Singleton

## Descripción:
El patrón Builder se utiliza cuando la construcción de un objeto es compleja y queremos separar la construcción del objeto de su representación. Permite construir diferentes representaciones del mismo objeto utilizando un mismo proceso de construcción.

## Arquitectura

- **Director**: Coordina la construcción de los diferentes componentes.
- **Builder**: Interfaz que define los métodos para construir las partes del producto.
- **ConcreteBuilder**: Implementa la interfaz Builder y construye las partes concretas del producto.
- **Producto**: Representa el objeto complejo que se está construyendo.
- **Cliente**: Utiliza el Director para construir el producto.

### Ventajas:
- **Separación de preocupaciones**: Permite construir un objeto paso a paso y separa la construcción de su representación.
- **Reusabilidad**: Se pueden utilizar los mismos componentes de construcción para construir diferentes representaciones de un objeto.fácilmente a ella.

### Desventajas:

- **Complejidad adicional**: Introduce más clases y puede aumentar la complejidad del código.

### Diagrama

