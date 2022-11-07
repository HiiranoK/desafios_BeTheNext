/*
1 - Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
aluno.

2 - Um comerciante comprou um produto e quer vende-lo com um lucro de 45% se o valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. Entrar como valor do produto e imprimir o valor da venda.
*/
public class Program
{
  static void Main(String[] agrs)
  {
    double precoCompra, precoVenda;
    bool validacao;
    do
    {
      System.Console.WriteLine("Digite o valor da compra do produto: ");
      validacao = double.TryParse(Console.ReadLine(), out precoCompra);
    } while (!validacao || precoCompra < 0);

    if (precoCompra < 20){
      precoVenda = precoCompra * 1.45;
      System.Console.WriteLine("O preço do produto foi menor que R$20,00");
    }
    else{
      precoVenda = precoCompra * 1.30;
      System.Console.WriteLine("O preço do produto foi maior ou igual a R$20,00");
    }

    System.Console.WriteLine($"Sendo assim, o valor de venda do produto será de R$ {precoVenda.ToString("F2")}");


    // double[] notas = new double[4];
    // double mediaNotas = 0, somaNotas = 0, notaRecuperacao;
    // bool validacaoNota;
    // for (int i = 0; i < notas.Length; i++)
    // {
    //   do
    //   { 
    //     System.Console.WriteLine($"Digite a nota {i + 1}: ");
    //     validacaoNota = double.TryParse(Console.ReadLine(), out notas[i]);
    //   } while (!validacaoNota); 
    //   somaNotas += notas[i];
    // }
    // mediaNotas = somaNotas / 4;

    // if(mediaNotas < 7)
    // { 
    //   do{
    //     System.Console.WriteLine("Sua média foi menor que 7 e você ficou de recuperação... \nDigite a nota da recuperação: ");
    //   validacaoNota = double.TryParse(Console.ReadLine(), out notaRecuperacao);
    //   }while(!validacaoNota);
           
    //   double mediaFinal = (notaRecuperacao + mediaNotas) / 2;
    //   if (mediaFinal < 7)
    //   {
    //     System.Console.WriteLine($"Você foi reprovado(a).\nSua média final é {mediaFinal.ToString("F2")}");
    //   }
    //   else
    //   {
    //     System.Console.WriteLine($"Você foi aprovado(a)!\nSua média final é {mediaFinal.ToString("F2")}");
    //   }
    // }
    // else{
    //   System.Console.WriteLine($"Você foi aprovado(a) direto, parabéns! \nSua média final é {mediaNotas.ToString("F2")}");
    // }

    System.Console.WriteLine();
  }
}