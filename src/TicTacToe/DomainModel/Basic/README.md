# - - - - - TicTacToe Practice - - - - -

**índice***
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.3 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.4 [Prototipo de Interfaz](#Prototipo-de-Interfaz)
3. [Análisis](#Analisis)
    - 3.1 [Casos de Uso](# )
    - 3.1.1 [Análisis Start](#Análisis-Start)
    - 3.1.2 [Análisis Play](#Análisis-Play)
    - 3.1.3 [Análisis Resume](#Análisis-Resume)
    - 3.2 [Pquetes](#Paquetes)
    - 3.2.1 [TicTacToe-ConsoleApp](#TicTacToeConsoleApp)
    - 3.2.2 [TicTacToe-Utils](#TicTac-ToeUtils)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![TicTacToe](https://user-images.githubusercontent.com/46433173/195204431-936b7ff3-1b33-4167-a362-30ede4d08aec.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
|![image](https://user-images.githubusercontent.com/46433173/195204864-f650c52c-cbcb-4288-8f86-6a32de30eb62.png) |![image](https://user-images.githubusercontent.com/46433173/195207035-a3001085-dde5-4d3c-aa22-81ea8cda5b84.png)

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/195210902-9f9c3d1c-4ff6-48e8-9de3-6ed51096f08e.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/195362112-b873c50f-d9a2-451b-b631-b85ee9a68a8d.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/195361789-aaa6d03d-50a5-44d4-8ee8-00159c27d0b3.png)

### Prototipo de Interfaz  
```
--- TIC TAC TOE ---
-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 5
Column: -3
The coordinates are not valid
Enter a coordinate to put a token:
Row: 2
Column: 2
-------------
|   |   |   |
|   | X |   |
|   |   |   |
-------------
Enter a coordinate to put a token:
Row: 2
Column: 2
The square is not empty
Enter a coordinate to put a token:
Row: 3
Column: 3
-------------
|   |   |   |
|   | X |   |
|   |   | O |
-------------
Enter a coordinate to put a token:
Row: 1
Column: 1
-------------
| X |   |   |
|   | X |   |
|   |   | O |
-------------
Enter a coordinate to put a token:
Row: 3
Column: 1
-------------
| X |   |   |
|   | X |   |
| O |   | O |
-------------
Enter a coordinate to put a token:
Row: 3
Column: 2
-------------
| X |   |   |
|   | X |   |
| O | X | O |
-------------
Enter a coordinate to put a token:
Row: 1
Column: 2
-------------
| X | O |   |
|   | X |   |
| O | X | O |
-------------
Origin coordinate to move
Row: 3
Column: 3
There is not a token of yours
Origin coordinate to move
Row: 1
Column: 1
Target coordinate to move
Row: 1
Column: 1
The origin and target squares are the same
Target coordinate to move
Row: 2
Column: 1
The square is not empty
Target coordinate to move
Row: 3
Column: 2
-------------
|   | O |   |
| X | X |   |
| O | X | O |
-------------
Origin coordinate to move
Row: 3
Column: 2
Target coordinate to move
Row: 1
Column: 1
-------------
| O | O |   |
| X | X |   |
|   | X | O |
-------------
Origin coordinate to move
Row: 3
Column: 2
Target coordinate to move
Row: 2
Column: 3
-------------
|   | O |   |
| X | X | X |
| O |   | O |
-------------
X Player: You win!!! :-)
Do you want to continue? (y/n):
```

### Análisis

### Casos de Uso

### Análisis Start

### Análisis Play

### Análisis Resume

### Pquetes

### TicTacToeConsoleApp

### TicTacToeUtils
