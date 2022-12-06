Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new  int[8];

for (int  i = 0; i < n; i++)
{
    array[i] = new  Random().Next(0 , 100);
            Console.Write(array[i] + "; ");
            }
Console.WriteLine();