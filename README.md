# Laboratorio 3 - Clases, Validaciones e Interfaces en C#

Repositorio correspondiente al **Laboratorio #3** de la asignatura **Herramientas de la Programación Aplicada III**.

## Descripción

Este laboratorio tiene como objetivo aplicar conceptos de programación orientada a objetos en C# mediante el desarrollo de aplicaciones de consola y aplicaciones gráficas con Windows Forms.

Durante el laboratorio se trabajan clases, objetos, propiedades, encapsulamiento, validaciones de datos, colecciones de objetos y diferentes controles de Windows Forms. También se implementa el juego de **Craps** como ejercicio de lógica de programación orientada a objetos.


## Contenido del Laboratorio

### Caso 1 - Aplicación Windows Forms

Aplicación gráfica para registrar y visualizar información utilizando una clase `Persona`.

Se trabajan datos como:

- ID
- Nombres
- Apellidos
- Correo electrónico
- Fecha de nacimiento
- Salario

La información ingresada se almacena en una colección de objetos y posteriormente se muestra mediante un `DataGridView`.

También se implementan validaciones para evitar datos incorrectos o campos vacíos.

**Resultado**

<img width="758" height="588" alt="image" src="https://github.com/user-attachments/assets/c137174f-1d5a-4033-9207-41a25a370621" />


### Caso 2 - Juego de Craps

Implementación del juego de dados **Craps** mediante una aplicación de consola.

En este ejercicio se aplican:

- Clases y objetos.
- Métodos.
- Generación de números aleatorios.
- Enumeraciones (`enum`).
- Estructuras de control.
- Estados del juego.
- Lógica para determinar si el jugador gana, pierde o continúa jugando.

## Controles y Componentes Utilizados

- `TextBox`
- `DateTimePicker`
- `DataGridView`
- `ToolStrip`
- `ToolStripButton`
- `ErrorProvider`

## Validaciones

El laboratorio utiliza diferentes mecanismos para validar los datos ingresados por el usuario:

- Verificación de campos vacíos.
- Validación de correos electrónicos mediante expresiones regulares.
- Conversión segura de valores numéricos mediante `decimal.TryParse`.
- Uso de `ErrorProvider` para mostrar visualmente los errores en los controles.

**Resultado**

<img width="383" height="172" alt="image" src="https://github.com/user-attachments/assets/ac6afa3c-44d8-4c2e-8f2d-5a8955636c28" />


## MDI - Multiple Document Interface

También se estudia el uso de interfaces MDI en Windows Forms, donde un formulario principal puede funcionar como contenedor de diferentes formularios hijos.

Entre los conceptos utilizados se encuentran:

- `IsMdiContainer = true`
- Formularios padre
- Formularios hijos
- Apertura de formularios desde menús
- Organización de múltiples ventanas dentro de una aplicación

**Resultado**

<img width="946" height="627" alt="image" src="https://github.com/user-attachments/assets/f03b3b30-f3c9-4584-a886-06154251e775" />


## Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET
- **Interfaz gráfica:** Windows Forms
- **IDE:** Visual Studio
- **Control de versiones:** Git
- **Repositorio:** GitHub



## Autor

**Aimee Matias 4-751-2038**

Laboratorio #3  
Herramientas de la Programación Aplicada III (.NET)  
