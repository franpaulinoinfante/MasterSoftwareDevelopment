# -------- Connect4 With Machine Player --------

**índice**
- [Requisitos](#Requisitos)  
- [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)  
    - [Vista de Caso de Uso Start](#Vista-de-Caso-de-Uso-Start)  
    - [Vista de Caso de Uso Play](#Vista-de-Caso-de-Uso-Play)  
    - [Vista de Caso de Uso Resume](#Vista-de-Caso-de-Uso-Resume)  
    - [Prototipo de Interfaz](#Prototipo-de-Interfaz)
- [Análisis](#Analisis)  
    - [Análisis de caso de uso Start](#Análisis-de-caso-de-uso-Start)  
    - [Análisis de caso de uso Play](#Análisis-de-baso-de-uso-Play)  
    - [Análisis de caso de uso Resume](#Análisis-de-baso-de-uso-Resume)  
    - [Namespaces](#Namespaces)  
- [Vista de Lógica/Diseño](#Vista-de-Lógica-Diseño) 
    - [Arquitectura](#Arquitectura)  
    - [Namespace ConsoleIOs](#Namespace-ConsoleIOs)  
    - [Namespace Models](#Namespace-Models)  
    - [Namespace Types](#Namespace-Types)  

## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199308347-025f54a1-49fc-4a3e-9385-aabbbf493ded.png) | 
| :------- | :------: |  

## Vista de Casos de Uso

|   ![image](https://user-images.githubusercontent.com/46433173/199312534-1b0b7c04-2e8e-47dc-8312-a3ab93868e17.png)   | ![image](https://user-images.githubusercontent.com/46433173/199313770-e5feb014-6a7b-4865-a993-e0246f7ad5d1.png) | 
| :------- | :------: |  

## Vista de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/199314660-3b7ca1e8-b789-4ec9-bc80-41d1fa3e085d.png)

## Vista de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/199346389-1e79d0bf-c2a7-4672-a1d9-56c89463cfbb.png)

## Vista de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/199319016-d86605be-6774-4e75-9580-c3e5438b4ab1.png)

## Prototipo de Interfaz

```
----- Connect-4 -----
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
----------------------------
Enter the column to insert a token:
Colunm: -1
The column is wrong
Enter the column to insert a token:
Colunm: 5
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 8
The column is wrong
Enter the column to insert a token:
Column: 4
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   | X |   |   |
|   |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 1
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   |   |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
----------------------------
|   |   |   |   |   |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
----------------------------
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   |   | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 5
The colunm is full
Enter the column to insert a token:
Column: 4
----------------------------
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   | X | X |   |   |
| O |   |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 2
----------------------------
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   | X | X |   |   |
| O | O |   | O | X |   |   |
----------------------------
Enter the column to insert a token:
Column: 7
----------------------------
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   | X | X |   |   |
| O | O |   | O | X |   | X |
----------------------------
Enter the column to insert a token:
Column: 3
----------------------------
|   |   |   |   | X |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | O |   |   |
|   |   |   |   | X |   |   |
|   |   |   | X | X |   |   |
| O | O | O | O | X |   | X |
----------------------------
O Player: You win!!! :-)
Do you want to continue? (y/n):
```

## Vista de Análisis


## Análisis de caso de uso Start


## Análisis de caso de uso Play


## Análisis de caso de uso Resume


## Namespaces


## Vista de Lógica/Diseño 


## Arquitectura


## ConnectFour-ConsoleApp


### Namespace ConsoleIOs


### Namespace Models


### Namespace Types
