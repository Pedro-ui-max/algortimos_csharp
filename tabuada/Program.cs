//declaraçao de variaveis

double numero = 0.0;
double multiplicador = 0.0;
double resultado = numero * multiplicador;

Console.WriteLine("digite um numero");
 numero = Convert.ToDouble(Console.ReadLine());


while(multiplicador <=10)
{
    resultado = numero * multiplicador;
    Console.WriteLine($"{numero} x {multiplicador}={resultado}");
    multiplicador++;
}
{
    Console.WriteLine("fim da tabuada");
    Console.WriteLine("----------------");
    Console.WriteLine();
}