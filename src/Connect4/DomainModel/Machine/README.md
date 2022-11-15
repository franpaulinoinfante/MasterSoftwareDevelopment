# -------- Connect4 With Machine Player --------

**Índice**  
2. [Requisitos](#Requisitos)  
    2.1. [Vista de Caso de Uso Start](#vista-de-caso-de-uso-start)  
    2.2. [Vista de Caso de Uso Play](#vista-de-caso-de-uso-play)  
    2.3. [Vista de Caso de Uso Resume](#vista-de-caso-de-uso-resume)  
    2.4. [Prototipo de Interfaz](#prototipo-de-interfaz)  
3. [Analisis](#Analisis  
    3.1. [Casos de Uso](#casos-de-uso)  
    3.1.1. [Analisis Start](#Analisis-start)  
    3.1.2. [Analisis Play](#Analisis-play)  
    3.1.3. [Analisis Resume](#Analisis-resume)  
    3.2. [Namespaces](#Namespace)  
4. [Vista de Lógica/Diseño](#vista-de-lógicadiseño)  
   4.1. [Arquitectura](#arquitectura)  
   4.4. [Namespace Consoleapp](#Namespace-Consoleapp)  
   4.6. [Namespace Models](#Namespace-Models)  
   4.7. [namespace Types](#Namespace-Types)  
   4.8. [Arquitectura](#Arquitectura  
5. [Calidad del Software](#alidad-del-software)  
   4.1. [Diseño](#Diseño)  
   4.2. [Rediseño](#Rediseño)  
6. [Vista de Desarrollo/Implementación](#vista-de-desarrolloimplementación)  
7. [Vista de Despliegue/Física](#vista-de-desplieguefísica)  

## Modelo del Dominio



## Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199308347-025f54a1-49fc-4a3e-9385-aabbbf493ded.png) | 
| :------- | :------: |  

## Casos de Uso

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

## Analisis


## Caso de Uso

## Analisis Start


## Analisis Play


## Analisis Resume


## Namespaces


## Vista de Lógica/Diseño

## namespace connectfour

## namespace connectfour.consoleapp

## namespace connectfour.models

## namespace connectfour.types

## Arquitectura

## Calidad del Software

## Vista de Dessarrollo/Implementación

## Vista de Despliegue/Física


