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
Prototipo de interfaz partida empatada
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
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 45
Invalid columnn!!! Values [1-7]
Enter a colunm to drop a token: 3
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | O |   |   |   |   |
 | O |   | X |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O |   | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 2
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 1
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 1
Invalid column!!! It's completed
Enter a colunm to drop a token: 1
Invalid column!!! It's completed
Enter a colunm to drop a token: 3
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 2
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   |   |
 | O | O | X |   |   |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   |   |
 | O | O | X | X |   |   |   |
----------------------
Turn: O
Enter a colunm to drop a token: 5
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   |   |
 | O | O | X | X | O |   |   |
----------------------
Turn: X
Enter a colunm to drop a token: 6
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   |   |
 | O | O | X | X | O | X |   |
----------------------
Turn: O
Enter a colunm to drop a token: 7
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   |   |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 8
Invalid columnn!!! Values [1-7]
Enter a colunm to drop a token: 7
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   |   | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   |   | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O |   | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   |   |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 3
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X |   |   |   |   |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X | O |   |   |   |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X | O | X |   |   |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X | O | X | O |   |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 | O |   |   |   |   |   |   |
 | X |   |   |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 3
----------------------
 | O |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X |   | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 2
----------------------
 | O |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O |   | X |   |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 2
----------------------
 | O |   |   |   |   |   |   |
 | X |   | O |   |   |   |   |
 | O | O | X |   |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 2
----------------------
 | O |   |   |   |   |   |   |
 | X | X | O |   |   |   |   |
 | O | O | X |   |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 2
----------------------
 | O | O |   |   |   |   |   |
 | X | X | O |   |   |   |   |
 | O | O | X |   |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 3
----------------------
 | O | O | X |   |   |   |   |
 | X | X | O |   |   |   |   |
 | O | O | X |   |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 | O | O | X |   |   |   |   |
 | X | X | O |   |   |   |   |
 | O | O | X | O |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 | O | O | X |   |   |   |   |
 | X | X | O | X |   |   |   |
 | O | O | X | O |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 4
----------------------
 | O | O | X | O |   |   |   |
 | X | X | O | X |   |   |   |
 | O | O | X | O |   |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 | O | O | X | O |   |   |   |
 | X | X | O | X |   |   |   |
 | O | O | X | O | X |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 5
----------------------
 | O | O | X | O |   |   |   |
 | X | X | O | X | O |   |   |
 | O | O | X | O | X |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 5
----------------------
 | O | O | X | O | X |   |   |
 | X | X | O | X | O |   |   |
 | O | O | X | O | X |   |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 | O | O | X | O | X |   |   |
 | X | X | O | X | O |   |   |
 | O | O | X | O | X | O |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 6
----------------------
 | O | O | X | O | X |   |   |
 | X | X | O | X | O | X |   |
 | O | O | X | O | X | O |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 6
----------------------
 | O | O | X | O | X | O |   |
 | X | X | O | X | O | X |   |
 | O | O | X | O | X | O |   |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 | O | O | X | O | X | O |   |
 | X | X | O | X | O | X |   |
 | O | O | X | O | X | O | X |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: O
Enter a colunm to drop a token: 7
----------------------
 | O | O | X | O | X | O |   |
 | X | X | O | X | O | X | O |
 | O | O | X | O | X | O | X |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 | O | O | X | O | X | O | X |
 | X | X | O | X | O | X | O |
 | O | O | X | O | X | O | X |
 | X | X | X | O | X | O | X |
 | X | O | O | O | X | O | X |
 | O | O | X | X | O | X | O |
----------------------
TIED!!!
Do you want to continue? (y/n)
```

Prototipo de interfaz una partida ganada
```
--- CONNECT 4 ---
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
------------------------------
Turn: X
Enter a colunm to drop a token: 3
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X |   |   |   |   |
------------------------------
Turn: O
Enter a colunm to drop a token: 4
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X | O |   |   |   |
------------------------------
Turn: X
Enter a colunm to drop a token: 5
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   | X | O | X |   |   |
------------------------------
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
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   | X | X | O | X | O |   |
------------------------------
Turn: O
Enter a colunm to drop a token: 1
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 | O | X | X | O | X | O |   |
------------------------------
Turn: X
Enter a colunm to drop a token: 4
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   |   |   |
 | O | X | X | O | X | O |   |
------------------------------
Turn: O
Enter a colunm to drop a token: 6
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O |   |
------------------------------
Turn: X
Enter a colunm to drop a token: 7
----------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O | X |
------------------------------
Turn: O
Enter a colunm to drop a token: 8
Invalid columnn!!! Values [1-7]
Enter a colunm to drop a token: 6
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X |   | O |   |
 | O | X | X | O | X | O | X |
------------------------------
Turn: X
Enter a colunm to drop a token: 5
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X | X | O |   |
 | O | X | X | O | X | O | X |
------------------------------
Turn: O
Enter a colunm to drop a token: 6
------------------------------
 |   |   |   |   |   |   |   |
 |   |   |   |   |   |   |   |
 |   |   |   |   |   | O |   |
 |   |   |   |   |   | O |   |
 |   |   |   | X | X | O |   |
 | O | X | X | O | X | O | X |
------------------------------
O WIN!!! : -)
Do you want to continue? (y/n)
```

## Vista de Análisis

![image](https://user-images.githubusercontent.com/46433173/201672354-0feea666-0640-4e38-8fc0-817e4af13fb1.png)

## Análisis de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/201675647-f4bc1742-c385-4ecb-9136-0844a684a67e.png)

## Análisis de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/201678247-fdc116b8-e4aa-4e91-882e-5fbd584f11e5.png)

## Análisis de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/201679961-8298590d-df26-4d41-af13-6b3d9e1273e6.png)

## Namespaces

![image](https://user-images.githubusercontent.com/46433173/201682386-d9702b12-a794-4555-beef-92939335e190.png)

## Vista de Lógica/Diseño 

## Arquitectura

## Namespace ConnectFour-ConsoleApp

### Models

![image](https://user-images.githubusercontent.com/46433173/200595799-06b041d0-e3d3-4803-8e02-52b3708587e4.png)
