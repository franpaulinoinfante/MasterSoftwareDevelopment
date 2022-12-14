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
| ![image](https://user-images.githubusercontent.com/46433173/196956510-c098110f-0fc4-4308-91d2-b75ff77d2c3a.png) | ![image](https://user-images.githubusercontent.com/46433173/196988400-31a9cba4-1d25-4ec3-ae77-2e92516fc27b.png)
| :------- |

### Vsita de Caso de Uso Start

![image](https://user-images.githubusercontent.com/46433173/196991691-1f9f3ba5-c440-4744-8507-05ac6bdb2384.png)

### Vsita de Caso de Uso Play

![image](https://user-images.githubusercontent.com/46433173/196995680-46a27a69-ed66-4182-aa05-111c35ffaf0a.png)

### Vsita de Caso de Uso Resume

![image](https://user-images.githubusercontent.com/46433173/196991806-e4c1d0d1-c480-4bd5-9bf0-0a40e398aa7b.png)

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

## Vista Lógica

- Aplicación del Modelo del Dominio mediante:
    - Estrategias de Clasificación:
        - Descripción Informal
        - Análisis Clásico 
        - Análisis Experto del Dominio
        - Análisis del Comportamiento 
        - Reparto de Responsabilidades
        - Análisis de Casos de Uso
        - Separación de Asunto
    - Relaciones entre Clases
        - Relación entre Clases por Colaboración
            - Relación de Composición/Agregación
            - Relación de Asociación
            - Relación de Dependencia/Uso 
        - Relación Por Extensión "Herencia"

### Análisis
Analizar los requisistos a través de su refinamiento y estructura para realizar una compresión precisa de los requisitos, una descripción de los requisitos que es facil de mantener y ayuda a estructurar el sistema:
- Dar una especificación más precisa de los requisitos obtenidos en la captura de requisitos
- Describir usando el lenguaje de los desarrolladores y poder introducir más formalismo y ser utilizado para razonar sobre el funcionamiento interno del sistema.
- Estructurar los requisitos de manera que facilite su compresión, cambiábndoloes y en general mantenerlo.
- Acercase al diseño, auque sea un modelo en sí mismo, y es por tanto un elemento esencial cuando el sistema está conformado en diseño e implementacion


### Arquitectura

![image](https://user-images.githubusercontent.com/46433173/196999637-53f179c9-11f7-4c9d-bff3-8992f128c5ac.png)

### Namespace Mastermind-ConsoleApp

![image](https://user-images.githubusercontent.com/46433173/197250790-bf06593a-ad16-4321-acb0-d88e5870dfd5.png)

### Namespace Mastermind-Types

![image](https://user-images.githubusercontent.com/46433173/197250528-b114b1ef-29ea-4e59-8f4e-23ed1d4c7f9e.png)
