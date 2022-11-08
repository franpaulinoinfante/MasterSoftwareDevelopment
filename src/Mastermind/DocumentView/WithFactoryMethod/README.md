# - - - - - Mastermind - Document\View With Factory Method and 2 Views - Practice - - - - -

**índice**
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.3 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.4 [Prototipos de Interfaz](#Prototipos-de-Interfaz)
      - 2.4.1 [Prototipo de Interfaz Console Views](#Prototipo-de-Interfaz-Console-Views)
      - 2.4.2 [Prototipo de Interfaz Graphics Views](#Prototipo-de-Interfaz-Graphics-Views)
3. [Vista Lógica-Diseño](#Vista-Lógica-Diseño)
    - 3.1 [Arquitectura](#Arquitectura)
    - 3.2 [Mastermind](#Namespace-Mastermind)
    - 3.3 [Mastermind.ConsoleApp](#Namespace-Mastermind.ConsoleApp)
    - 3.4 [Mastermind.GameViews](#Namespace-Mastermind.GameViews)
    - 3.4 [Mastermind.Models](#Namespace-Mastermind.Models)
    - 3.5 [Mastermind.Types](#Namespace-Mastermind.Types)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/> *_Maquina: **Si**_<br>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/197274966-0c85e9d1-30e7-40b0-84fc-6b916234aaab.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
| ![image](https://user-images.githubusercontent.com/46433173/197528950-968cd02a-9ede-42ac-9b8a-538fa3e5cee1.png) | ![image](https://user-images.githubusercontent.com/46433173/197537491-052ecd24-cdea-42b9-82ca-e7e7ebeffde7.png) |

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/198087050-56137763-4d43-484f-a6e6-badca7027fc6.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/198087193-98fb8e9f-5061-40cd-ab0d-83dea6ac99f3.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/198087129-f31cb035-6b14-4e7f-8bbc-a2ad19bbf6b1.png)

### Prototipos de Interfaz 

### Prototipo de Interfaz - Console Views
***Partida Ganada***
```
---- Mastermind ---
0 attempt(s): 
****
move a combination: rybgmc
Wrong moved combination length
move a combination: rybÑ
Wrong colors, they must be: rgybmc
move a combination: rybv
Wrong colors, they must be: rgybmc
move a combination: rybc

1 attempt(s): 
****
rybc --> 1 blacks and 3 whites
move a combination: rbcy

2 attempt(s): 
****
rybc --> 1 blacks and 3 whites
rbcy --> 1 blacks and 3 whites
move a combination: rcyb

3 attempt(s): 
****
rybc --> 1 blacks and 3 whites
rbcy --> 1 blacks and 3 whites
rcyb --> 0 blacks and 4 whites
move a combination: yrbc

4 attempt(s): 
****
rybc --> 1 blacks and 3 whites
rbcy --> 1 blacks and 3 whites
rcyb --> 0 blacks and 4 whites
yrbc --> 0 blacks and 4 whites
move a combination: bcry

5 attempt(s): 
****
rybc --> 1 blacks and 3 whites
rbcy --> 1 blacks and 3 whites
rcyb --> 0 blacks and 4 whites
yrbc --> 0 blacks and 4 whites
bcry --> 1 blacks and 3 whites
move a combination: bycr

6 attempt(s): 
****
rybc --> 1 blacks and 3 whites
rbcy --> 1 blacks and 3 whites
rcyb --> 0 blacks and 4 whites
yrbc --> 0 blacks and 4 whites
bcry --> 1 blacks and 3 whites
bycr --> 4 blacks and 0 whites
You've won!!! ;-)
Do you want to continue? (y/n): 
```

**Partida Perdida**
```
---- Mastermind ----
0 attempt(s): 
****
move a combination: rgby

1 attempt(s): 
****
rgby --> 1 blacks and 2 whites
move a combination: rgby

2 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
move a combination: bygr

3 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
move a combination: rbgy

4 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
move a combination: ygbr

5 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
move a combination: grby

6 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
grby --> 0 blacks and 3 whites
move a combination: rgby

7 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
grby --> 0 blacks and 3 whites
rgby --> 1 blacks and 2 whites
move a combination: rgby

8 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
grby --> 0 blacks and 3 whites
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
move a combination: rgby

9 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
grby --> 0 blacks and 3 whites
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
move a combination: gbry

10 attempt(s): 
****
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
bygr --> 2 blacks and 1 whites
rbgy --> 2 blacks and 1 whites
ygbr --> 0 blacks and 3 whites
grby --> 0 blacks and 3 whites
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
rgby --> 1 blacks and 2 whites
gbry --> 0 blacks and 3 whites
You've lost!!! :-(
Do you want to continue? (y/n): 
```

### Prototipo de Interfaz - Graphics Views


## Vista Lógica-Diseño


### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/198138597-a8e484c2-72dc-4865-8fe2-7f111531c8c8.png)


### Namespace Mastermind

![image](https://user-images.githubusercontent.com/46433173/198138761-04290be0-ebf5-4cbf-b227-446f14cad819.png)

### Namespace Mastermind.ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/198138675-b4260164-8a26-4724-bb49-28e6d50902cc.png)

### Namespace Mastermind.GameViews

 ![image](https://user-images.githubusercontent.com/46433173/198138727-b3c57cbd-252d-45de-a259-03eaf28c8698.png)

### Namespace Mastermind.Models

![image](https://user-images.githubusercontent.com/46433173/198138534-f09ab6de-40fd-4a33-8fbb-4070bf472f3d.png)

### Namespace Mastermind.Types

![image](https://user-images.githubusercontent.com/46433173/198138901-589e7167-7255-4cb7-8e49-a6148cff5614.png)
