using System;

class IsoscelesTriangle
{
    // Поля для сторон треугольника
    private double a, b, c;

    // Конструктор по умолчанию
    public IsoscelesTriangle()
    {
        a = 1.0;
        b = 1.0;
        c = 1.0;
    }

    // Конструктор с параметрами
    public IsoscelesTriangle(double side1, double side2, double side3)
    {
        a = side1;
        b = side2;
        c = side3;
    }

    // Метод для проверки существования треугольника
    public bool Exists()
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Метод для вычисления периметра
    public double Perimeter()
    {
        return a + b + c;
    }

    // Метод для вычисления площади
    public double Area()
    {
        double p = Perimeter() / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Метод для вывода информации о треугольнике
    public void Display()
    {
        Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        if (Exists())
        {
            Console.WriteLine("Треугольник существует.");
            Console.WriteLine($"Периметр: {Perimeter()}");
            Console.WriteLine($"Площадь: {Area()}");
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем треугольник с параметрами
        IsoscelesTriangle triangle1 = new IsoscelesTriangle(5.0, 5.0, 8.0);
        triangle1.Display();

        // Создаем треугольник с параметрами по умолчанию
        IsoscelesTriangle triangle2 = new IsoscelesTriangle();
        triangle2.Display();

        // Присваивание значений от одного треугольника другому
        triangle2 = triangle1;  // Просто присваивание, без перегрузки оператора
        Console.WriteLine("После присваивания:");
        triangle2.Display();
    }
}
