//declaraçao de variavel
double numero = 0.0;

//interaçao com o usuario

Console.WriteLine("digite um numero: ");
numero = Convert.ToDouble(Console.ReadLine());

while(numero > 0)
{
    numero= numero -1;
    Console.WriteLine(numero);
}
{
    Console.WriteLine("fim da contagem ");
}