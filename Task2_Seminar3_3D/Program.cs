// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
System.Console.Write(str);
return Convert.ToInt32(Console.ReadLine());
}

int X1 = InputNumber("Введите координату X1: ");
int Y1 = InputNumber("Введите координату Y1: ");
int Z1 = InputNumber("Введите координату Z1: ");

int X2 = InputNumber("Введите координату X2: ");
int Y2 = InputNumber("Введите координату Y2: ");
int Z2 = InputNumber("Введите координату Z2: ");

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)),2));


