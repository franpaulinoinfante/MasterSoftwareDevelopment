# Modelo del Dominio

**Índice**
- [Análisis y Diseño](#Análisis-y-Diseño)  
- [Modelo del Dominio](#Modelo-del-dominio)  
    - [Estrategias de Clasificación](#Estrategias-de-clasificación)  
    - [Descripción Informal](#Descripción-Informal)  
    - [Análisis Clásico](#Análisis-Clásico)  
    - [Análisis del Dominio](#Análisis-del-Dominio)  
    - [Análisis del Comportamiento](#Análisis-del-Comportamiento)  
    - [Patrón de Experto en la Información](#Patrón-de-Experto-en-la-Información)  
    - [Análisis de Casos de Uso](#Análisis-de-Casos-de-Uso)  
    - [Antipatrón "Descomposición Funcional"](#Antipatrón-Descomposición-Funcional)  
- [Relaciones entre Clases Básicas](#Relaciones-entre-Clases-Básicas)  
    - [Relaciones de Dependencia por Colaboración entre Objetos](#Relaciones-de-Dependencia-por-Colaboración-entre-Objetos)  
        - [Relación de Composición](#Relación-de-Composición)  
        - [Relación de Agregación](#Relación-de-Agregación)  
        - [Relación de Asociación](#Relación-de-Asociación)  
        - [Relación de Uso](#Relación-de-Uso)  
- [Relaciones de Dependencia por Transmisión entre Clases](#Relaciones-de-Dependencia-por-Transmisión-entre-Clases)  
    - [Herencia por especialización](#Herencia-por-especialización)  
    - [Herencia por extensión](#Herencia-por-extensión)  

## Análisis y Diseño

¿Qué es el diseño?
- Traza o delineación de un edificio o de una figura.
- Proyecto, plan que configura algo.
- Concepción original de un objeto u obra destinados a la producción en serie.
- Forma de un objeto de *diseño*. El diseño de esta silla es de inspiración modernista.
- Descripción o bosquejo verbal de algo.

**Análisis**<br/>
Analizar los requisitos a través de su refinamiento y estructura para realizar una compresión más precisa de los requisitos, una descripción de los requisitos que es fácil de mantener y ayuda a estructurar el sistema:
- Dar una especificación más precisa de los requisitos obtenidos en la captura de requisitos.
- Describir usando el lenguaje de los desarrolladores y poder introducir más formalismo y ser utilizado para razonar sobre el funcionamiento interno del sistema.<
- Estructurar los requisitos de manera que facilite su comprensión, cambiándolos y, en general, mantenerlos.
- Acercase al diseño, aunque sea un modelo en sí mismo, y es por tanto un elemento esencial cuando el sistema está conformado en diseño e implementación.

**Diseño** <br/>
Desarrollar enfocados en los requisitos no funcionales y en el dominio de la solución para preparar para la implementación y pruebas del sistema:
- Adquirir una comprensión profunda sobre los aspectos de los requisitos no funcionales y limitaciones relacionadas con:
- los lenguajes de programación,
- la reutilización de componentes,
- sistemas operativos
- tecnologías de distribución y concurrencia
- tecnologías de bases de datos
- tecnologías de interfaz de usuario
- tecnologías de gestión de transacciones
- y así sucesivamente.

## Modelo del Dominio

**Origen** *de identificadores del problema/solución*<br?>

Describe los conceptos más importantes (tipos de objetos) del contexto como objetos del dominio y los enlaces de éstos con otros.

Los objetos pueden ser:
- **Objetos de negocio:** que representan cosas que son manipuladas en un negocio.
- **Objetos del mundo real y conceptos** que un sistema necesita manipular.
- **Eventos:** que ocurrirán o han ocurridos.
- **Nunca del software del sistema:** vista, validador, ¡etc.…!

Los objetivos del modelo de dominio son:
- **Comprender la estructura y dinámica** de la organización en la que el sistema se desarrollara.
- **Comprender los problemas actuales** de la organización destino e identificar mejoras potenciales.
- **Asegurar que los clientes, usuarios finales y desarrolladores** tienen compresión común de la organización destino.
- **Primera aproximación a la obtención de los requisitos** del sistema para apoyar a la organización destino.

El modelo del dominio se obtiene en talleres/reuniones por parte de:
- **Analistas del dominio**,
- **Expertos del dominio** y,
- **Personas con habilidades de modelar**

El modelo del dominio se describe utilizando el Lenguaje Unificado de Modelado (UML) utilizando los diagramas de:
- **Clases**,
- **Objetos**,
- **Actividad** y,
- **Estado**

"*Cuando los programadores piensan en los problemas, en términos de comportamientos y responsabilidades de los objetos, traen con ellos un caudal de intuición, ideas y conocimientos provenientes de su experiencia diaria*" - Budd [Programación Orientada a Objetos. 1994]

*"En lugar de un saqueador de bits que saquea estructuras de datos, nosotros tenemos un universo de objetos con buen comportamiento que cortésmente se solicitan entre sí cumplir diversos deseos"* - Ingalls [Design Principles Behind Smalltalk. Byte vol. 6(8)]

## Estrategias de Clasificación

Permiten clasificar los objetos.

## Descripción Informal

Abbott sugiere escribir una descripción del problema (o una parde de un problema) y luego subrayar los **sustantivos y verbos** . Los **nombres representan objetos candidatos,** y los **verbos representan operaciones candidatos en ellos.** Este enfoque es útil porque es simple y porque obliga a los desarrolladores a trabajar en el **vocabulario del espacio del problema**. <br/>
Inconvenientes:
- *No es un enfoque riguroso* y sin duda *no escala bien* para nada más allá de problemas bastantes triviales. El lenguaje humano es un vehículo de expresión tremendamente impreciso, por lo que la calidad de la lista resultantes de los objetos y las operaciones depende de la habilidad de escritura de su autor: *sinónimos, ánforas, metáforas.*
- Por otra parte, cualquier sustantivo puede ser un verbo, y cualquier verbo puede ser un sustantivo. **cosificación**. Ejemplos: [gestionar – gestión], [oxigenar – oxigeno], [pulsar – pulso]…

## Análisis Clásico

Un número de metodólogos han propuesto diversas fuentes de clases y objetos, derivados de los requisitos del dominio del problema:
- **Cosas, objetos físicos o grupos de objetos que son tangibles:** coches, datos de telemetría, sensores de presión, …​
- **Conceptos, principios o ideas no tangibles** per se utilizados para organizar o realizar un seguimiento de las actividades comerciales y/o comunicaciones: préstamo, reunión, intersección.
- **Gente, seres humanos** que llevan a cabo alguna función, usuarios que juegan diferentes roles en la interacción con la aplicación: madre, profesor, político.
- **Organizaciones, colecciones formalmente organizadas de personas y recursos** que tienen una misión definida, cuya existencia es en gran medida independiente de los individuos.
- **Lugares físicos, oficinas y sitios** importantes para la aplicación: zonas reservadas para personas o cosas.
- **Dispositivos** con los que interactúa la aplicación.
- **Otros sistemas de sistemas externos** con los que interactúa la aplicación.
- **Cosas que pasan,** por lo general de otra cosa en una fecha determinada, eventos: aterrizaje, interrumpir, solicitud

## Análisis del Dominio

Un intento para identificar **los objetos, las operaciones y las relaciones [son los que] los expertos de dominio** perciben como importantes sobre el dominio.
- Un experto del dominio normalmente no será un desarrollador de software; más comúnmente, él o ella es simplemente una **persona que está íntimamente familiarizado con todos los elementos de un problema** particular.
- Un experto del dominio habla el **vocabulario del dominio problema.**
- A menudo, un experto del dominio es **simplemente un usuario,** como un ingeniero del tren o expendedor en un sistema ferroviario, o una enfermera o un médico en un hospital.

## Análisis del Comportamiento

Mientras que estos enfoques clásicos se centran en cosas tangibles en el dominio del problema, otra escuela de pensamiento en el análisis orientado a objetos se** centra en el comportamiento dinámico** como la fuente primaria de clases y objetos.
- **"el conocimiento que un objeto mantiene y las acciones que un objeto puede realizar.** Las responsabilidades tienen el propósito de transmitir un sentido de la finalidad de un objeto y su lugar en el sistema. Las responsabilidades de un objeto son todos los servicios que presta a todos los contratos que apoya. - Rebecca Wirfs-Brock; Wilkerson y Wiener

## Patrón de Experto en la Información

Existen dos tipos básicos de obligaciones de un objeto en términos de su comportamiento/responsabilidad:
- **Responsabilidad de conocer de un objeto:** sobre unos datos privados encapsulados, sobre objetos relacionados, y sobre las cosas que pueden obtener o calcular.
- **Responsabilidad de hacer de un objeto:** algo en sí mismo, como la creación de un objeto o hacer un cálculo, iniciar acciones en otros objetos y el control y la coordinación de actividades en otros objetos.
    - Se implementan utilizando métodos que, o bien actúan solos o colaboran con otros métodos y objetos. **Una responsabilidad no es lo mismo que un método y se ve influida por la granularidad de la responsabilidad.**
        - *El acceso a las bases de datos relacionales puede implicar decenas de clases y cientos de métodos, empaquetados en un subsistema.*
        - *Por el contrario, la responsabilidad de "crear una venta" puede implicar sólo uno o unos métodos.*
- Aplicación directa del modelo del dominio, con una **analogía en el mundo real,** como muchas cosas en la tecnología de objetos. Conduce a diseños en los que un objeto de software hace las **operaciones que realizan normalmente las cosas del mundo real inanimadas** a las que representa.
- **Principio general de la asignación de responsabilidades a los objetos. Asignar la responsabilidad a la clase que tiene la información necesaria para cumplir con la responsabilidad.**
- Tenga en cuenta que el cumplimiento de una responsabilidad a menudo requiere la información que se transmite a través de diferentes clases de objetos. Esto implica que hay **muchos expertos "parciales" de información** que colaborarán en la tarea.
    - A medida que los **miembros del equipo caminan a través del escenario,** pueden asignar **nuevas responsabilidades a una clase existente, agrupar ciertas responsabilidades** para formar una nueva clase, o más comúnmente, **dividen las responsabilidades** de una clase en más de grano fino y **distribuyen estas responsabilidades** a clases diferentes.

## Análisis de Casos de Uso

A medida que el equipo se guía a **través de cada escenario de cada caso de uso,** se deben **identificar los objetos** que participan en el escenario, **las responsabilidades de cada objeto,** y las formas en esos **objetos colaboran con otros objetos,** en términos de las operaciones de cada uno invoca en el otro. De esta manera, el equipo se ve obligado a elaborar una clara separación de las responsabilidades entre todas las abstracciones.
- Entonces se procede por un estudio de cada escenario, posiblemente utilizando técnicas similares a las **prácticas de la industria de la televisión: storyboard (guión gráfico) y películas.**
- **No es necesario profundizar** en estos escenarios al principio; simplemente podemos enumerarlos. Estos escenarios describen colectivamente las funciones del sistema de la aplicación.
    - A medida que continúa el proceso de desarrollo, estos **escenarios iniciales se ampliaron para considerar las condiciones excepcionales,** así como los comportamientos secundarios del sistema. Los resultados de estos escenarios secundarios introducen nuevas abstracciones para añadir, modificar o reasignar las responsabilidades de abstracciones existentes.
- Los escenarios también sirven como la base de las **pruebas del sistema.**

## Antipatrón "Descomposición Funcional"

**Cuidado!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!** con este antipatrón.

**Autor**: William Brown

Síntomas:
- Clases con nombres de función
- Clases con un solo método.
- abuso de miembros estáticos.
- Ausencia de principios orientados a objetos, como herencia, polimorfismo, etc...

Justificación:
- Imposible de comprender el software, de reutilizar, de probar, etc...

Solución:
- Aplicar el Modelo de Dominio Orientado a Objeto

## Relaciones entre Clases Básicas

| **Dependencia** es la nueva forma de referirse a una relación entre calses. | *"Un objeto en si mismo no es interesante. Los objetos contribuyen al comportamiento de un sistema colaborando con otros objetos."* — Grady Booch Análisis y Diseño Orientado a Objetos. 1996. | 
| :------- | :------: |  

### Tipos de Relaciones entre Clases:  
- Relaciones/Dependencias por Colaboración entre Objetos
    - si dos objetos colaboran, a través del paso de mensajes, sus respectivas clases están relacionadas.
    - Tipos de relación por colaboración:
        - Relación de Composición/Agregación
        - Relación de Asociación
        - Relación de Dependencia (Uso)
- Relaciones/Dependencias por Transmisión entre Clases
    - si una clase transmite a otra todos sus miembros, atributos y métodos, para organizar una jerarquía de clasificación, sin negar ni obligar a la colaboración entre objetos de las clases participantes.
    - Tipos de relación por transmisión:
        - Relación de Herencia por Extensión
        - Relación de Herencia por Implementación

## Relaciones de Dependencia por Colaboración entre Objetos

### Caracteristicas de las relaciones por Colaboración:

- Visibilidad: Con el objetivo de maximizar el nivel de encapsulación, la visibilidad que un objeto tiene de otro es un aspecto que debe tenerse en cuenta al crear relaciones, la visiblidad se restringe definiendo el carácter públicos, privados y protedigos entre dos objetos, y cuales son las interfaces, o sea, si otros objetos colaboran o no con el objeto que recibe el mensaje.
- Temporabilidad: Cualquier relación entre objetos o entre clases tiene una duración temporal. Hay relaciones entre objetos que se dan en un ambito muy restringido (por ejemplo, dentro de un método) y hay relaciones entre objetos que abarcan toda la vida de los objetos (por ejemplo, en las propiedades). Se debe prestar atención al estudio de la temporalidad de una relación porque ayuda a definir el tipo de relación, aunque en igualdad de condiciones se prefiere una baja temporalidad, pues, esto implica mayor independencia y menor coste de recursos. [mayor o menor duración de la colaboración entre dos objetos que colaboran].
- Versatilidad: Un objeto se dice que es versátil si puede combinarse con otros objetos de diversas maneras para dar lugar a diferentes comportamientos. [Intercambiabilidad de los objetos en la colaboración con otros objetos]. Por ejemplo, una clase Pila que pueda almacenar cualquier tipo de objeto es una clase más versátil que una clase Pila que sólo permita almacenar números enteros. En general, es preferible hacer código versátil, pues facilita su reutilización en diferentes problemas. Sin embargo, un código excesivamente versátil puede ser que se ajuste poco a un problema particular que se esté resolviendo y que, con ello, se dificulte la programación en vez de simplificarla. Por tanto, al desarrollar un programa, es importante estudial cuál es el nivel de versatilidad que interesa para la clase e interfaces que se van a crear, en el contexto del problema que se está resolviendo.

## Relación de Composición

Es la relación que se constituye entre **el todo y la parte.**
- Se puede determinar que existe una relación de c**omposición entre la clase A, el todo, y la clase B, la parte si:**
    - si un objeto de la clase A “tiene un” objeto de la clase B.
Ejemplos:
- La relación de composición no abarca simplemente **cuestiones físicas** (*libro -todo- y páginas -parte-*) sino,
    - como **“contiene un”** (*aparato digestivo -todo- y bolo alimenticio -parte-*).
- también, a **relaciones lógicas** que respondan adecuadamente al todo y a la parte.
    - como **“posee un”** (*propietario -todo- y propiedades -parte*-).  

| Caracteristicas | Notación UML | Código C# |
| --- | --- | --- |
| Visibilidad: **Privada** <br/> Temporabilidad: **Alta** <br/> Versatilidad: **Baja**| Foto Aqui | foto aqui |


- **Implantación mediante atributos y creación en el constructor o …​
    - referencias privadas con ciclo de vida igual al objeto


## Relación de Agregación

La agregación debil o compartida son asociaciones en las que una parte contiene a elementos de otra parte. Normalmente responden a la pregunta "tiene un".<br/>

| Caracteristicas | Notación UML | Código C# |
| --- | --- | --- |
| Visibilidad: **Pública** <br/> Temporabilidad: **Alta/Media** <br/> Versatilidad: **Baja**| Foto Aqui | foto aqui |

- Implantación mediante atributos y métodos de inserción, borrrado o …​
    - referencias privadas con ciclo de vida igual al objeto

Comparación entre Relación de Composición y Agregación:
| Composición | Agregación |
| --- | --- |
| es una composición donde la vida del objetos de la clase contenida debe coincidir con la vida de la clase contenedor. | Los componentes constituyen una parte del objeto compuesto. |  
| Los componentes constituyen una parte del objeto compuesto. | Los componentes constituyen opcionalmente una parte del objeto compuesto. |
| La supresión del objeto compuesto conlleva la supresión de los componentes. | La destrucción del compuesto no conlleva la destrucción de los componentes. |
| los componentes no pueden ser compartidos por varios objetos compuestos. | Los componentes pueden ser compartidos por varios compuestos. |
| composición fuerte | composición débil |
| Clases persona y cabeza: una cabeza solo puede pertenecer a una persona y no puede existir una cabeza sin su persona, no va a su funeral | Clases persona y cabeza: una cabeza solo puede pertenecer a una persona y no puede existir una cabeza sin su persona, no va a su funeral |

## Relación de Asociación

Es la relación que perdura entre un cliente y un servidor determinado. 
- Existe una relación de **asociación entre la clase A, el cliente, y la clase B, el servidor, si un objeto de la clase A disfruta de los servicios de un objeto determinado de la clase B (mensajes lanzados) para llevar a cabo la responsabilidad del objeto de la clase A en diversos momentos** creándose una dependencia del objeto servidor.
- Especifica una conexión semántica entre objetos no relacionados.
- Representan relaciones propias del dominio del problema, que no tienen las caracteristicas de la generalización (una clase es subclase de otra) o de la agregación (una clase se compone de otras). 
- La relación de asociación no abarca simplemente **cuestiones tangibles.**
    - como “provecho”, procesador -cliente- y memoria -servidor-, socio -cliente- y club -servidor-, …
- también a **cuestiones lógicas** que respondan adecuadamente al cliente y al servidor determinado.
    - como “beneficio”, empresa -cliente- y banca -servidor-, etc.

| Caracteristicas | Notación UML | Código C# |
| --- | --- | --- |
| Visibilidad: **Pública** <br/> Temporabilidad: **Alta/Media** <br/> Versatilidad: **Baja**| Foto Aqui | foto aqui |

Implantación mediante atributos y constructor, métodos de asociación o …​<br/> referencias privadas con ciclo de vida igual al objeto.

## Relación de Uso

Es la relación que se establece momentáneamente **entre un cliente y cualquier servidor.**
- Existe una **relación de uso entre la clase A, el cliente, y la clase B, el servidor, si un objeto de la clase A disfruta de los servicios de un objeto de la clase B (mensajes lanzados) para llevar a cabo la responsabilidad del objeto de la clase A en un momento** dado sin dependencias futuras.
    - La relación de uso no abarca simplemente **cuestiones tangibles.**
        - ciudadano -cliente- y autobús -servidor-
    - también a **cuestiones lógicas** que respondan adecuadamente al cliente y al servidor momentáneo cualquiera que sea.

| Caracteristicas | Notación UML | Código C# |
| --- | --- | --- |
| Visibilidad: **Pública y Privada** <br/> Temporabilidad: **baja** <br/> Versatilidad: **Alta** | ![image](https://user-images.githubusercontent.com/46433173/201494031-5fe7286f-974e-43aa-ac0d-8a3ba2106037.png) | ![image](https://user-images.githubusercontent.com/46433173/201494509-cf349760-26f5-4721-97c9-aabb9ba2869f.png) |


- Implantación mediante parámetros o variables locales de métodos o mediante referencias con ciclo de vida igual a la ejecución del método

### Comparativa de Relaciones entre Clases por Colaboración

![image](https://user-images.githubusercontent.com/46433173/201493977-8e7d98fb-9ff0-42fd-ad20-0014bbf1dafa.png)

| Sin duda, falta mencionar el factor más determinante a la hora de decidir la relación entre las clases: el **contexto** en el que se desenvuelvan los objetos. Éste **determinará de forma “categórica” qué grados de visibilidad, temporalidad y versatilidad se producen en su colaboración.** | Si el contexto de los objetos paciente y médico es un hospital de urgencias la relación se decantaría por un uso mientras que si es el médico de cabecera que conoce su historial y tiene pendiente algún tratamiento, la relación se inclinaría a una asociación;<br/> Si el contexto de los objetos motor y coche es un taller mecánico (se accede al motor de un coche, se cambian motores a los coches, etc.) la relación se inclinaría a una asociación, mientras que si el contexto es la gestión municipal del parque automovilísticos (se da de alta y de baja al coche, se denuncia al coche, etc. y el motor se responsabiliza de ciertas características que dependen del ministerio de industria como su potencia fiscal, etc.) la relación se inclinaría a una composición |
| :------- | :------: | 

## Relaciones de Dependencia por Transmisión entre Clases

## Herencia por especialización

## Herencia por extensión


