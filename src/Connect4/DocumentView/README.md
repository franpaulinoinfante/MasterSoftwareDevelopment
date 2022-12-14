# - - - - - Mastermind Practice - - - - -

# Principio de Separación Modelo-Vista mediante la **Arquitectura Document/View**

## Principio de Separación Modelo-Vista (Separated Presentation Pattern).

### Problema:
-	¿Quién debe ser responsable de capturar entradas generada por un agente externo, “persona mediante teclado o ratón, o máquinas mediante señales de un sensor o tramas de red?
-	¿Qué tipo de visibilidad tendrían que tener otros paquetes de la capa de Presentación?
-	¿Cómo deberían de comunicarse las clases que no son ventanas con otras ventanas?

En diferentes contextos el modelo es sinónimo de la Capa del Dominio de los objetos y la vista es un sinónimo para los objetos de la presentación, tales como, ventanas, vista de webs o móviles.

### Solución:
El Principio de Separación Modelo-Vista establece que los objetos del modelo (dominio) no deberían conocer directamente a los objetos de la vista (presentación). Asegurando que cualquier código con el objetivo de manipulas la presentación, solo haga eso “manipular la presentación”, desplazando toda la lógica del dominio y de datos en áreas separadas.<br>
Asociado al sub-patron Principio de Única Responsabilidad “SRP” de SOLID, que ayuda a definir capas lógicas y fisifcas de la arquitectura.

### Beneficios:
Las vistas serán responsables de:<br>
-	Gestionar controles de interfaz: botones, listas, paneles, diálogos…
-	Gestionar su Estado: referidos a los datos actuales mostrados en la interfaz.
-	Gestionar su Lógica: para manipular los controles de interfaz.
-	Gestionar su Sincronización: coordinando su estado con el estado de los objetos de datos y negocio en memoria y/o persistencia

### Motivos:
-	Dar soporte a definiciones de modelos cohesivos que se centren en los procesos del dominio, en lugar de preocuparse de las interfaces de usuario. 
-	Permitir separar el desarrollo de las capas del modelo y la interfaz de usuario.
-	Minimizar el impacto de los cambios de los requisitos de la interfaz sobre la capa del dominio.
-	Permitir que se conecten fácilmente otras vistas a una capa de dominio existente, sin afectar a la capa del dominio.
-	Permitir múltiples vistas simultáneas sobre el mismo modelo del dominio, como una vista de la información sobre las ventas en formato tabular o mediante un diagrama de barras.
-	Permitir la ejecución de la capa del modelo de manera independiente de la capa de interfaz de usuario, como en un sistema de procesamiento de mensajes o en modo de procesamiento por lotes.
-	Permitir trasladar fácilmente la capa del modelo a otro framework de interfaz de usuario.

## Arquitectura Document/View

De forma predeterminada, se crea un esqueleto de aplicación con una clase de documento (modelo) y una clase de vista. Separando la administración de datos en estas dos clases. El documento (modelo) almacena los datos y administra la impresión de los datos y coordina la actualización de varias vistas de los datos. La vista muestra los datos y administra la interacción del usuario con ellos, incluida la selección y edición.<br>
En este modelo, un objeto lee y escribe datos en el almacenamiento persistente. El documento (modelo) también puede proporcionar una interfaz a los datos dondequiera que resida (por ejemplo, en una base de datos). Un objeto de vista independiente administra la presentación de datos, desde la representación de los datos en una ventana hasta la selección y edición de datos por parte del usuario. La vista obtiene los datos de visualización del modelo y comunica al documento los cambios en los datos.<br>
Aunque puede invalidar u omitir fácilmente la separación entre documento y vistas, hay razones atractivas para seguir este esquema en la mayoría de los casos. Una de las mejores es cuando se necesitan varias vistas del mismo documento, como una hoja de cálculo y una vista de gráfico. El modelo de documento/vista permite que un objeto de vista independiente represente cada vista de los datos, mientras que el código común a todas las vistas (como un motor de cálculo) puede residir en el documento. El documento también asume la tarea de actualizar todas las vistas cada vez que cambian los datos.<br>
La arquitectura de documentos y vistas facilitan la compatibilidad con varias vistas, varios tipos de documento, ventanas divisoras y otras características valiosas de la interfaz de usuario.<br>
Lo que busca es crear diferentes vistas para cada parte de la interacción del usuario con el sistema.<br>
Se divide en:
-	En una vista principal compuesta,
-	por una vista por cada caso de uso y cada caso de uso está compuesto,
- por vistas auxiliares por cada modelo que el caso de uso necesite interactuar con cada modelo que se necesite leer o escribir, y si estas vistas auxiliares también necesitan leer de otros modelos se crearan otras sub-vistas. 