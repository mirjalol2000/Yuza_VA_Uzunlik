// See https://aka.ms/new-console-template for more information
/*Console.Write("Enter radius : ");
int radius;
radius = Convert.ToInt32(Console.ReadLine());
double area, length;
area = Math.PI*radius*radius;
length = 2 * Math.PI * radius;
Console.WriteLine("S = "+area+" , "+"L = "+length);

Console.ReadKey();*/

// 2. Valyuta konvertatsiya
/*Console.Write("Summani kiriting : ");
int summa = Convert.ToInt32(Console.ReadLine());
Console.Write("Kursni kiriting : ");
int kurs = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Summa : "+summa*kurs+" so'm");*/

// 3.Yoshni hisoblash
Console.Write("Tugilgan yilingiz kiriting : ");
int userAge = Convert.ToInt32(Console.ReadLine());
DateTime nowDate = DateTime.Now;
Console.WriteLine((nowDate.Year - userAge)*365);