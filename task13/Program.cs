Console.Clear ();
Console.WriteLine ("Введите цифру от 1 до 7");
int n = Convert.ToInt32 (Console.ReadLine());
while (n<1 || n>7)
{
    Console.Write ("Вы ошиблись. Введите цифру от 1 до 7");
    n = Convert.ToInt32 (Console.ReadLine());
}
if (n<=5)
    Console.WriteLine ("Нет");
if (n>5)
Console.WriteLine ("Да");
