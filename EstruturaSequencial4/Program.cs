using System.Globalization;

int numFunc = int.Parse(Console.ReadLine());
int horaTrab = int.Parse(Console.ReadLine());
double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salario = horaTrab * valorPorHora;

Console.WriteLine("NUMBER = " + numFunc);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));