using System;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prueba de la clase Persona
            Console.WriteLine("Prueba de la clase Persona:");

            Persona persona1 = new Persona("Ryan", "Ortiz", 18, true, "2024-0246");
            persona1.Programar();

            Persona persona2 = new Persona("Iluminada", "Campos", 45, false, "87654321B");
            persona2.Enseñar();

            Persona persona3 = new Persona("Pedro", "Ortiz", 50, true, "11223344C");
            persona3.Curar();

            Persona persona4 = new Persona("Martha", "Campos", 57, false, "44332211D");
            persona4.Programar();

            Persona persona5 = new Persona("Raul", "Ortiz", 43, true, "55667788E");
            persona5.Enseñar();

            Persona persona6 = new Persona("Lucia", "Fernandez", 28, false, "99887766F");
            persona6.Curar();

            Persona persona7 = new Persona("Miguel", "Sanchez", 20, true, "66778899G");
            persona7.Programar();

            Console.WriteLine();

            // Prueba de la clase Cuenta
            Console.WriteLine("Prueba de la clase Cuenta:");
            Cuenta cuenta1 = new Cuenta(1000);
            cuenta1.Ingreso(500);
            cuenta1.Reintegro(200); 
            Cuenta cuenta2 = new Cuenta(300);
            cuenta1.Transferencia(cuenta2, 150);
            Console.WriteLine();

            // Prueba de la clase Contador
            Console.WriteLine("Prueba de la clase Contador:");
            Contador contador = new Contador(10);
            contador.Incrementar();
            contador.Decrementar();
            Console.WriteLine();

            // Prueba de la clase Libro
            Console.WriteLine("Prueba de la clase Libro:");
            Libro libro1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez");
            Console.WriteLine(libro1.ToString());
            libro1.Prestar();
            libro1.Devolver();
            Console.WriteLine();

            // Prueba de la clase Fraccion
            Console.WriteLine("Prueba de la clase Fracción:");
            Fraccion fraccion1 = new Fraccion(1, 2);
            Fraccion fraccion2 = new Fraccion(3, 4);
            Fraccion resultadoSuma = fraccion1.Sumar(fraccion2);
            Fraccion resultadoResta = fraccion1.Restar(fraccion2);
            Fraccion resultadoMultiplicacion = fraccion1.Multiplicar(fraccion2);
            Fraccion resultadoDivision = fraccion1.Dividir(fraccion2);

            Console.WriteLine($"Suma: {fraccion1} + {fraccion2} = {resultadoSuma}");
            Console.WriteLine($"Resta: {fraccion1} - {fraccion2} = {resultadoResta}");
            Console.WriteLine($"Multiplicación: {fraccion1} * {fraccion2} = {resultadoMultiplicacion}");
            Console.WriteLine($"División: {fraccion1} / {fraccion2} = {resultadoDivision}");
        }
    }

    /* 1. Considera estás desarrollando un programa donde necesitas trabajar con objetos de tipo Persona.
    Define una clase Persona, pero en este caso considerando los siguientes atributos de clase: nombre (String), 
    apellidos (String), edad (int), casado (boolean), numeroDocumentoIdentidad (String) y 3 métodos como acciones 
    diferentes por persona de acuerdo a una profesión. efine un constructor y los métodos para poder establecer y 
    obtener los valores de los atributos. Mínimo 7 personas diferentes con acciones diferentes. */
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }
        public string NumeroDocumentoIdentidad { get; set; }

        public Persona(string nombre, string apellidos, int edad, bool casado, string numeroDocumentoIdentidad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Casado = casado;
            NumeroDocumentoIdentidad = numeroDocumentoIdentidad;
        }

        public void Programar() => Console.WriteLine($"{Nombre} está programando.");
        public void Enseñar() => Console.WriteLine($"{Nombre} está enseñando.");
        public void Curar() => Console.WriteLine($"{Nombre} está curando a un paciente.");
    }

    /* 2. Crea una clase Cuenta con los métodos ingreso, reintegro y transferencia.
    La clase contendrá un constructor por defecto, un constructor con parámetros y 
    los métodos getters y setters para mostrar e ingresar. */
    public class Cuenta
    {
        public double Saldo { get; private set; }

        public Cuenta() => Saldo = 0;

        public Cuenta(double saldoInicial) => Saldo = saldoInicial;

        public void Ingreso(double cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine($"Se han ingresado {cantidad}. Saldo actual: {Saldo}");
        }

        public void Reintegro(double cantidad)
        {
            if (cantidad <= Saldo)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad}. Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el reintegro.");
            }
        }

        public void Transferencia(Cuenta cuentaDestino, double cantidad)
        {
            if (cantidad <= Saldo)
            {
                Saldo -= cantidad;
                cuentaDestino.Ingreso(cantidad);
                Console.WriteLine($"Transferencia de {cantidad} realizada. Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar la transferencia.");
            }
        }
    }

    /* 3. Crea una clase Contador con los métodos para incrementar y decrementar el contador.
    La clase contendrá un constructor por defecto, un constructor con parámetros y los 
    métodos getters y setters. */
    public class Contador
    {
        public int Valor { get; private set; }

        public Contador() => Valor = 0;

        public Contador(int valorInicial) => Valor = valorInicial;

        public void Incrementar() => Console.WriteLine($"Valor incrementado: {++Valor}");

        public void Decrementar() => Console.WriteLine($"Valor decrementado: {--Valor}");
    }

    /* 4. Crea una clase Libro con los métodos préstamo, devolución y ToString. La clase contendrá 
     * un constructor por defecto, un constructor con parámetros y los métodos getters y setters. */
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Prestado { get; private set; }

        public Libro()
        {
            Titulo = "Sin título";
            Autor = "Desconocido";
            Prestado = false;
        }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Prestado = false;
        }

        public void Prestar()
        {
            if (!Prestado)
            {
                Prestado = true;
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' ya está prestado.");
            }
        }

        public void Devolver()
        {
            if (Prestado)
            {
                Prestado = false;
                Console.WriteLine($"El libro '{Titulo}' ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' no estaba prestado.");
            }
        }

        public override string ToString() => $"Título: {Titulo}, Autor: {Autor}, Prestado: {Prestado}";
    }

    // 5. Crea una clase Fracción con métodos para sumar, restar, multiplicar y dividir fracciones.
    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int num = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int den = Denominador * otra.Denominador;
            return new Fraccion(num, den);
        }

        public Fraccion Restar(Fraccion otra)
        {
            int num = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int den = Denominador * otra.Denominador;
            return new Fraccion(num, den);
        }

        public Fraccion Multiplicar(Fraccion otra)
        {
            int num = Numerador * otra.Numerador;
            int den = Denominador * otra.Denominador;
            return new Fraccion(num, den);
        }

        public Fraccion Dividir(Fraccion otra)
        {
            int num = Numerador * otra.Denominador;
            int den = Denominador * otra.Numerador;
            return new Fraccion(num, den);
        }

        public override string ToString() => $"{Numerador}/{Denominador}";
    }
}