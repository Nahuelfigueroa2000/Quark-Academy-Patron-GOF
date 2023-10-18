# Patrones de Diseño GOF en C# 🛠️

Este repositorio demuestra la implementación de Patrones de Diseño GOF en programas escritos en C#. Los Patrones de Diseño son soluciones probadas para problemas comunes en el desarrollo de software. Los dividimos en tres categorías:

## Patrones Creacionales 🏭

Proveen diferentes formas de crear objetos:

- **Abstract Factory** 🏭: Proporciona una interfaz para crear familias de objetos relacionados sin especificar sus clases concretas.
- **Builder** 🛠️: Separa la construcción de un objeto complejo de su representación, permitiendo la creación de diferentes tipos de objetos.
- **Factory Method** 🏭: Define una interfaz para crear un objeto, pero permite a las subclases alterar el tipo de objetos que se crean.
- **Prototype** 📦: Especifica los tipos de objetos a crear mediante una instancia prototipo y crea nuevos objetos copiando este prototipo.
- **Singleton** ☝️: Asegura que una clase tenga solo una instancia y proporciona un punto de acceso global a esa instancia.

## Patrones Estructurales 🏗️

Describen formas de componer objetos para formar nuevas estructuras flexibles y eficientes:

- **Adapter** 🔄: Permite que las interfaces de una clase sean utilizadas como interfaces de otra clase.
- **Bridge** 🌉: Separa una abstracción de su implementación para que ambas puedan variar de manera independiente.
- **Composite** 🌲: Compone objetos en estructuras de árbol para representar jerarquías de parte-todo.
- **Proxy** 🕶️: Proporciona un representante o sustituto de otro objeto para controlar su acceso.

## Patrones de Comportamiento 🏃

Gestionan algoritmos y responsabilidades entre objetos:

- **Chain Of Responsibility** 📜: Permite pasar una solicitud a través de una cadena de manejadores. Cada manejador decide si procesa la solicitud o la pasa al siguiente.
- **Command** 📦: Encapsula una solicitud como un objeto, permitiendo parametrizar clientes con colas, solicitudes y operaciones.
- **Interpreter** 🗣️: Define una gramática para interpretar el lenguaje y proporciona un intérprete para evaluar sentencias en ese lenguaje.
- **Iterator** 🔂: Proporciona una forma de acceder secuencialmente a los elementos de una colección sin exponer su estructura interna.
- **Mediator** 🤝: Define un objeto que coordina la comunicación entre objetos en lugar de que se comuniquen directamente entre sí.
- **Memento** 📜: Captura y externaliza el estado interno de un objeto, permitiendo restaurar el objeto a ese estado en el futuro.
- **Observer** 👀: Define una dependencia uno a muchos entre objetos para que cuando uno cambie su estado, todos sus dependientes sean notificados y actualizados automáticamente.
- **State** 🟢🔴: Permite que un objeto altere su comportamiento cuando su estado interno cambia. El objeto parecerá tener una clase diferente.
- **Strategy** 🎯: Define una familia de algoritmos, encapsula cada uno de ellos y los hace intercambiables. Permite que el algoritmo varíe independientemente de los clientes que lo usan.
- **Template Method** 📑: Define el esqueleto de un algoritmo en una operación, dejando que las subclases proporcionen algunas de las implementaciones.
- **Visitor** 🏛️: Representa una operación a realizar en los elementos de una estructura de objetos. Permite definir una nueva operación sin cambiar las clases de los elementos.

¡Explora este repositorio para ver ejemplos de cómo se aplican estos patrones de diseño en programas escritos en C#! 🚀

## Compatibilidad con Visual Studio 💻

Todos los programas de este repositorio están diseñados para ser compatibles con **Visual Studio**, uno de los entornos de desarrollo más populares para aplicaciones C#. Puedes abrir y ejecutar estos programas en Visual Studio sin problemas. Asegúrate de tener instalado Visual Studio en tu sistema para aprovechar al máximo estos ejemplos de Patrones de Diseño GOF.

### Pasos para abrir y ejecutar en Visual Studio:

1. Clona o descarga este repositorio en tu computadora.
2. Abre Visual Studio.
3. Abre el proyecto correspondiente en Visual Studio.
4. Compila y ejecuta el programa.

¡Disfruta explorando y aprendiendo sobre los Patrones de Diseño GOF en Visual Studio! Si tienes alguna pregunta o necesitas ayuda, no dudes en contactar con nosotros.
