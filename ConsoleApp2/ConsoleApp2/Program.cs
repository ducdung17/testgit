using System;

class MyClass
{
    // 1. Свойства класса
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }
    public double DoubleProperty { get; set; }
    public string? NullableStringProperty { get; set; }
    public int? NullableIntProperty { get; set; }
    public double? NullableDoubleProperty { get; set; }

    // 2. Метод для вывода информации о классе
    public void PrintInfo()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"StringProperty: {StringProperty ?? "Данные отсутствуют"}");
        Console.WriteLine($"IntProperty: {IntProperty}");
        Console.WriteLine($"DoubleProperty: {DoubleProperty}");
        Console.WriteLine($"NullableStringProperty: {NullableStringProperty ?? "Данные отсутствуют"}");
        Console.WriteLine($"NullableIntProperty: {NullableIntProperty}");
        Console.WriteLine($"NullableDoubleProperty: {NullableDoubleProperty}");
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        // 3. Создаем экземпляры класса и заполняем свойства
        var obj1 = new MyClass
        {
            StringProperty = "Привет, мир!",
            IntProperty = 42,
            DoubleProperty = 3.14,
            NullableStringProperty = null,
            NullableIntProperty = 123,
            NullableDoubleProperty = null
        };

        var obj2 = new MyClass
        {
            StringProperty = "Hello",
            IntProperty = 50,
            DoubleProperty = 2.71,
            NullableStringProperty = "World",
            NullableIntProperty = null,
            NullableDoubleProperty = 2.0
        };

        // 4. Вызываем метод PrintInfo для каждого экземпляра
        obj1.PrintInfo();
        obj2.PrintInfo();

        // 5. Попробуем присвоить null свойству типа string, которое не может принимать null
        // Это вызовет ошибку компиляции, так как StringProperty не является nullable:
        // obj1.StringProperty = null; // Ошибка компиляции

        // 6. Попробуем присвоить null свойству типа int или double, которое не может принимать null
        // Это также вызовет ошибку компиляции:
        // obj1.IntProperty = null; // Ошибка компиляции
        // obj1.DoubleProperty = null; // Ошибка компиляции

        // 7. Создаем переменную типа int и присваиваем ей значение длины строки StringProperty
        // и указываем, что свойство StringProperty заведомо не равно null
        int lengthOfStringProperty = obj1.StringProperty.Length;

        // 8. Функция, которая присваивает nullable свойству значение, если оно null
        obj1.NullableStringProperty ??= "Значение по умолчанию";

        // 9. Функция, которая возвращает значение некоторого свойства или константу, если входной аргумент nullable
        string result1 = obj1?.StringProperty ?? "Константа";

        // 10. Функция, которая возвращает значение некоторого nullable свойства или константу, если оно null
        string? result2 = obj1.NullableStringProperty ?? "Константа";

        // 11. Подавление предупреждения компилятора для первого свойства типа string
#pragma warning disable CS8602
        string suppressedWarning = obj1.StringProperty;
#pragma warning restore CS8602
    }
}
