/*
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 
3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координаты Х, Y, Z первой точки:");
double point_a_x = Convert.ToDouble(Console.ReadLine());
double point_a_y = Convert.ToDouble(Console.ReadLine());
double point_a_z = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите координаты Х, Y, Z первой точки:");
double point_b_x = Convert.ToDouble(Console.ReadLine());
double point_b_y = Convert.ToDouble(Console.ReadLine());
double point_b_z = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(point_b_x - point_a_x,2 ) + Math.Pow(point_b_y - point_a_y,2) + Math.Pow(point_b_z - point_a_z,2));
System.Console.WriteLine($"длина отрезка равна {Math.Round(length,2)}");