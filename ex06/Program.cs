/*Faça um programa que calcula as áreas das seguintes figuras geométricas:
- Área do quadrado - base * base
- Área do retângulo - base * altura
- Área do triângulo - base * altura / 2
- Área do trapézio - (baseMaior + baseMenor) * altura / 2
Baseado na escolha do usuário, você deverá pedir os valores necessários para fazer os cálculos (cm) e imprimir o nome da figura escolhida e o valor área para o usuário (cm²)*/

double base_, altura, baseMaior, baseMenor, area;
string resposta;
bool verificacao;

System.Console.WriteLine("Bem vind@ ao programa _Calcule Sua Área!_");

do
{
  System.Console.WriteLine("\nEscolha a letra correspondente a sua figura geométrica: \n\na - quadradro \nb - retângulo \nc - triângulo \nd - trapézio\n");
  resposta = Console.ReadLine().ToLower();
} while (resposta != "a" && resposta != "b" && resposta != "c" && resposta != "d");

System.Console.WriteLine($"Certo, você escolheu a opção {resposta} \n");

if(resposta == "a")
{
  do
  {
    System.Console.WriteLine("Digite o valor da base do quadrado: ");
    verificacao = double.TryParse(Console.ReadLine(), out base_);
  } while (!verificacao);
  
  area = base_ * base_;
}

else if(resposta == "b")
{
  do
  {
    System.Console.WriteLine("Digite o valor da base do retâgulo: ");
    verificacao = double.TryParse(Console.ReadLine(), out base_);
  } while (!verificacao);
  
  do
  {
    System.Console.WriteLine("Digite o valor da altura do retâgulo: ");
    verificacao = double.TryParse(Console.ReadLine(), out altura);
  } while (!verificacao);
  
  area = base_ * altura;
}

else if(resposta == "c")
{
  do
  {
    System.Console.WriteLine("Digite o valor da base do triângulo: ");
    verificacao = double.TryParse(Console.ReadLine(), out base_);
  } while (!verificacao);
  
  do
  {
    System.Console.WriteLine("Digite o valor da altura do triângulo: ");
    verificacao = double.TryParse(Console.ReadLine(), out altura);
  } while (!verificacao);
  
  area = base_ * altura / 2;
}

else{
  do
  {
    System.Console.WriteLine("Digite o valor da base maior do trapézio: ");
    verificacao = double.TryParse(Console.ReadLine(), out baseMaior);
  } while (!verificacao);
  
  do
  {
    System.Console.WriteLine("Digite o valor da base menor do trapézio: ");
    verificacao = double.TryParse(Console.ReadLine(), out baseMenor);
  } while (!verificacao);

  do
  {
    System.Console.WriteLine("Digite o valor da altura do trapézio: ");
    verificacao = double.TryParse(Console.ReadLine(), out altura);
  } while (!verificacao);

  area = (baseMaior + baseMenor) * altura / 2;
}

System.Console.WriteLine($"\nA área total de sua figura geométrica é {area} m².");
