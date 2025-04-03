using System;
using System.Collections.Generic;

class Program
{

    public class Termino
    {
        public string Titulo { get; set; }
        public string Definicion { get; set; }


        public Termino(string titulo, string definicion)
        {
            Titulo = titulo;
            Definicion = definicion;
        }
    }

    static void Main()
    {
        List<Termino> terminos = new List<Termino>();

	terminos.Add(new Termino("Algoritmo", "Conjunto de instrucciones o reglas bien definidas que permiten resolver un problema o realizar una tarea."));
        terminos.Add(new Termino("API", "Interfaz de Programación de Aplicaciones, conjunto de funciones y procedimientos que permiten que un software interactúe con otro."));
        terminos.Add(new Termino("Compilador", "Programa que traduce el código fuente escrito en un lenguaje de programación a un lenguaje de bajo nivel o código máquina."));
        terminos.Add(new Termino("Depuración", "Proceso de identificar, corregir y eliminar errores o fallos en un programa de software."));
        terminos.Add(new Termino("Framework", "Conjunto de herramientas y bibliotecas que facilitan el desarrollo de aplicaciones al proporcionar una estructura prediseñada."));
        terminos.Add(new Termino("Base de datos", "Conjunto de datos organizados y almacenados de forma que se puedan consultar y manipular fácilmente."));
        terminos.Add(new Termino("Código fuente", "Conjunto de instrucciones escritas en un lenguaje de programación que puede ser leído y modificado por un programador."));
        terminos.Add(new Termino("Interfaz de usuario", "Conjunto de elementos gráficos o de texto mediante los cuales un usuario interactúa con un software o sistema."));
        terminos.Add(new Termino("Lenguaje de programación", "Lenguaje formal utilizado para escribir software, que permite a los programadores comunicar instrucciones a una computadora."));
        terminos.Add(new Termino("Algoritmo de búsqueda", "Método utilizado para encontrar un valor o elemento dentro de una estructura de datos."));
        terminos.Add(new Termino("Redes informáticas", "Conjunto de sistemas interconectados que permiten el intercambio de datos entre computadoras y otros dispositivos."));
        terminos.Add(new Termino("Sistema operativo", "Software que gestiona el hardware y los recursos del sistema, proporcionando servicios y control a las aplicaciones y usuarios."));
        terminos.Add(new Termino("Virtualización", "Tecnología que permite crear versiones virtuales de dispositivos físicos, como servidores, redes o almacenamiento."));
        terminos.Add(new Termino("Contenedor (Docker)", "Unidad estándar de software que empaqueta el código y sus dependencias para que la aplicación pueda ejecutarse de manera consistente en cualquier entorno."));
        terminos.Add(new Termino("Git", "Sistema de control de versiones distribuido que permite gestionar el historial de cambios en el código fuente de un proyecto."));
        terminos.Add(new Termino("Cloud Computing", "Modelo de computación basado en el acceso remoto a servicios y recursos informáticos a través de internet, como almacenamiento y procesamiento."));
        terminos.Add(new Termino("Big Data", "Conjunto de datos de gran volumen y complejidad que requieren herramientas avanzadas para su procesamiento y análisis."));
        terminos.Add(new Termino("Inteligencia artificial", "Área de la informática que busca crear máquinas o programas capaces de realizar tareas que normalmente requieren inteligencia humana."));
        terminos.Add(new Termino("Ciberseguridad", "Prácticas y tecnologías que protegen sistemas informáticos, redes y datos contra accesos no autorizados, ataques y daños."));
        terminos.Add(new Termino("Desarrollo ágil", "Metodología de desarrollo de software que promueve la entrega continua y la flexibilidad, trabajando en ciclos cortos y mejorando constantemente."));



        foreach (var termino in terminos)
        {
            Console.WriteLine($"Término: {termino.Titulo}");
            Console.WriteLine($"Definición: {termino.Definicion}");
            Console.WriteLine(); // Espacio entre términos
        }
    }
}