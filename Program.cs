using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables de diferentes tipos
            int edad = 18;
            double estatura = 1.65;
            string nombre = "Luis";
            char inicial = 'L';
            bool estudiante = true;

            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + estatura);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Inicial: " + inicial);
            Console.WriteLine("¿Eres estudiante? " + estudiante);

            //jercicio 2 Captura de datos por consola
            Console.WriteLine("Ingrese su nombre:");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            int Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Está inscrito en un curso? (true/false):");
            bool inscrito = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años. ¿Inscrito? " + inscrito);

            //Ejercicio 3 comparación de tipos de datos
            int a = 5;
            int b = 7;
            string c = "10";

            Console.WriteLine(a + b); // suma normal = 12
                                      // Console.WriteLine(a + c); ERROR: no se puede sumar int + string directamente

            //Ejercicio 4 conversión de tipos de datos (casting)
            double precio = 9.99;
            int precioEntero = (int)precio; // casting explícito (trunca)

            Console.WriteLine("Precio (double): " + precio);
            Console.WriteLine("Precio (int): " + precioEntero);

            //Ejercicio 5: uso de var y dynamic
            var numero = 10;      
            dynamic valor = 20;    
            Console.WriteLine(valor);

            valor = "esta variable ahora es texto";
            Console.WriteLine(valor);

            // Ejercicio 6: pide dos numeros al usuario y muestra suma resta multiplicación y división
            Console.WriteLine("Ingrese el primer número:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double suma = n1 + n2;
            double resta = n1 - n2;
            double producto = n1 * n2;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Producto: " + producto);

            if (n2 != 0)
            {
                double division = n1 / n2;
                Console.WriteLine("División: " + division);
            }
            else
            {
                Console.WriteLine("División: no se puede dividir entre cero");
            }

            //Respuesta a preguntas teóricas:

            // PREGUNTA 1
            // Qué diferencia hay entre char y string en C# vs JavaScript?
            // En C#, 'char' es un tipo de dato que representa un solo carácter Unicode,
            // mientras que 'string' es una secuencia de caracteres.
            // En JavaScript, no existe un tipo de dato 'char';
            // en su lugar, los caracteres individuales se representan como cadenas de longitud uno (string).

            // PREGUNTA 2
            // ¿Por qué char requiere comillas simples?
            // En C#, las comillas simples se utilizan para definir literales de tipo 'char',

            //PREGUNTA EJERCICIO 2: ¿Por qué se utiliza Cnvert.ToInt32()?
            //Porque la entrada del usuario llega como texto (string).
            //Si queremos trabajarla como número, necesitamos convertirla.
            //Si no, el compilador se quejaría.

            //PREGUNTAS EJERCICIO 3:
           // ¿Este comportamiento se parece a JavaScript?
           //No.En JavaScript sí se puede hacer 5 + "10" y el resultado sería "510"(concatena).

             //¿En C# se permite concatenar número + string como en JavaScript?
             //Sí, pero no directo.En C# el número se convierte a texto automáticamente
             //solo si usas + con un string.


        }

    }
}
