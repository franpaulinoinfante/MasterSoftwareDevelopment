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

| * _Funcionalidad: **Sencilla**_<br/> *_Maquina: **No**_<br>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/197274966-0c85e9d1-30e7-40b0-84fc-6b916234aaab.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
| ![image](https://user-images.githubusercontent.com/46433173/197528950-968cd02a-9ede-42ac-9b8a-538fa3e5cee1.png) | ![image](https://user-images.githubusercontent.com/46433173/197537491-052ecd24-cdea-42b9-82ca-e7e7ebeffde7.png) |

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/198834327-a84a3632-1d55-4292-8e37-20a67f17c0b0.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/198833924-e5b71cbb-ce5f-4b67-8e54-ea828b9c4c75.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/198834305-2607df2e-a95d-4dd8-a62f-16ad64a1b01b.png)

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

![image](https://user-images.githubusercontent.com/46433173/198832643-f4e81722-83d9-4987-aa64-307fc1893d42.png)

### Mastermind

![image](https://user-images.githubusercontent.com/46433173/198833153-ed7ab72f-4db5-4710-91f3-aeec7b791816.png)

### Mastermind.ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/198836638-413597c8-c12a-4a34-ac42-f34fa59573f6.png)

### Mastermind.GameViews

![image](https://user-images.githubusercontent.com/46433173/198832684-545bcd3c-b4d2-43f4-94ec-d134638e0cdd.png)

### Mastermind.Controllers

![image](https://user-images.githubusercontent.com/46433173/198832895-2f011889-4f60-4625-8c86-e778fe34c850.png)

### Mastermind.Models

![image](https://user-images.githubusercontent.com/46433173/198833014-3f936632-0450-4e6e-9d03-772390c1bcd0.png)

### Mastermind.Types

![image](https://user-images.githubusercontent.com/46433173/198833058-0ec578e1-7b3d-4273-aa62-f46e28ea32ad.png)
