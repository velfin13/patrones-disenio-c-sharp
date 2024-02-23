
# Patrón de Diseño Singleton

## Descripción:
El patrón Singleton se utiliza para garantizar que una clase tenga una única instancia y proporciona un punto de acceso global a esa instancia. Esto es útil cuando se desea tener un solo objeto responsable de coordinar acciones en todo el sistema, como un administrador de configuración, un administrador de conexiones o un registro de eventos.

## Arquitectura

- **Clase Singleton**: Una clase que tiene un único punto de acceso y una única instancia en toda la aplicación.
- **Constructor Privado**: El constructor de la clase es privado para evitar la creación de instancias mediante un constructor público.
- **Método estático de obtención de instancia**: Proporciona un punto de acceso global a la única instancia de la clase.

### Ventajas:

- **Control de acceso**: El patrón Singleton garantiza que solo haya una instancia de la clase, lo que controla el acceso a esa instancia.
- **Eficiencia**: Evita la creación de múltiples instancias de una clase, lo que puede ser costoso en términos de recursos.
- **Globalmente accesible**: Proporciona un punto de acceso global a la instancia única, permitiendo a otras clases acceder fácilmente a ella.

### Desventajas:

- **Acoplamiento**: Puede introducir un acoplamiento fuerte en el código, ya que las clases dependen de la instancia única.
- **Testing**: Puede ser difícil de probar, ya que la instancia única persiste durante toda la ejecución y puede afectar a otros casos de prueba.

### Diagrama de clase
![imagen](https://github.com/velfin13/patrones-disenio-c-sharp/assets/57650704/7b20a2a8-848d-40ae-9360-2f9b46535ac5)


