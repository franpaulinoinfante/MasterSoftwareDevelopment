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
- [Análisis](#Análisis)  
    - [Análisis de la Arquictura](#Análisis-de-la-Arquictura)  
        - [Paquetes de Análisis](#Paquetes-de-Análisis)
    - [Análisis de  los casos de uso](#Análisis-de-los-Casos-de-Uso)  
        - [Análisis de caso de uso Start](#Análisis-de-caso-de-uso-Start)  
        - [Análisis de caso de uso Play](#Análisis-de-baso-de-uso-Play)  
        - [Análisis de caso de uso Resume](#Análisis-de-baso-de-uso-Resume)
    - [Análisis de las Clases](#Análisis-de-las-Clases)  
        - [Análisis Clases de Vistas](#Análisis-Clases-de-Vistass)  
        - [Análisis Clases de Modelos](#Análisis-Clases-de-Modelos)  
        - [Análisis Clases de Tipos](#Análisis-Clases-de-Tipos)  
        - [Análisis Clases de Utils ](#Análisis-Clases-de-Utils)  
        - [Análisis de las vistas](#Análisis-de-las-vistas)  
        - [Análisis de los Modelos](#Análisis-de-los-Modelos)   
    - [Análisis de Paquetes](#Análisis-de-Paquetes)
- [Diseño](#Diseño) 
    - [Diseño de la Arquitectura](#Diseño-de-la-Arquitectura)  
    - [Diseño de los Casos de Uso](#Diseño-de-los-Caso-de-Uso)  
        - [Diseño de caso de uso Start](#Diseño-de-caso-de-uso-Start)  
        - [Diseño de caso de uso Play](#Diseño-de-caso-de-uso-Play)  
        - [Diseño de caso de uso Resume](#Diseño-de-caso-de-uso-Resume)  
    - [Diseño de las Clases](#Diseño-de-las-Clases)  
        - [Diseño de Connect4](#Diseño-de-Connect4)  
        - [Diseño de la ConsoleApp](#Diseño-de-la-ConsoleApp)  
        - [Diseño de las Vistas del Juego](#Diseño-de-las-Vistas-del-Juego)  
        - [Diseño de los Modelos](#Diseño-de-los-Modelos)  
        - [Diseño de los Tipos](#Diseño-de-los-Tipos)  
        - [Diseño de las Utilidades](#Diseño-de-las-Utilidades) 
        - [Diseño de las Relaciones](#Diseño-de-las-Relaciones)  

## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**/**Grafica**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199308347-025f54a1-49fc-4a3e-9385-aabbbf493ded.png) | 
| :------- | :------: |  

### Casos de Uso

|  Vista de Caso de Uso  |  Contexto de Casos de Uso  | 
| :------- | :------: |  
| ![image](https://user-images.githubusercontent.com/46433173/203078488-b3f38802-854e-4cb8-b28e-5003a1fd61ca.png) | ![image](https://user-images.githubusercontent.com/46433173/203078539-217c457c-a5ac-4eba-a4fc-01a89f74dffa.png) |

#### Especificación de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/203078842-2a19edc6-5455-483f-bca7-778b9302ee9e.png)

#### Especificación de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/203078913-0d2ec3f7-20bf-4d7f-9ea6-3142ecd30f0f.png)

#### Especificación de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/203078973-05943ad4-9ec8-4a21-9b74-93f3195ade0f.png)

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

Analizar los requisitos a través de su refinamiento y estructura para realizar una compresión más precisa de los requisitos, una descripción de los requisitos que es fácil de mantener y ayuda a estructurar el sistema:
- Dar una especificación más precisa de los requisitos obtenidos en la captura de requisitos.
- Describir usando el lenguaje de los desarrolladores y poder introducir más formalismo y ser utilizado para razonar sobre el funcionamiento interno del sistema.
- Estructurar los requisitos de manera que facilite su comprensión, cambiándolos y, en general, mantenerlos.
- Acercase al diseño, aunque sea un modelo en sí mismo, y es por tanto un elemento esencial cuando el sistema está conformado en diseño e implementación.

### Análisis de la Arquictura
**Arquitectura Documents/Views

![image](https://user-images.githubusercontent.com/46433173/203092727-286ef869-67df-4b2f-989c-36ea316ccde0.png)

### Paquetes de Análisis

![image](https://user-images.githubusercontent.com/46433173/203092949-9ff89314-a04a-4bb4-b023-56f5c04875fc.png)

![image](https://user-images.githubusercontent.com/46433173/203093128-c42d109d-f8ad-4c2f-9b74-6c3b2484e30f.png)

![image](https://user-images.githubusercontent.com/46433173/203093229-fb428f96-a7b0-4220-a734-c9c476f91a10.png)

![image](https://user-images.githubusercontent.com/46433173/203093323-0044da69-61e4-4511-ba38-0b8f398f0fd2.png)

### Análisis de los Casos de Uso
#### Análisis de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/203131523-34a4fbb9-bc14-4b92-8bb8-5752bae91870.png)

#### Análisis de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/203131414-8845a6b2-2f4d-44ea-a6de-016df838fdf5.png)

#### Análisis de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/203131363-1bb237ba-79c9-431f-94c7-69f8f96cad76.png)

### Análisis de Clases
#### Análisis Clases de Vistas

![image](https://user-images.githubusercontent.com/46433173/203325175-521a2111-ab29-4b8e-b8ca-9a428858df53.png)

#### Análisis Clases de Modelos

![image](https://user-images.githubusercontent.com/46433173/203329301-561e586f-4cc6-4615-95c8-11dd5003a720.png)

#### Análisis Clases de Tipos

![image](https://user-images.githubusercontent.com/46433173/203331311-32bc683c-f652-487c-9b00-34515b231478.png)

#### Análisis Clases de Utils 

![image](https://user-images.githubusercontent.com/46433173/203331284-bc9225dd-cff3-4144-85ed-85464b1994ca.png)

#### Análisis de Paquetes

![image](https://user-images.githubusercontent.com/46433173/203334214-745d27ab-f08b-46c8-934a-5ad31dfaa3ed.png)

## Vista de Lógica/Diseño 
### Diseño de la Arquitectura

![image](https://user-images.githubusercontent.com/46433173/203404057-d1708cf3-1fb4-470c-97d0-6c2f3ea2bb3f.png)

### Diseño de los Casos de Uso
#### Diseño de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/203410965-a30d38e5-6ea3-46ee-8e1f-cd7be1138a2a.png)

#### Diseño de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/203427611-d5249e88-b35a-4a5e-ad52-1c07dc5246c7.png)

#### Diseño de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/203427570-9e889988-9746-4ebd-bf68-e6af3d4e6b04.png)

### Diseño de las Clases

#### Diseño de Connect4

![image](https://user-images.githubusercontent.com/46433173/203988879-090d0e55-7b05-485a-aeca-4e7bf89299fe.png)

#### Diseño de la ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/203988915-93488aaf-3ffc-4962-93bd-a2e6282d7508.png)

#### Diseño de las Vistas del Juego

![image](https://user-images.githubusercontent.com/46433173/203988954-4eb878e6-3fd6-429b-a6d8-b8b094d88df3.png)

#### Diseño de los Modelos

![image](https://user-images.githubusercontent.com/46433173/203989175-d353268b-f002-4e4e-810a-dc0f14bff439.png)

#### Diseño de los Tipos

![image](https://user-images.githubusercontent.com/46433173/203989210-1fefa401-c195-4981-b6a8-7a42f8b41f85.png)

#### Diseño de las Utilidades

![image](https://user-images.githubusercontent.com/46433173/203989246-c2844c0f-73dd-4a30-ab22-6aa4342071c6.png)
