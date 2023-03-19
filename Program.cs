//Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число
//A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите В: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;

    for (int i = 2; i <= B; i++)
    {
        result *= A;      //result= result*A
        Console.WriteLine($"{A}^{B} = {result}");
    }


//Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр
// в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int num = number % 10;
    number/=10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);

//Задача 29: Напишите программу, которая задаёт
//массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

int[] array = new int [8];     

for (int i = 0; i < 8; i++)
{
    array[i]=new Random().Next(1,99);
    Console.WriteLine(array[i]);
} 

