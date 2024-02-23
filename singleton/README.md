# Patrón de Diseño Singleton

## Arquitectura

El patrón Singleton es un patrón de diseño creacional que garantiza que una clase tenga una única instancia y proporciona un punto de acceso global a esa instancia

## Descripción:
En el patrón Singleton, la clase tiene un constructor privado y una propiedad estática que devuelve la única instancia de la clase. La primera vez que se solicita la instancia, se crea y se almacena en una variable estática. En las solicitudes subsiguientes, se devuelve la instancia existente.

### Ventajas:

- Control de acceso: El patrón Singleton garantiza que solo haya una instancia de la clase, lo que controla el acceso a esa instancia.
- Eficiencia: Evita la creación de múltiples instancias de una clase, lo que puede ser costoso en términos de recursos.
- Globalmente accesible: Proporciona un punto de acceso global a la instancia única, permitiendo a otras clases acceder fácilmente a ella.

### Desventajas:

- Acoplamiento: Puede introducir un acoplamiento fuerte en el código, ya que las clases dependen de la instancia única.
- Testing: Puede ser difícil de probar, ya que la instancia única persiste durante toda la ejecución y puede afectar a otros casos de prueba.
