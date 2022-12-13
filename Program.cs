/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
/* 

int [] Set_array(int N)                  //задаем массив из N элементов
{
    int [] array = new int [N];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        array[i] = rnd.Next(100,1000);              //нужны трехзначные числа

    return (array);
}

void Print_array (int [] array)                    // печатаем массив
{
    int lenght_of_array = array.Length;

    for (int i = 0; i < lenght_of_array; i++)
         Console.Write($"{array[i]} ");

}

Console.WriteLine("ВВедите число элементов массива: ");         //здесь просим ввести число элементов
int N = Convert.ToInt32(Console.ReadLine());
int [] array = Set_array(N);                                    //наполняем массив 3хзначными числами

int count = 0;          //счетчик для четных чисел

for (int i=0; i<N; i++)             //считаем четные числа
{
    if (array[i]%2 == 0 ) count++;

}
 Console.WriteLine("Заданный массив: ");
Print_array(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел - {count}");

 */
 //конец первой задачи

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/* int [] Set_array(int N)                  //задаем массив из N элементов
{
    int [] array = new int [N];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        array[i] = rnd.Next(-1000,1000);              

    return (array);
}

void Print_array (int [] array)                    // печатаем массив
{
    int lenght_of_array = array.Length;

    for (int i = 0; i < lenght_of_array; i++)
         Console.Write($"{array[i]} ");

}

Console.WriteLine("ВВедите число элементов массива: ");         //здесь просим ввести число элементов
int N = Convert.ToInt32(Console.ReadLine());
int [] array = Set_array(N);                                    //наполняем массив числами

int sum = 0;          //сумма элементов на нечетных позициях

for (int i=0; i<N; i++)             
{
    if (i%2 == 1 ) sum = sum + array[i];

}
 Console.WriteLine("Заданный массив: ");
Print_array(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях {sum}");

 */
//конец второй задачи

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

[3 7 22 2 78] -> 76 */

double [] Set_array(int N)                  //метод для создания массива из N элементов из вещественных чисел
{
    double [] array = new double [(int)N];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        array[i] = rnd.NextDouble() + rnd.Next(-100,100);              

    return (array);

}void Print_array (double [] array)                    // метод для печатания массива
{
    int lenght_of_array = array.Length;

    for (int i = 0; i < lenght_of_array; i++)
         Console.Write($"{array[i]} ");

}

Console.WriteLine("ВВедите число элементов массива: ");         //здесь просим ввести число элементов
int N = Convert.ToInt32(Console.ReadLine());
double [] array = Set_array(N);                                 //создаем массив


double min_value = array[0];        //это для мин значения
double max_value = array[0];        // это для мах значения

for (int i=0; i < N; i++)           // находим мин и мах

{
    if (array[i] > max_value) max_value = array[i];
    else    
        if (array[i] <min_value) min_value = array[i];
 
}

Console.WriteLine("Заданный массив: ");
Print_array(array);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальными элементами {max_value - min_value}");
