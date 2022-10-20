# - - - - - Mastermind Practice -- - - - -


**índice***
1. [Requisitos](#Requisitos)
2. [Vista de Casos de Uso](#Vista-de-Casos-de-Uso)
    - 2.1 [Vsita de Caso de Uso Start](#Vsita-de-Caso-de-Uso-Start)
    - 2.2 [Vsita de Caso de Uso Play](#Vsita-de-Caso-de-Uso-Play)
    - 2.3 [Vsita de Caso de Uso Resume](#Vsita-de-Caso-de-Uso-Resume)
    - 2.4 [Prototipo de Interfaz](#Prototipo-de-Interfaz)
3. [Análisis](#Analisis)
    - 3 [Arquitectura](#Arquitectura)
    - 3.1 [Namespace Mastermind-ConsoleApp](#Namespace-MastermindConsoleApp)
    - 3.2 [Namespace Mastermind-Utils](#TNamespace-Mastermind-ToeUtils)

### Requisitos

| * _Funcionalidad: **Sencilla**_<br/>  * _Interfaz: **Texto**_<br/>  * _Distribución: **Standalone**_<br/>  * _Persistencia: **No**_<br/> | ![image](https://user-images.githubusercontent.com/46433173/196945659-de5ef1f9-e5c1-4e26-9c4a-69de9ec0b8aa.png) | 
| :------- | :------: |  

### Vista de Casos de Uso

| Diagrama de Actores y Casos de Uso | Diagrama de Contexto |
|---|---|
| ![image](https://user-images.githubusercontent.com/46433173/196956510-c098110f-0fc4-4308-91d2-b75ff77d2c3a.png) | ![image](https://user-images.githubusercontent.com/46433173/196956586-8aa8c8ab-98c0-4ec7-81f5-9beeb1d82f99.png)

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/196956738-4955a6eb-0606-4ac2-a1b1-809d6896fa6d.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/196956891-ffea6860-9842-46d5-ac9d-eb0ab3fd3a8c.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/196956830-6bdb96e9-c941-4de6-b200-7ccc6b0e3280.png)

### Prototipo de Interfaz
***Partida Ganada***
```
---- Mastermind ----
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

### Análisis

### Arquitectura

### Namespace Mastermind-ConsoleApp

### Namespace Mastermind-Utils