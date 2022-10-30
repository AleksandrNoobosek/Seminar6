
//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
float IntersectionX(float b1,float b2,float k1,float k2)
{
return (b2-b1)/(k1-k2);
}
float IntersectionY(float b2,float k2, float X)
{
return (k2 * X) + b2;
}
//Показать числа Фибоначчи
double Fibonacci(int n)
{
 int fib = 0;
 int f1 = 1;
 int f2 = 1;
 if(n == 1 || n == 2) return 1;
    else   
    {
        for(int i = 2; i < n; i++)
        {
            fib = f1 + f2;
            f1 = f2; 
            f2 = fib;
        }
        return fib;
    } 
}
//Написать программу копирования массива vers 1
void Scaling (float[] Sca,float k)
{
    for(int i = 0; i < Sca.Length; i++)
            Sca[i] = Sca[i]*k;
}
void PrintScaling (float[] Sca)
{
    for(int i = 0; i < Sca.Length; i++)
            Console.Write($"{Sca[i]}, ");
}
//Написать программу копирования массива vers 2
string Scaling2(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float kof)
{
    x1 = x1 * kof; y1 = y1 * kof; x2 = x2 * kof; y2 = y2 * kof;
    x3 = x3 * kof; y3 = y3 * kof; x4 = x4 * kof; y4 = y4 * kof;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
}
//Написать программу копирования массива
void FillArray(int[] Array,int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < Array.Length; i++) 
        Array[i] = random.Next(min, max);
}
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.Write(Array[i]);
}
int[] IntCopyArr(int[] Array)
{
    int[] CopyArr1 = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
       CopyArr1[i] = Array[i];
    }
    return CopyArr1;
}
void VoidCopyArr(int[] Array, int []CopyArr2)
{
    for (int i = 0; i < Array.Length; i++)
        CopyArr2[i] = Array[i];
}


Console.Clear();

// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы ");
Console.WriteLine("значение b1: ");
float b1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("значение b2: ");
float b2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("значение k1: ");
float k1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("значение k2: ");
float k2 = float.Parse(Console.ReadLine() ?? "0");

float X = IntersectionX(b1,b2,k1,k2);
float Y = IntersectionY(b2,k2,X);
if(k1==k2) Console.WriteLine(" !!! прямые параллельны !!! ");
else Console.WriteLine($"точку пересечения двух прямых[({X}), ({Y})]");

Console.ReadKey();
Console.Clear();

//Показать числа Фибоначчи
Console.WriteLine("Показать числа Фибоначчи ");
Console.WriteLine("Введите значение Фибоначчи: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Fibonacci(n);
for (int i = 1; i <= n; i++)
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");

 Console.ReadKey();
Console.Clear();
 
// Написать программу масштабирования фигуры
Console.WriteLine("Написать программу масштабирования фигуры ");
//Написать программу копирования массива vers 1
float [] Sca = {0,0,4,0,4,4,0,4};

Console.WriteLine("Ваши координаты (0,0,4,0,4,4,0,4)");

Console.WriteLine("Введите коэффициент масштабирования: ");
float k = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Результат маштабирования");
Scaling (Sca,k);
PrintScaling (Sca);

Console.ReadKey();
Console.Clear();
//Написать программу копирования массива vers 2
Console.WriteLine("Введите значение точек: ");
float x1 = float.Parse(Console.ReadLine() ?? "0");
float y1 = float.Parse(Console.ReadLine() ?? "0");
float x2 = float.Parse(Console.ReadLine() ?? "0");
float y2 = float.Parse(Console.ReadLine() ?? "0");
float x3 = float.Parse(Console.ReadLine() ?? "0");
float y3 = float.Parse(Console.ReadLine() ?? "0");
float x4 = float.Parse(Console.ReadLine() ?? "0");
float y4 = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите коэффициент масштабирования: ");
float kof = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{Scaling2(x1,y1,x2,y2,x3,y3,x4,y4,kof)}");


Console.ReadKey();
Console.Clear();

//Написать программу копирования массива
Console.WriteLine("Написать программу копирования массива ");
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[] Array = new int[size];

Console.WriteLine("Введите значение min: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.WriteLine("Введите значение max: ");
int max = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

FillArray(Array,min,max);
Console.WriteLine(" Оригинальный массив: ");
PrintArray (Array);
Console.WriteLine();

Console.WriteLine(" Копия массива: ");
PrintArray (IntCopyArr(Array));
Console.WriteLine();
Console.WriteLine(" Копия массива: ");
int[] CopyArr2 = new int[Array.Length];
VoidCopyArr(Array,CopyArr2);
PrintArray (CopyArr2);

Console.ReadKey();
