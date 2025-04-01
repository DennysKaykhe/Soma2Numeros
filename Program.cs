double number1;
double number2;
double soma;

Console.Clear();

Console.WriteLine("--- Cálculo da soma entre dois números ---");

Console.Write(@"
Digite o primeiro número: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o primeiro número: ");
number2 = Convert.ToDouble(Console.ReadLine());

soma = number1 + number2;

Console.WriteLine(@$"
Soma: {soma}");