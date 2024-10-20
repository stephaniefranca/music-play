// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Play Music França";
//List<string> listaDasBandas = new List<string> { "Ludmila", "Thiaguinho", "Turma do pagode"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Turma da pagote", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Exaltasamba", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
██████╗░██╗░░░░░░█████╗░██╗░░░██╗  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗╚██╗░██╔╝  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██████╔╝██║░░░░░███████║░╚████╔╝░  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔═══╝░██║░░░░░██╔══██║░░╚██╔╝░░  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░███████╗██║░░██║░░░██║░░░  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Até em breve :) ");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {listaDasBandas[i]}");    
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();


    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

ExibirOpcoesDoMenu();

