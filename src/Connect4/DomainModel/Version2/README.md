# ---- Connect4 Domain Model ----

**índice**
- [Requisitos](#Requisitos)  
- [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)  
    - [Vista de Caso de Uso Start](#Vista-de-Caso-de-Uso-Start)  
    - [Vista de Caso de Uso Play](#Vista-de-Caso-de-Uso-Play)  
    - [Vista de Caso de Uso Resume](#Vista-de-Caso-de-Uso-Resume)  
    - [Prototipo de Interfaz](#Prototipo-de-Interfaz)
- [Análisis](#Analisis)  
    - [Arquitectura](#Arquitectura)  
    - [Namespace ConnectFour-ConsoleApp](#Namespace-ConnectFour-ConsoleApp)

## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/201655777-04df645a-dccc-4d79-975b-b7781f480de4.png) | 
| :------- | :------: |  

## Vista de Casos de Uso

|  Diagrama de Actores y Casos de Uso |  Diagrama de Contexto  |
|  ![image](https://user-images.githubusercontent.com/46433173/201655805-28718256-bf6f-408d-99bc-a195714dff1d.png) | ![image](https://user-images.githubusercontent.com/46433173/201657041-f93b90c5-5d02-43c3-939e-844b10eaea43.png) |
| --- | ---- |  

## Vista de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/201657754-9b03324e-ac21-4965-844a-982b850623e6.png)

## Vista de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/201662002-7b675981-e0f4-42ed-b51b-0a366b0f31ba.png)

## Vista de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/201663032-5ff28bf6-9d6e-4317-b522-ee0c0025affc.png)

## Prototipo de Interfaz

```
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
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X | O |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X | O | X |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X | O | X | O |   |
----------------------
Turn: X
Enter a colunm to drop a token: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | X | X | O | X | O |   |
----------------------
Turn: O
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O | X | X | O | X | O |   |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   |   |   |
 | O | X | X | O | X | O |   |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O |   |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 8
Invalid columnn!!! Values [1-7]
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O | X |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X | X | O |   |
 | O | X | X | O | X | O | X |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X | X | O |   |
 | O | X | X | O | X | O | X |
----------------------
O WIN!!! : -)
Do you want to continue? (y/n)
```

## Análisis

## Arquitectura

## Namespace ConnectFour-ConsoleApp

### Models

![image](https://user-images.githubusercontent.com/46433173/200595799-06b041d0-e3d3-4803-8e02-52b3708587e4.png)
