//algoritmo para calcular a media escolar
double nota1 =0.0;
double nota2 =0.0;
double nota3 =0.0;
double nota4 =0.0;
double media =0.0;

//interaçao com o usuario 
Console.WriteLine("diga a sua primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("diga a sua segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("diga a sua terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("diga a sua quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4 ) /4;

if(media >=7 ){
Console.WriteLine("voce foi aprovado: ");
}
else{ 
    Console.WriteLine("voce foi reprovado: ");
}