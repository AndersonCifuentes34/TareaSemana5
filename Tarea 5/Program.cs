//1. Crear una función que calcule el area del circulo, recibiendo como parámetro el radio.
using System;

public static class CalculadoraDeCirculo
{
    public static double CalcularAreaCirculo(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }
}

public static class Programa
{
    static void Main(string[] args)
    {
        double radio = 5.0;
        double area = CalculadoraDeCirculo.CalcularAreaCirculo(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es {area}");
    }
}


//2. Crear una función que calcule el perimetro de un rectangulo, recibiendo como parámetros el ancho y la altura.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double width = 5.0; //Es un ejemplo de ancho
        double height = 3.0; //Es un ejemplo de altura
        double perimeter = CalculateRectanglePerimeter(width, height);
        Console.WriteLine("El Perimetro del rectangulo es: {0}", perimeter);
    }

    static double CalculateRectanglePerimeter(double width, double height)
    {
        return 2 * (width * height);
    }
}


//3. Crear una función que calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 5, 10, 15, 20 }; //Es un ejemplo de la lista de números

        double average = CalculateListAverage(numbers);
        Console.WriteLine("El promedio de la lista de números es: {0}", average);
    }

    static double CalculateListAverage(List<int> numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Count;
    }
}


//4.Crear una función que determine si un número es par o impar, recibiendo como parámetro el número.

using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 5; // Ejemplo de número
        string result = CheckEvenOdd(number) ? "par" : "impar";
        Console.WriteLine("El número {0} es {1}", number, result);
    }

    static bool CheckEvenOdd(int number)
    {
        return number % 2 == 0;
    }
}


//5.Crear una función que convierta una cadena a mayúsculas, recibiendo como parámetro la cadena.
using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Hola, mundo!"; // Ejemplo de cadena de texto
        string upperCaseText = ConvertToUpperCase(text);
        Console.WriteLine("La cadena en mayúsculas es: {0}", upperCaseText);
    }

    static string ConvertToUpperCase(string text)
    {
        return text.ToUpper();
    }
}


//6.Crear una función que calcule la distancia entre dos puntos en un plano cartesiano, recibiendo como parámetros las coordenadas x e y de ambos puntos.
using System;

class Program
{
    static void Main(string[] args)
    {
        int x1 = 2, y1 = 3; // Ejemplo de coordenadas del primer punto
        int x2 = 5, y2 = 7; // Ejemplo de coordenadas del segundo punto
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("La distancia entre los puntos ({0}, {1}) y ({2}, {3}) es {4:F2}", x1, y1, x2, y2, distance);
    }

    static double CalculateDistance(int x1, int y1, int x2, int y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}


//7.Crear una función que calcule la suma de los primeros n números naturales, recibiendo como parámetro el número n.
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // Ejemplo de número n
        int sum = CalculateSum(n);
        Console.WriteLine("La suma de los primeros {0} números naturales es {1}", n, sum);
    }

    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}


//8.Crear una función que calcule el factorial de un número, recibiendo como parámetro el número.
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Ejemplo de número n
        int factorial = CalculateFactorial(n);
        Console.WriteLine("El factorial de {0} es {1}", n, factorial);
    }

    static int CalculateFactorial(int n)
    {
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}