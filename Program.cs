// See https://aka.ms/new-console-template for more information
Console.Write("Enter radius : ");
int radius;
radius = Convert.ToInt32(Console.ReadLine());
double area, length;
area = Math.PI*radius*radius;
length = 2 * Math.PI * radius;
Console.WriteLine("S = "+area+" , "+"L = "+length);

Console.ReadKey();