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
    - [Diseño de la Arquitectura](#Diseño-de-la-Arquitectura)  
    - [Diseño de caso de uso Start](#Diseño-de-caso-de-uso-Start)  
    - [Diseño de caso de uso Play](#Diseño-de-caso-de-uso-Play)  
    - [Diseño de caso de uso Resume](#Diseño-de-caso-de-uso-Resume)  
    - [Namespace ConsoleApp](#Namespace-ConsoleApp)  
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

![image](https://user-images.githubusercontent.com/46433173/202851661-b9528050-ff2c-4c13-a17f-ddce5cae96a8.png)

### Análisis de los Modelos

![image](https://user-images.githubusercontent.com/46433173/202233208-7d7c3970-f7c7-47b6-a641-86ed73ef1c2b.png)

### Análisis de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/202852277-4ed71283-933a-4b19-8b87-0e36e84521b6.png)

### Análisis de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/202240085-875d272e-66b7-465e-90fd-a4078692278c.png)

### Análisis de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/202241689-55b1714b-ca81-4f66-803f-4edbb30fc975.png)

### Análisis de Clases

### Análisis Clases de Vistas

![image](https://user-images.githubusercontent.com/46433173/202278095-ffc8845c-363e-471e-ae8c-07f0f2d95b2c.png)

### Análisis Clases de Modelos

![image](https://user-images.githubusercontent.com/46433173/202275379-620da538-dc6d-4fef-a8a3-5ba88b219ef4.png)

### Análisis Clases de Tipos

![image](https://user-images.githubusercontent.com/46433173/202275652-1e4589ee-8fe3-4baf-849f-a332fb786cc2.png)

### Análisis Clases de Utils 

![image](https://user-images.githubusercontent.com/46433173/202275714-52c66fcf-29cb-43b4-811c-9e2dc3e1682d.png)

## Vista de Lógica/Diseño 

### Diseño de la Arquitectura

![image](https://user-images.githubusercontent.com/46433173/202287804-e17fe951-6c4e-40f2-a08f-6833ba56e645.png)

### Diseño de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/202294604-c697a887-1932-4e06-a31b-bd5270e39a2f.png)

### Diseño de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/202301010-673a5d27-2be5-4ef1-9e44-06a2e24195b4.png)


### Diseño de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/202303397-58706de6-d6d0-410b-aaa9-a268467a35ec.png)

### Namespace ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/202740504-13dd236a-6b81-4e78-ba4c-dd487c0c0f0d.png)

### Namespace Models

![image](https://user-images.githubusercontent.com/46433173/202731941-b218dbc2-00cf-408d-bd83-16bc562c57e5.png)

### Namespace Types

![image](https://user-images.githubusercontent.com/46433173/202480365-a9fe965c-2446-4c74-9a7b-66205bc5376b.png)

### Namespace Utils 

![image](https://user-images.githubusercontent.com/46433173/202734749-e4dd8897-4143-4f9b-96ef-1af97b29b179.png)
