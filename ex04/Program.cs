// Ler um vetor com 10 inteiros e descubra o maior e o menor elemento do vetor.

int[] vetorInt = new int[10];
int maiorInt = 0, menorInt = 0;
bool validacao;

for (int i = 0; i < vetorInt.Length; i++)
{
  do
  {
    System.Console.WriteLine($"Digite o número na posição {i+1} do vetor: ");
    validacao = int.TryParse(Console.ReadLine(), out vetorInt[i]);
  } while (!validacao);
  
  if(vetorInt[i] >= maiorInt){
    maiorInt = vetorInt[i];
  }
  if(i == 0){
    menorInt = vetorInt[i];
  }
  else if(vetorInt[i] <= menorInt){
    menorInt = vetorInt[i];
  }
}

System.Console.WriteLine($"O menor valor do vetor é {menorInt} e o maior valor é {maiorInt}.");
System.Console.WriteLine();