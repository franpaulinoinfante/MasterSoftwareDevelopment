# -------- Connect4 With Machine Player --------

**índice**
- [Requisitos](#Requisitos)  
- [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)  
    - [Vista de Caso de Uso Start](#Vista-de-Caso-de-Uso-Start)  
    - [Vista de Caso de Uso Play](#Vista-de-Caso-de-Uso-Play)  
    - [Vista de Caso de Uso Resume](#Vista-de-Caso-de-Uso-Resume)  
    - [Prototipo de Interfaz](#Prototipo-de-Interfaz)
        - [Interfaz Máquina](#Interfaz-Máquina)  
        - [Interfaz Jugador y Máquina](#Interfaz-Jugador-y-Máquina)  
        - [Interfaz 2 Jugadores](#Interfaz-2-Jugadores)  
- [Análisis](#Analisis)  
    - [Análisis de caso de uso Start](#Análisis-de-caso-de-uso-Start)  
    - [Análisis de caso de uso Play](#Análisis-de-baso-de-uso-Play)  
    - [Análisis de caso de uso Resume](#Análisis-de-baso-de-uso-Resume)  
    - [Vista de Análisis](#Vista-de-Análisis)  
    - [Namespaces](#Namespaces)  
- [Vista de Lógica/Diseño](#Vista-de-Lógica-Diseño) 
    - [Arquitectura](#Arquitectura)  
    - [Diseño de caso de uso Start](#Diseño-de-caso-de-uso-Start)  
    - [Diseño de caso de uso Play](#Diseño-de-caso-de-uso-Play)  
    - [Diseño de caso de uso Resume](#Diseño-de-caso-de-uso-Resume)  
    - [Namespace ConsoleIOs](#Namespace-ConsoleIOs)  
    - [Namespace Models](#Namespace-Models)  
    - [Namespace Types](#Namespace-Types)  

## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199308347-025f54a1-49fc-4a3e-9385-aabbbf493ded.png) | 
| :------- | :------: |  

## Vista de Casos de Uso

|   ![image](https://user-images.githubusercontent.com/46433173/199312534-1b0b7c04-2e8e-47dc-8312-a3ab93868e17.png)   | ![image](https://user-images.githubusercontent.com/46433173/199313770-e5feb014-6a7b-4865-a993-e0246f7ad5d1.png) | 
| :------- | :------: |  

### Vista de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/199314660-3b7ca1e8-b789-4ec9-bc80-41d1fa3e085d.png)

### Vista de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/199346389-1e79d0bf-c2a7-4672-a1d9-56c89463cfbb.png)

### Vista de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/199319016-d86605be-6774-4e75-9580-c3e5438b4ab1.png)

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

### Análisis de caso de uso Start

![image](https://user-images.githubusercontent.com/46433173/201943318-ca1ce7c3-eaf9-429f-a47a-5591e930c9a6.png)

### Análisis de caso de uso Play

![image](https://user-images.githubusercontent.com/46433173/201943488-aba2da1d-1654-4862-a635-6a529a136413.png)

### Análisis de caso de uso Resume

![image](https://user-images.githubusercontent.com/46433173/201943403-c6abb8ff-8006-4b5d-b6b6-9a6ca67f2bc9.png)

### Vista de Análisis

![image](https://user-images.githubusercontent.com/46433173/201950249-6b3537be-b5db-47c2-bf8c-eeac8915e07e.png)

### Namespaces

![image](https://user-images.githubusercontent.com/46433173/201949604-bc81242a-433c-489c-81ca-33b327396894.png)

## Vista de Lógica/Diseño 

### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/201950321-d0b3d6cf-defc-4ef3-8f54-6d55eb570dca.png)

### Diseño de caso de uso Start

### Diseño de caso de uso Play

### Diseño de caso de uso Resume


### Namespace ConsoleIOs

![image](https://user-images.githubusercontent.com/46433173/201951820-1b3f55c9-bd17-4e46-8095-8c9dfc3a2cbb.png)

### Namespace Models


### Namespace Types
