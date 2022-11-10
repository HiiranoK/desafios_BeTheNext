using LetsCode;

class Richard
{
    static void Main(string[] args)
    {
        //Chame aqui o método que deseja executar. ConverteUnicode é usado no método SomaUnidadesDetroDoNumero

    }
    static void ListaFatorial()
    {
        Console.WriteLine("Informe o total de elementos da lista!");
        int.TryParse(Console.ReadLine(), out int lista);
        int[] valores = new int[lista];

        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º item da lista!");
            int.TryParse(Console.ReadLine(), out valores[i]);
        }
        for (int i = 0; i < valores.Length; i++)
        {
            int valor = 1;
            for (int j = valores[i]; j > 0; j--)
            {
                valor *= j;
            }
            Console.WriteLine($"o fatorial de {valores[i]}, é:{valor}");
        }
    }
    static void FatorialSimples()
    {
        Console.WriteLine("insira o nº que deseja saber o fatorial");
        int input = int.Parse(Console.ReadLine());
        int valor = 1;
        for (int i = 1; i <= input; i++)
        {
            valor *= i;
            Console.WriteLine(valor);
        }
        Console.WriteLine($"o fatorial de {input}, é:{valor}");
    }
    static void QuestaoDesempate()
    {
        do
        {
            double valor = 0;
            string estado;
            bool valida;
            string input;
            do
            {
                Console.WriteLine("\nInforme o valor do produto! ou sair para encerrar o programa!");
                input = Console.ReadLine().ToLower();
                if (input == "sair")
                {
                    break;
                }
                valida = double.TryParse(input, out valor);
            } while (!valida);
            if (input == "sair")
            {
                break;
            }
            Console.WriteLine("Fornecemos para os seguintes estados:");
            Console.WriteLine("MG | SP | RJ | MS | ES | SC");
            Console.WriteLine("Informe a sigla de um estado válido.");
            estado = Console.ReadLine();
            switch (estado.ToUpper())
            {
                case "MG":
                    valor *= 1.07;
                    break;
                case "SP":
                    valor *= 1.12;
                    break;
                case "RJ":
                    valor *= 1.15;
                    break;
                case "MS":
                    valor *= 1.08;
                    break;
                case "ES":
                    valor *= 1.12;
                    break;
                case "SC":
                    valor *= 1.18;
                    break;
                default:
                    Console.WriteLine("estado inválido, aperte uma tecla para reiniciar o processo!");
                    Console.ReadKey();
                    continue;
            }
            Console.WriteLine($"O valor final do produto ficou: {Math.Round(valor, 2)}");

        } while (true);
    }
    static void QuestaoDoze()
    {
        Random rnd = new Random();
        int[] valores = new int[2];
        int resposta;
        int validaSaida = 0;
        string totalAcertos = "Você acertou as seguintes perguntas: ";
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < valores.Length; j++)
            {
                valores[j] = rnd.Next(1, 101);
            }
            Console.WriteLine($"Informe a soma de {valores[0]} e {valores[1]}");
            int.TryParse(Console.ReadLine(), out resposta);

            if (resposta == valores[0] + valores[1])
            {
                totalAcertos += $"{1 + i}ª  ";
                validaSaida++;
            }
            Console.WriteLine($"A soma de {valores[0]} com {valores[1]} é: {valores[0] + valores[1]}");
        }
        if (validaSaida == 0)
        {
            Console.WriteLine("Infelizmente você não conseguiu acertar nenhuma, continue praticando!");
        }
        else
        {
            Console.WriteLine(totalAcertos);
        }
    }
    static void Fibonacci()
    {
        long a = 0;
        long b = 0;
        long input = int.Parse(Console.ReadLine());
        long fib = 1;
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(fib);
            a = b;
            b = fib;
            fib = a + b;
        }
    }
    static void QuestaoOnze()
    {
        string[] nomes = new string[18];
        int[] idades = new int[18];
        string[] carteiras = new string[18];
        int totalMotoristas = 0;
        int[] motoristas = new int[2];
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($"Informe o nome do {i + 1}º passageiro!");
            nomes[i] = Console.ReadLine();
            Console.WriteLine($"Informe a idade {i + 1} do 1º passageiro!");
            int.TryParse(Console.ReadLine(), out idades[i]);
            if (idades[i] < 18)
            {
                continue;
            }
            Console.WriteLine("Informe se possui carteira de motorista usando [s] ou [n]");
            carteiras[i] = Console.ReadLine();
            if (carteiras[i].ToLower() == "s")
            {
                motoristas[totalMotoristas] = i;
                totalMotoristas++;
            }
            if (totalMotoristas == 2)
            {
                Console.WriteLine($"Os motoristas da rodada são: {nomes[motoristas[0]]} e {nomes[motoristas[1]]}");
                break;
            }
        }
        if (totalMotoristas < 2)
        {
            Console.WriteLine("viagem não será realizada devido falta de motoristas.");
        }
    }
    static void Eleicao()
    {
        uint voto = 1;
        int votosJose = 0, votosJoao = 0, votosFrancisco = 0, votosMaria = 0;
        int votosBranco = 0, votosNulo = 0;
        bool validaVoto;
        while (voto != 0)
        {
            do
            {
                Console.WriteLine("Informe seu voto!:\n1-Jose\n2-João\n3- Francisco\n4-Maria\n5-Nulo\n6-Branco");

                validaVoto = uint.TryParse(Console.ReadLine(), out voto);
            } while (!validaVoto);

            switch (voto)
            {
                case 0:
                    break;
                case 1:
                    votosJose++;
                    break;
                case 2:
                    votosJoao++;
                    break;
                case 3:
                    votosFrancisco++;
                    break;
                case 4:
                    votosMaria++;
                    break;
                case 6:
                    votosBranco++;
                    break;
                case 5:
                default:
                    votosNulo++;
                    break;
            }
        }
        Console.WriteLine($"votos para o José: {votosJose}\nvotos para o João: {votosJoao}\nvotos para o Francisco: {votosFrancisco}\n" +
        $"votos para o maria: {votosMaria}\nvotos em Branco: {votosBranco}\n votos Nulo: {votosNulo}\n");
        double totalVotos = votosNulo + votosBranco + votosJose + votosJoao + votosMaria + votosFrancisco;
        double totalNulos = votosNulo * 100 / totalVotos;
        double totalBranco = votosBranco * 100 / totalVotos;
        Console.WriteLine($"O total de votos nulos é: {Math.Round(totalNulos, 2)}%");
        Console.WriteLine($"O total de votos bracos é: {totalBranco.ToString("0.00")}%");
    }
    static void SomaUnidadesDetroDoNumero()
    {
        string literal;
        bool validaValor;

        Console.WriteLine("informe um numero inteiro maior que 0");
        literal = Console.ReadLine();
        int soma = 0;
        validaValor = int.TryParse(literal, out int num);
        char[] listaCaracteres = new char[literal.Length];
        if (validaValor && num > 0)
        {

            foreach (char letra in literal)
            {
                soma += converteUnicode(letra);
            }
            Console.WriteLine(soma);
        }
        else
        {
            Console.WriteLine("O valor digitado é inválido!");

        }
    }
    static int converteUnicode(int valor)
    {
        switch (valor)
        {
            case 48:
                valor = 0;
                return valor;
            case 49:
                valor = 1;
                return valor;
            case 50:
                valor = 2;
                return valor;
            case 51:
                valor = 3;
                return valor;
            case 52:
                valor = 4;
                return valor;
            case 53:
                valor = 5;
                return valor;
            case 54:
                valor = 6;
                return valor;
            case 55:
                valor = 7;
                return valor;
            case 56:
                valor = 8;
                return valor;
            case 57:
                valor = 9;
                return valor;
            default:
                return 0;
                break;
        }
    }

    static void IngressoDanceteria()
    {
        string diaDaSemana;
        string aoVivo;
        string loop;
        do
        {

            double ingresso = 25.00;
            double musica = 0, dia = 0;
            Console.WriteLine("Informe que dia da semana é hoje(sem acentos)");
            diaDaSemana = Console.ReadLine();
            Console.WriteLine("Informe se tem musica ao vivo hj, responda com (s) ou (n)");
            aoVivo = Console.ReadLine();

            if (diaDaSemana == "segunda" || diaDaSemana == "terca" || diaDaSemana == "quinta")
            {
                dia = ingresso * 0.25;
            }
            if (aoVivo == "s")
            {
                musica = ingresso * 0.15;
            }
            ingresso = ingresso + musica - dia;
            Console.WriteLine($"O valor da entrada é:{ingresso} ");
            Console.WriteLine("Deseja sair do laço? se sim responda s");
            loop = Console.ReadLine();
        } while (loop.ToLower() != "s");
    }

    static void MediaIdades()
    {
        int idade = 0, soma = 0, quantidade = 0;
        decimal media;
        while (idade != -1)
        {
            Console.WriteLine("Informe a idade, ou -1 pra sair");
            int.TryParse(Console.ReadLine(), out idade);
            if (idade >= 18)
            {
                soma += idade;
                quantidade++;
            }
        }
        media = soma / quantidade;
        Console.WriteLine($"A média das idades é: {media}");
    }

    static void Impares()
    {
        bool validaNum;
        int valor;
        do
        {
            Console.WriteLine("Informe um valor entre 1 e 9");
            validaNum = int.TryParse(Console.ReadLine(), out valor);
            if (!validaNum || valor > 9 || valor < 1)
            {
                Console.WriteLine("valor inválido, tente novamente.\n\n");
            }
        } while (!validaNum || valor > 9 || valor < 1);

        for (; valor < 20; valor++)
        {
            if (valor % 2 == 1)
            {
                Console.WriteLine(Math.Pow(valor, 2));
            }
        }
    }

    static void Tabuada()
    {
        string loop;
        bool validaValor;
        int valor;
        do
        {
            Console.WriteLine("informe o numero que deseja receber a tabuada, ou n para sair");
            loop = Console.ReadLine();
            validaValor = int.TryParse(loop, out valor);
            if (validaValor)
            {
                Console.WriteLine($"A tabuada de {valor} é: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{valor} x {i} = {valor * i}");
                }

            }
            else if (loop.ToLower() != "n")
            {
                Console.WriteLine("Valor inválido tente novamente.");
            }
        } while (loop.ToLower() != "n");
    }

    static void Distributiva()
    {
        Console.WriteLine("Informe o valor A:");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor: B");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor: C");
        int C = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor: D");
        int D = int.Parse(Console.ReadLine());

        Console.WriteLine($"A + B: {A + B}, A + C: {A + C}");
        Console.WriteLine($"A + D: {A + D}, B + C: {B + C}");
        Console.WriteLine($"B + D {B + D}, C + D: {C + D}");
        Console.WriteLine($"A * B: {A * B}, A * C: {A * C}");
        Console.WriteLine($"A * D: {A * D}, B * C: {B * C}");
        Console.WriteLine($"B * D {B * D}, C * D: {C * D}");
    }

    static void ContagemRegressiva()
    {
        for (int i = 100; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void ShuffleAlg()
    {
        int[] lista = new int[50];
        int i = 0;

        for (i = 100; i > 0; i--)
        {
            lista[i] = i;
        }

        for (i = 0; i < lista.Length; i++)
        {
            for (int j = i + 1; j < lista.Length; j++)
            {
                if (lista[i] > lista[j])
                {
                    int x = lista[i];
                    lista[i] = lista[j];
                    lista[j] = x;
                };
            }
        }

        List<int> lista2 = new List<int>();
        i = 0;
           
        for (int j = (lista.Length - 1); i < lista.Length / 2; i++, j--)
        {
            lista2.Add(lista[j]);
            lista2.Add(lista[i]);
        }
 
        if (lista.Length % 2 == 1)
        {
            lista2.Add(lista[i]);
        }

        for (i = 0; i < lista.Length; i++)
        {
            Console.WriteLine(lista2[i]);
        }
    }

    static void ComparaValor()
    {
        Console.WriteLine("digite um numero");
        int.TryParse(Console.ReadLine(), out int num);

        if (num > 10)
        {
            Console.WriteLine("Numero maior");
        }
        else
        {
            Console.WriteLine("numero menor ou igual");
        }
    }

    static void CalculaLucro()
    {
        Console.WriteLine("Informe o valor pago no produto!");
        double.TryParse(Console.ReadLine(), out var produto);
        double valorVenda=0;
        if (produto >= 0)
        {
            Console.WriteLine("valor inválido, execute novamente.");
        }
        else if (produto < 20)
        {
            valorVenda = produto * 1.45;
        }
        else
        {
            valorVenda = produto * 1.30;
        }

        Console.WriteLine($"O produto que custou {produto}R$, pode ser vendido a {valorVenda}R$");
    }

    static void AvaliacaoEscolar()
    {
        decimal media = 0;
        decimal nota;
        bool validaNota;

        for (int i = 0; i < 4; i++)
        {
            do
            {
                Console.WriteLine($"Informe a {i + 1}ª nota do aluno");
                validaNota = decimal.TryParse(Console.ReadLine(), out nota);
            } while (!validaNota || nota > 10 || nota < 0);

            media += nota;
        }
        media = media / 4;
        if (media >= 7)
        {
            Console.WriteLine($"Aprovado! sua média é {media}");
        }
        else if (media >= 4)
        {
            decimal notaRecuperacao = 0;
            Console.WriteLine("Informe a nota da recuperação");
            decimal.TryParse(Console.ReadLine(), out notaRecuperacao);
            media += notaRecuperacao;
            media = media / 2;
            if (media >= 7)
            {
                Console.WriteLine($"Aprovado! sua média é {media}");
            }
            else
            {
                Console.WriteLine($"Não foi dessa vez! sua média é {media}");
            }
        }
        else
        {
            Console.WriteLine("Sua nota não é suficiente para participar da recuperação");
            Console.WriteLine($"Não foi dessa vez! sua média é {media}");
        }
    }

    static void CalculaQuadrado()
    {
        double[] valores = new double[10];
        double soma = 0;
        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine($"Informe o valor da posição {i + 1}");
            double.TryParse(Console.ReadLine(), out double valor);
            valores[i] = valor;
            soma += Math.Pow(valores[i], 2);
        }
        Console.WriteLine(soma);
    }

    static void EncontraMenorMaior()
    {
        bool validaNum;
        double[] valor = new double[10];
        for (int i = 0; i < valor.Length; i++)
        {
            do
            {
                Console.WriteLine($"Informe o valor da {1 + i}ª variável");
                validaNum = double.TryParse(Console.ReadLine(), out valor[i]);
                if (!validaNum)
                {
                    Console.WriteLine("Digite um numero.");
                }
            } while (!validaNum);
        }
        double maiorValor = valor[0], menorValor = valor[0];
        for (int i = 1; i < valor.Length; i++)
        {
            if (maiorValor < valor[i])
            {
                maiorValor = valor[i];
            }
            if (menorValor > valor[i])
            {
                menorValor = valor[i];
            }
        }
        Console.WriteLine($"menor valor: {menorValor}");
        Console.WriteLine($"maior valor: {maiorValor}");
    }

    static void ComparaValores() {

        Console.WriteLine("Informe o 1º valor");
        int.TryParse(Console.ReadLine(), out int valorA);
        Console.WriteLine("Informe o 2º valor");
        int.TryParse(Console.ReadLine(), out int valorB);

        Console.WriteLine("Selecione entre as opções, ou qualquer outro valor para sair:" +
            "\n1 – Verificar se um dos números lidos é ou não múltiplo do outro" +
            "\n2 – Verificar se os dois números lidos são pares" +
            "\n3 – Verificar se a média dos dois números é maior ou igual a 7.");

        int.TryParse(Console.ReadLine(), out int input);
        switch (input)
        {
            case 0:
            default:
                break;
            case 1:

                if (valorA == 0 || valorB == 0)
                {
                    Console.WriteLine("Operação cancelada devido a valor inválido (0)");
                }
                else if (valorA % valorB == 0)
                {
                    Console.WriteLine($"{valorA} é multiplo de {valorB}");
                }
                else if (valorB % valorA == 0)
                {
                    Console.WriteLine($"{valorB} é multiplo de {valorA}");
                }
                else
                {
                    Console.WriteLine("Os numeros informados não são multiplos um do outro");
                }
                break;
            case 2:
                if (valorA % 2 == 0)
                {
                    Console.WriteLine($"o 1º valor é par");
                }
                else
                {
                    Console.WriteLine($"o 1º valor é impar");
                }
                if (valorB % 2 == 0)
                {
                    Console.WriteLine($"o 2º valor é par");
                }
                else
                {
                    Console.WriteLine($"o 2º valor é impar");
                }
                break;
            case 3:
                double media = (valorA + valorB / 2);
                if (media > 7)
                {
                    Console.WriteLine("A média dos valores é maior que 7");
                }
                else if (media == 7)
                {
                    Console.WriteLine("A média dos valores é igual a 7");
                }
                else
                {
                    Console.WriteLine("A média dos valores é menor que 7");
                }
                break;
        }
    }
}
