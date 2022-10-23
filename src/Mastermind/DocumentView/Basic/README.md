# - - - - - Mastermind - Document\View Basic - Practice - - - - -

**índice**
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vista de Caso de Uso Set Up Player](#Vsita-de-Caso-de-Set-Up-Player)
    - 2.3 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.4 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.5 [Prototipo de Interfaz](#Prototipo-de-Interfaz)
3. [Vista Lógica-Diseño](#Vista-Lógica-Diseño)
    - 3.1 [Arquitectura](#Arquitectura)
    - 3.2 [Mastermind](#Namespace-Mastermind)
    - 3.3 [Mastermind.ConsoleApp](#Namespace-Mastermind.ConsoleApp)
    - 3.4 [Mastermind.Models](#Namespace-Mastermind.Models)
    - 3.5 [Mastermind.Types](#Namespace-Mastermind.Types)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/> *_Maquina: **Si**_<br>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/197274966-0c85e9d1-30e7-40b0-84fc-6b916234aaab.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
| ![image](https://user-images.githubusercontent.com/46433173/197359005-f10a814c-19a5-439b-9a37-113b1b2b5308.png) | ![image](https://user-images.githubusercontent.com/46433173/197359016-b6e35db0-af00-40b8-8f1e-500df117b0fc.png) |

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/197358894-88bce971-873f-47c1-9b75-71f29b0a5e12.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/197359113-08bd84d2-0812-4e6f-9b61-7dca43ad86ec.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/197358987-b860e89c-324f-44d9-8b12-084b8c1bf839.png)


### Prototipo de Interfaz 
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

- Arquitectura Documento/Vista mediante Patrón de Vista Separada

### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/197360526-deb01999-6783-4fa2-a016-b07b8e15a8a5.png)

### Namespace Mastermind

### Namespace Mastermind.ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/197416281-d2116719-5ba4-43b7-95c1-c32a3d839751.png)
 
### Namespace TicTacToe.Models

![image](https://user-images.githubusercontent.com/46433173/197415364-3a9ace59-5658-4116-aca0-cf1c25b9b60a.png)

### Namespace TicTacToe.Models.Types

![image](https://user-images.githubusercontent.com/46433173/197415463-97fea9ee-2631-4a52-ae0c-91b53f50c5a0.png)
