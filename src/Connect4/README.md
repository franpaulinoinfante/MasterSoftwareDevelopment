# Connect-4

**Índice**
1. [Modelo del dominio](#modelo-del-dominio)  
    1.1. [Vocabulario](#vocabulario)  
    1.2. [Estado inicial](#estado-inicial)  
    1.3. [Estado final.](#estado-final)  
    1.4. [Instrucciones](#instrucciones)  
2. [Requisitos](#Requisitos)
    2.1. [Vista de Caso de Uso Start](#vista-de-caso-de-uso-start)  
    2.2. [Vista de Caso de Uso Play](#vista-de-caso-de-uso-play)  
    2.3. [Vista de Caso de Uso Resume](#vista-de-caso-de-uso-resume)    
    2.4. [Prototipo de Interfaz](#prototipo-de-interfaz)   
3. [Analisis](#Analisis)
    3.1. [Casos de Uso](#casos-de-uso)  
    3.1.1. [Analisis Start](#analisis-start)  
    3.1.2. [Analisis Play](#analisis-play)  
    3.1.3. [Analisis Resume](#analisis-resume)  
    3.2. [Namespaces](#namespaces)  
4. [Vista de Lógica/Diseño](#vista-de-lógicadiseño)  
   4.1. [Arquitectura](#arquitectura)  
   4.2. [namespace connectfour](#namespace-connectFour)  
   4.3. [namespace connectfour.gameviews](#namespace-connectfourgameviews)<br>
   4.4. [namespace connectfour.consoleapp](#namespace-connectfour.consoleapp)<br>
   4.5. [namespace connectfour.controllers](#namespace-connectfourcontrollers)<br>
   4.6. [namespace connectfour.types](#namespace-connectfourtypes)  
   4.7. [namespace connectfour.models](#namespace-connectfourmodels)  
3. [Calidad del Software](#calidad-del-software)  
   3.1. [Diseño](#diseño)  
   3.2. [Rediseño](#rediseño)
4. [Vista de Desarrollo/Implementación](#vista-de-desarrolloimplementación)
5. [Vista de Despliegue/Física](#vista-de-desplieguefísica)

## Modelo del dominio

![Screenshot 2022-11-01 092020](https://user-images.githubusercontent.com/46433173/199242919-550c3616-9585-472f-b9b2-d4af46882528.png)

## Vocabulario

![image](https://user-images.githubusercontent.com/46433173/199251331-af761325-ccc6-4ddd-818b-453f491f779d.png)

## Estado inicial

![image](https://user-images.githubusercontent.com/46433173/199464679-5cc55282-0307-4ff8-bd3c-676c857cf9b4.png)

## Estado final Ganador

## Instrucciones

![image](https://user-images.githubusercontent.com/46433173/199270935-5a2401dd-8986-41c6-b3b5-57c41d5a2fce.png)

![image](https://user-images.githubusercontent.com/46433173/199346771-45304715-327c-43bf-88a5-ae061e6d578e.png)

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

![image](https://user-images.githubusercontent.com/46433173/199352608-589ff634-228d-4ef3-a67b-7c9b3bdaa84a.png)

## Caso de Uso

## Analisis Start

![image](https://user-images.githubusercontent.com/46433173/199470462-cd599dde-1c29-4ac7-9622-cc63e096ecd1.png)

## Analisis Play

![image](https://user-images.githubusercontent.com/46433173/199480071-24de8ffc-f027-44fc-a94f-f16b8dd43b63.png)

## Analisis Resume

![image](https://user-images.githubusercontent.com/46433173/199481856-56dd955e-dc45-4dd2-bf05-a25c40789c1a.png)

## Namespaces

![image](https://user-images.githubusercontent.com/46433173/199493300-132dec50-460a-4711-a303-2fe1cf54bd37.png)

## Vista de Lógica/Diseño

## namespace connectfour

## namespace connectfour.gameviews

## namespace connectfour.consoleapp

## namespace connectfour.controllers

## namespace connectfour.models

## namespace connectfour.types

## Arquitectura

## Calidad del Software

## Vista de Dessarrollo/Implementación

## Vista de Despliegue/Física

