# - - - - - Mastermind - Model View Presentation-Presentation Models Architecture - Basic - Practice - - - - -

**índice**
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.3 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.4 [Prototipo de Interfaz Console Views](#Prototipo-de-Interfaz-Console-Views)
3. [Vista Lógica-Diseño](#Vista-Lógica-Diseño)
    - 3.1 [Arquitectura](#Arquitectura)
    - 3.2 [Mastermind](#Mastermind)
    - 3.3 [Mastermind.ConsoleApp](#Mastermind.ConsoleApp)
    - 3.4 [Mastermind.GameViews](#Mastermind.GameViews)
    - 3.5 [Mastermind.Controllers](#Mastermind.Controllers)
    - 3.6 [Mastermind.Models](#Mastermind.Models)
    - 3.7 [Mastermind.Types](#Mastermind.Types)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/> *_Maquina: **Si**_<br>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/197274966-0c85e9d1-30e7-40b0-84fc-6b916234aaab.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
| ![image](https://user-images.githubusercontent.com/46433173/197528950-968cd02a-9ede-42ac-9b8a-538fa3e5cee1.png) | ![image](https://user-images.githubusercontent.com/46433173/197537491-052ecd24-cdea-42b9-82ca-e7e7ebeffde7.png) |

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/198680136-79c7afb0-3b27-4a7f-9edf-e2d410c1f685.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/198680032-de7ee099-489d-4c9b-ad45-bc3c6a06fa02.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/198680083-71df504f-73d1-4306-803e-8cf9f62d1306.png)

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

## Vista Lógica-Diseño

**here**

### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/198673153-cbdf93e6-09a5-4188-b2f5-57e5a2bb5237.png)

### Mastermind

![image](https://user-images.githubusercontent.com/46433173/198673252-a628d3ee-2803-4744-ba9c-862ed9695848.png)

### Mastermind.ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/198678287-7cb6d4cd-9c1b-4f3c-8366-041ed91a53e3.png)

### Mastermind.GameViews

![image](https://user-images.githubusercontent.com/46433173/198678490-5bb8c674-7957-4b7b-8b8a-885bf15d5683.png)

### Mastermind.Controllers

![image](https://user-images.githubusercontent.com/46433173/198679309-5bd18eea-41ac-4214-b5fd-c43920384796.png)

### Mastermind.Models

![image](https://user-images.githubusercontent.com/46433173/198679900-f0cac6aa-2993-4d6b-9c87-92a6013e2e62.png)

### Mastermind.Types

![image](https://user-images.githubusercontent.com/46433173/198679947-0ee834b6-f513-4b4b-857b-c5359393a33e.png)
