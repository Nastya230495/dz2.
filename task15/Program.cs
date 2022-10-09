Console.Clear ();
Console.WriteLine ("Введите любое число");
int n = Convert.ToInt32 (Console.ReadLine());
string m = Convert.ToString(n);
if (m.Length >2)
Console.WriteLine ($"Третья цифра: {m[2]}");
else
Console.WriteLine("Третьей цифры нет");
