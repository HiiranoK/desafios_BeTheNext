/* Escreva um programa que leia um número inteiro maior do que zero
 e devolva, na tela, a soma de todos os seus algarismos.
 Por exemplo, ao número 251 corresponderá o valor 8 (2 + 5 + 1).
 Se o número lido não for maior do que zero,
 o programa terminará com a mensagem “Número inválido”.
*/

int soma = 0;
int numero, digito, numeroDigitado;
bool verificacao;

System.Console.WriteLine("Olá, tudo bem? \nEsse programa calcula a soma de todos os algarismos do número que vocês digitar.\n\nVamos lá?");

do
{
  System.Console.WriteLine("Digite um número inteiro: ");
  verificacao = int.TryParse(Console.ReadLine(), out numero);
} while (!verificacao || numero < 0);

numeroDigitado = numero;
while (numero > 0)
{
  digito = numero % 10;
  soma += digito;
  numero = numero / 10;
}

System.Console.WriteLine($" \nA soma dos algarismo do número {numeroDigitado} é {soma}.");
System.Console.WriteLine();