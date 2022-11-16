# -------- Connect4 Document/View Architecture --------

**índice**
- [Requisitos](#Requisitos)  
- [Casos de Uso](#Casos-de-Uso)  
    - [Especificación de Caso de Uso Start](#Especificación-de-Caso-de-Uso-Start)  
    - [Especificación de Caso de Uso Play](#Especificación-de-Caso-de-Uso-Play)  
    - [Especificación de Caso de Uso Resume](#Especificación-de-Caso-de-Uso-Resume)  
    - [Prototipo de Interfaz](#Prototipo-de-Interfaz)
        - [Interfaz Máquina](#Interfaz-Máquina)  
        - [Interfaz Jugador y Máquina](#Interfaz-Jugador-y-Máquina)  
        - [Interfaz 2 Jugadores](#Interfaz-2-Jugadores)  
- [Análisis](#Analisis)  
    - [Análisis de la Arquictura](#Análisis-de-la-Arquictura)  
    - [Análisis de las vistas](#Análisis-de-las-vistas)  
    - [Análisis de los Modelos](#Análisis-de-los-Modelos)  
    - [Análisis de caso de uso Start](#Análisis-de-caso-de-uso-Start)  
    - [Análisis de caso de uso Play](#Análisis-de-baso-de-uso-Play)  
    - [Análisis de caso de uso Resume](#Análisis-de-baso-de-uso-Resume)  
    - [Vista de Análisis](#Vista-de-Análisis)  
        - [Análisis Clases de Vistas](#Análisis-Clases-de-Vistass)  
        - [Análisis Clases de Modelos](#Análisis-Clases-de-Modelos)  
        - [Análisis Clases de Tipos](#Análisis-Clases-de-Tipos)  
        - [Análisis Clases de Utils ](#Análisis-Clases-de-Utils)  
- [Vista de Lógica/Diseño](#Vista-de-Lógica-Diseño) 
    - [Arquitectura](#Arquitectura)  
    - [Diseño de caso de uso Start](#Diseño-de-caso-de-uso-Start)  
    - [Diseño de caso de uso Play](#Diseño-de-caso-de-uso-Play)  
    - [Diseño de caso de uso Resume](#Diseño-de-caso-de-uso-Resume)  
    - [Namespace ConsoleIOs](#Namespace-ConsoleIOs)  
    - [Namespace Models](#Namespace-Models)  
    - [Namespace Types](#Namespace-Types)  
    - [Namespace Utils](#Namespace-Utils)  

## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199308347-025f54a1-49fc-4a3e-9385-aabbbf493ded.png) | 
| :------- | :------: |  

## Casos de Uso

|  Vista de Caso de Uso  |  Contexto de Casos de Uso  | 
| :------- | :------: |  
| ![image](https://user-images.githubusercontent.com/46433173/202189687-6d1c8a99-087a-441f-b1ce-f3cd098b8690.png)  |  ![image](https://user-images.githubusercontent.com/46433173/202190975-52e7edb2-a56d-4ded-8d08-b732846573de.png) |

### Especificación de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/202204734-91866dbc-4b80-43cb-849c-9d0974902699.png)

### Especificación de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/202204452-ed4d3670-6ef8-4a5a-8ab6-dc45b3ca49fe.png)

### Especificación de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/202204530-7930f74f-c224-478b-a9cb-aecbbdcb53f5.png)

### Prototipo de Interfaz
#### Interfaz Máquina
```
Enter the players: 0
--- CONNECT 4 ---
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
----------------------
Turn: X
Aleatoriamente en la columna: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   | X |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 0
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   |   | X |   |   |
----------------------
Turn: X
Aleatoriamente en la columna: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   |   | X | X |   |
----------------------
Turn: O
Aleatoriamente en la columna: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   | O | X | X |   |
----------------------
Turn: X
Aleatoriamente en la columna: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   | X |   |   |
 | O |   |   | O | X | X |   |
----------------------
Turn: O
Aleatoriamente en la columna: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   | X |   |   |
 | O |   |   | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 0
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   |   |   | X |   |   |
 | O |   |   | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   |   |   | X |   |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   |   |   | X | X |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 | X |   |   |   | X | X |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 |   |   |   |   |   | O |   |
 | X |   |   |   | X | X |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 0
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   |   |   | X | X |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   | X |   | X | X |   |
 | O |   | O | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   | X |   | X | X | O |
 | O |   | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   | X |   | X | X | O |
 | O |   | O | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 0
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   | X |   | X | X | O |
 | O |   | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X |   | X |   | X | X | O |
 | O | X | O | O | X | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X | O | X |   | X | X | O |
 | O | X | O | O | X | X | O |
----------------------
Turn: X
Aleatoriamente en la columna: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | X |   |
 | O |   |   |   |   | X |   |
 | O |   |   |   |   | O |   |
 | X | O | X | X | X | X | O |
 | O | X | O | O | X | X | O |
----------------------
X WIN!!! : -)
Do you want to continue? (y/n)y
```
#### Interfaz Jugador y Máquina 
```
Enter the players: 1
--- CONNECT 4 ---
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | X | O |   |   |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 0
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O | X | O |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X |   |   |   |   |
 | O | X | O |   |   |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O | X |   |   |   |   |
 | O | X | O |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X | O | X |   |   |   |   |
 | O | X | O |   |   |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X |   |   |   |   |
 | O | X | O |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X |   |   |   |   |
 | O | X | O | X |   |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X |   |   |   |   |
 | O | X | O | X | O |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X |   | X |   |   |
 | O | X | O | X | O |   |   |
----------------------
Turn: O
Aleatoriamente en la columna: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X |   | X |   |   |
 | O | X | O | X | O |   | O |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   |   |   |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O |   | O |
----------------------
Turn: O
Aleatoriamente en la columna: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   | O |   |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O |   | O |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | O |   | O | X |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O |   | O |
----------------------
Turn: O
Aleatoriamente en la columna: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | O |   |   |   |
 |   | O |   | O | X |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O |   | O |
----------------------
Turn: X
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | O |   |   |   |
 |   | O |   | O | X |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O | X | O |
----------------------
Turn: O
Aleatoriamente en la columna: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | O | O |   |   |
 |   | O |   | O | X |   |   |
 | X | O | X | X | X |   |   |
 | O | X | O | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | O | O |   |   |
 |   | O |   | O | X |   |   |
 | X | O | X | X | X | X |   |
 | O | X | O | X | O | X | O |
----------------------
X WIN!!! : -)
Do you want to continue? (y/n)y
```
#### Interfaz 2 Jugadores
```
Enter the players: 2
--- CONNECT 4 ---
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   | X |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   | X |   | O |   |
----------------------
Turn: X
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   | X | X |   | O |   |
----------------------
Turn: O
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   | X | X | O | O |   |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   | X | X | O | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   |   |   |   |
 | O |   | X | X | O | O | X |
----------------------
Turn: X
Enter a colunm to drop a token: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   |   |   |   |
 | O | X | X | X | O | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   | O |   |   |
 | O | X | X | X | O | O | X |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   | O |   | X |
 | O | X | X | X | O | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O | O | O |   | X |
 | O | X | X | X | O | O | X |
----------------------
Turn: X
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   | O | O | O |   | X |
 | O | X | X | X | O | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X | O | O | O | O |   | X |
 | O | X | X | X | O | O | X |
----------------------
O WIN!!! : -)
Do you want to continue? (y/n)n
```
## Análisis

analizar los requisitos a través de su refinamiento y estructura para realizar una compresión más precisa de los requisitos, una descripción de los requisitos que es fácil de mantener y ayuda a estructurar el sistema:

- Dar una especificación más precisa de los requisitos obtenidos en la captura de requisitos.
- Describir usando el lenguaje de los desarrolladores y poder introducir más formalismo y ser utilizado para razonar sobre el funcionamiento interno del sistema.
- Estructurar los requisitos de manera que facilite su comprensión, cambiándolos y, en general, mantenerlos.
- Acercase al diseño, aunque sea un modelo en sí mismo, y es por tanto un elemento esencial cuando el sistema está conformado en diseño e implementación.

### Análisis de la Arquictura

![image](https://user-images.githubusercontent.com/46433173/202216196-e337862f-c18d-4765-bd42-f97d5074fe7a.png)

### Análisis de las vistas

![image](https://user-images.githubusercontent.com/46433173/202228036-f080f046-9dfa-4fea-b739-383bb2e059c0.png)

### Análisis de los Modelos

![image](https://user-images.githubusercontent.com/46433173/202233208-7d7c3970-f7c7-47b6-a641-86ed73ef1c2b.png)

### Análisis de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/202242232-9bf820c3-6bd9-4212-b60b-a1fb36d3606d.png)

### Análisis de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/202240085-875d272e-66b7-465e-90fd-a4078692278c.png)

### Análisis de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/202241689-55b1714b-ca81-4f66-803f-4edbb30fc975.png)


### Análisis de Clases


### Análisis Clases de Vistas


### Análisis Clases de Modelos


### Análisis Clases de Tipos


### Análisis Clases de Utils 

## Vista de Lógica/Diseño 

### Arquitectura


### Diseño de caso de uso Start


### Diseño de caso de uso Play


### Diseño de caso de uso Resume


### Namespace ConsoleIOs


### Namespace Models


### Namespace Types


### Namespace Utils 
