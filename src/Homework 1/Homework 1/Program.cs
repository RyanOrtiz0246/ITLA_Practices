using System;

class Program
{
    static void Main()
    {
        // 1. Declarar variables de diferentes tipos, asignarles valor e imprimir el valor.
        int number = 23;
        string text = "goodafternoon, i am Ryan";
        double matricula = 2024.0246;
        bool isTrue = true;

        Console.WriteLine($"Int Number: {number}");
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Decimal Number: {matricula}");
        Console.WriteLine($"Is True: {isTrue}");

        // 2. Declarar una constante en C# e imprimir el valor.
        /*
        En C#, las constantes se declaran utilizando la palabra clave const. Una constante
        es un valor que no puede cambiar una vez que ha sido asignado.
        */
        const int eternal = 100;
        Console.WriteLine($"Const: {eternal}");
        // Intentar cambiar el valor de la constante (esto causará un error de compilación)

        // 3. Declarar un entero, incrementarlo, decrementarlo, hacer operaciones con él.
        int value = 20;
        value++;
        value--;
        value += 10;
        value *= 2;
        Console.WriteLine($"Value after operations: {value}");

        // 4. Declarar un float con valor 10152466.25. Declarar un byte que es igual a 5 + el float.
        float bigNumber = 10152466.25f;
        byte smallNumber = (byte)(5 + bigNumber);
        Console.WriteLine("Float: " + bigNumber);
        Console.WriteLine("Byte: " + smallNumber);// El valor puede ser inesperado debido al desbordamiento.

        // 5. Imprimir la fecha y hora del sistema.
        DateTime currentdate = DateTime.Now;
        Console.WriteLine($"Current date and time: {currentdate}");
    }
}