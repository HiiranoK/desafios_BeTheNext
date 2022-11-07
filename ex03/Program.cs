//Faça um programa que leia um número e mostre a tabuada de multiplicação dele

int numero;
int[] nTabuada = new int[10];
bool verificacao;

System.Console.WriteLine("\n\nBem-vin@ a tabuada online \nÉ só escolher o número que mostraremos suas multiplicações de 01 a 10! \n\nVamos lá?");

do
{
  do
  {
    System.Console.WriteLine("Digite o número: ");
    verificacao = int.TryParse(Console.ReadLine(), out numero);
  } while (!verificacao || numero < 0);

  System.Console.WriteLine($"\nOk, você digitou o número {numero}. \n\nEstamos imprimindo a tabuada... \n\n1\n2\n3...\n\nProtinho!\n");
  for (int i = 1; i <= nTabuada.Length; i++)
  {
    System.Console.WriteLine($"{i} x {numero} = {i * numero}");
  }

  System.Console.WriteLine("\n\nSe desejar uma nova tabuada digite o novo número. \n\nSe quiser sair, digite [0].\n\n");
} while (numero !=0);


System.Console.WriteLine("\n...\n\nObrigada por jogar, volte sempre!");
System.Console.WriteLine();