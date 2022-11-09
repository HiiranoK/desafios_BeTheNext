/*
 * Em uma danceteria o preço da entrada sofre variações.
 * Segundas, Terças e Quintas, ela oferece um desconto de 25% do preço normal de entrada.
 * Nos dias de músicas ao vivo, o preço da entrada ainda é
 * acrescido em 15% em relação ao preço normal da entrada.
 * Faça um programa que leia o preço normal da entrada,
 * o dia da semana,e se é dia de música ao vivo (“Sim”) ou não (“Não”).
 * Calcular e imprimir o preço final que deverá ser pago pela entrada.
 */

double precoNormal, precoFinal, dia = 0, aoVivo = 0;
string diaDaSemana, diaDeAoVivo;
bool verificacao;

do
{
  System.Console.WriteLine("Digite o preço normal da entrada: ");
  verificacao = double.TryParse(Console.ReadLine(), out precoNormal);
} while (!verificacao || precoNormal < 0);

do
{
  System.Console.WriteLine("Digite a opção que corresponde ao dia da semana: \na - Segunda, Terça ou Quinta. \nb - Quarta, Sexta, Sábado ou Domingo.");
  diaDaSemana = Console.ReadLine().ToLower();
} while (diaDaSemana != "a" && diaDaSemana != "b");

do
{
  System.Console.WriteLine("Hoje é dia de música ao vivo? [s - sim ou n - nao] ");
  diaDeAoVivo = Console.ReadLine().ToLower();
} while (diaDeAoVivo != "s" && diaDeAoVivo != "n");

if(diaDaSemana == "a" && diaDeAoVivo == "s")
{
  precoFinal = (precoNormal * 0.75) * 1.15;

}

else if(diaDaSemana == "a" && diaDeAoVivo == "n")
{
  precoFinal = (precoNormal * 0.75);
}

else if(diaDaSemana == "b" && diaDeAoVivo == "s")
{
  precoFinal = precoNormal * 1.15;
}

else
{
  precoFinal = precoNormal;
}

System.Console.WriteLine($"Você escolheu a opção {diaDaSemana} para o dia da semana, em um dia em que {diaDeAoVivo} terá música ao vivo. \nPor isso, o preço final da entrada será de R$ {precoFinal.ToString("F2")}.");
System.Console.WriteLine();