# TicTacToe. Solución 2.1. documentView Basic

### Requisitos 1. Básica

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![TicTacToe](https://user-images.githubusercontent.com/46433173/195204431-936b7ff3-1b33-4167-a362-30ede4d08aec.png) | 
| :------- | :------: |  

### Vista de Lógica/Diseño
- Principio de Separación Modelo-Vista mediante la **Arquitectura Document/View**

#### Principio de Separación Modelo-Vista (Separated Presentation Pattern).
##### Problema:
-	¿Quién debe ser responsable de capturar entradas generada por un agente externo, “persona mediante teclado o ratón, o máquinas mediante señales de un sensor o tramas de red?
-	¿Qué tipo de visibilidad tendrían que tener otros paquetes de la capa de Presentación?
-	¿Cómo deberían de comunicarse las clases que no son ventanas con otras ventanas?

En diferentes contextos el modelo es sinónimo de la Capa del Dominio de los objetos y la vista es un sinónimo para los objetos de la presentación, tales como, ventanas, vista de webs o móviles.<br>
En diferentes contextos el modelo es sinónimo de la Capa del Dominio de los objetos y la vista es un sinónimo para los objetos de la presentación, tales como, ventanas, vista de webs o móviles.
##### Solución:
El Principio de Separación Modelo-Vista establece que los objetos del modelo (dominio) no deberían conocer directamente a los objetos de la vista (presentación). Asegurando que cualquier código con el objetivo de manipulas la presentación, solo haga eso “manipular la presentación”, desplazando toda la lógica del dominio y de datos en áreas separadas.<br>
Asociado al sub-patron Principio de Única Responsabilidad “SRP” de SOLID, que ayuda a definir capas lógicas y fisifcas de la arquitectura.
##### Beneficios:
Las vistas serán responsables de:<br>
-	Gestionar controles de interfaz: botones, listas, paneles, diálogos…
-	Gestionar su Estado: referidos a los datos actuales mostrados en la interfaz.
-	Gestionar su Lógica: para manipular los controles de interfaz.
-	Gestionar su Sincronización: coordinando su estado con el estado de los objetos de datos y negocio en memoria y/o persistencia
##### Motivos:
-	Dar soporte a definiciones de modelos cohesivos que se centren en los procesos del dominio, en lugar de preocuparse de las interfaces de usuario. 
-	Permitir separar el desarrollo de las capas del modelo y la interfaz de usuario.
-	Minimizar el impacto de los cambios de los requisitos de la interfaz sobre la capa del dominio.
-	Permitir que se conecten fácilmente otras vistas a una capa de dominio existente, sin afectar a la capa del dominio.
-	Permitir múltiples vistas simultáneas sobre el mismo modelo del dominio, como una vista de la información sobre las ventas en formato tabular o mediante un diagrama de barras.
-	Permitir la ejecución de la capa del modelo de manera independiente de la capa de interfaz de usuario, como en un sistema de procesamiento de mensajes o en modo de procesamiento por lotes.
-	Permitir trasladar fácilmente la capa del modelo a otro framework de interfaz de usuario.
