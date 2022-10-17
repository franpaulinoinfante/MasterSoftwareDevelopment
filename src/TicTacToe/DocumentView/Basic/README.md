# - - - - - TicTacToe - Document\View Basic - Practice - - - - -

**índice**
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vista de Caso de Uso Set Up Player](#Vsita-de-Caso-de-Set-Up-Player)
    - 2.3 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.4 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.5 [Prototipo de Interfaz](#Prototipo-de-Interfaz)
3. [Vista Lógica-Diseño](#Vista-Lógica-Diseño)
    - 3.1 [Arquitectura](#Arquitectura)
    - 3.2 [Namespace TicTacToe](#Namespace-TicTacToe)
    - 3.3 [Namespace TicTacToe-ConsoleApp](#Namespace-TicTacToeConsoleApp)
    - 3.4 [Namespace TicTacToe.View](#Namespace-TicTacToe.Views)
    - 3.5 [Namespace TicTacToe.Models](#Namespace-TicTacToe.Models)
        - 3.5.1 [Namespace TicTacToe.Models.Types](#Namespace-TicTacToe.Models.Types)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/> *_Maquina: **Si**_<br>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![TicTacToe](https://user-images.githubusercontent.com/46433173/195204431-936b7ff3-1b33-4167-a362-30ede4d08aec.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
|![image](https://user-images.githubusercontent.com/46433173/195204864-f650c52c-cbcb-4288-8f86-6a32de30eb62.png) |![image](https://user-images.githubusercontent.com/46433173/195207035-a3001085-dde5-4d3c-aa22-81ea8cda5b84.png)

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/196008561-4923f589-0a7c-48a9-977b-2c821b19b56c.png)

### Vista de Caso de Uso Set Up Player

![image](https://user-images.githubusercontent.com/46433173/196046634-c5eafc78-7e41-493b-96db-84e6a2ada6fe.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/195362112-b873c50f-d9a2-451b-b631-b85ee9a68a8d.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/195361789-aaa6d03d-50a5-44d4-8ee8-00159c27d0b3.png)

### Prototipo de Interfaz 

**Número de jugadores: 0**
```
--- TIC TAC TOE ---
Number of user? [0, 2]: 0
-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------
-------------
|   |   | x |
|   |   |   |
|   |   |   |
-------------
-------------
|   | X |   |
|   |   |   |
|   | O |   |
-------------
-------------
|   | X |   |
|   |   |   |
|   | O | X |
-------------
-------------
|   | X |   |
| O |   |   |
|   | O | X |
-------------
-------------
|   | X | X |
| O |   |   |
|   | O | X |
-------------
-------------
|   | X | X |
| O |   | O |
|   | O | X |
-------------
-------------
| X | X | X |
| O |   | O |
|   | O |   |
X Player: You win!!! :-)
Do you want to continue? (y/n):
```

**Número de jugadores: 1**
```
--- TIC TAC TOE ---
Number of user? [0 - 2]: 1
-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 1
Column: 1
-------------
| X |   |   |
|   |   |   |
|   |   |   |
-------------
-------------
| X |   | O |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 2
Column: 2
-------------
| X |   | O |
|   | X |   |
|   |   |   |
-------------
-------------
| X |   | O |
|   | X | O |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 3
Column: 2
-------------
| X |   | O |
|   | X | O |
|   | X |   |
-------------
-------------
| X |   | O |
|   | X | O |
|   | X | O |
-------------
O Player: You win!!! :-)
Do you want to continue? (y/n):
```

***Número de jugadores: 2***
```
--- TIC TAC TOE ---
Number of user? [0, 2]: 2
-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 4
Column: -1
The coordinates are wrong
Enter a coordinate to put a token:
Row: 1
Column: 1
-------------
| X |   |   |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 1
Column: 1
The square is not empty
Enter a coordinate to put a token:
Row: 1
Column: 2
-------------
| X | O |   |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 2
Column: 2
-------------
| X | O |   |
|   | X |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 3
Column: 3
-------------
| X | O |   |
|   | X |   |
|   |   | O |
-------------
Enter a coordinate to put a token:
Row: 1
Column: 3
-------------
| X | O | X |
|   | X |   |
|   |   | O |
-------------
Enter a coordinate to put a token:
Row: 3
Column: 1
-------------
| X | O | X |
|   | X |   |
| O |   | O |
-------------
Origin coordinate to move
Row: 3
Column: 1
There is not a token of yours
Origin coordinate to move
Row: 1
Column: 1
Target coordinate to move
Row: 1
Column: 1
The origin and target squares are the same
Target coordinate to move
Row: 3
The origin and target squares are the same
Target coordinate to move
Row: 3
Column: 1
The square is not empty
Target coordinate to move
Row: 3
Column: 2
-------------
|   | O | X |
|   | X |   |
| O | X | O |
-------------
Origin coordinate to move
Row: 1
Column: 2
Target coordinate to move
Row: 1
Column: 1
-------------
| O |   | X |
|   | X |   |
| O | X | O |
-------------
Origin coordinate to move
Row: 1
Column: 3
Target coordinate to move
Row: 1
Column: 2
-------------
| O | X |   |
|   | X |   |
| O | X | O |
-------------
X Player: You win!!! :-)
Do you want to continue? (y/n):
```

## Vista Lógica-Diseño

### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/196204159-528dd2c0-82d3-4ef3-b484-a7f488fe446e.png)

**Namespaces**

### Namespace TicTacToe-ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/196240514-b1b5af22-9e9c-410d-a8a9-bedd89602518.png)

### Namespace TicTacToe.Views

![image](https://user-images.githubusercontent.com/46433173/196240351-bdcb2fa2-505f-4422-89d3-dc00fe23fb7d.png)
 
### Namespace TicTacToe.Models

![image](https://user-images.githubusercontent.com/46433173/196265461-13d98824-9d16-443d-9082-7a41680f795b.png)

### Namespace TicTacToe.Models.Types
