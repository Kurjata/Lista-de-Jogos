//Game's Terminal

string mensagemDeBoasVindas = "\nBem vindo ao Terminal interativo de jogos!!! :)";
List<string> listaDeJogos = new List<string> { "\nSpider Man" };

void ExibirLogo()
{
    Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▄▀█ █▀▀ █ █▀▀ 　 ▀▀█▀▀ █▀▀ █▀▀█ █▀▄▀█ ░▀░ █▀▀▄ █▀▀█ █░░ 
▒█░▄▄ █▄▄█ █░▀░█ █▀▀ ░ ▀▀█ 　 ░▒█░░ █▀▀ █▄▄▀ █░▀░█ ▀█▀ █░░█ █▄▄█ █░░ 
▒█▄▄█ ▀░░▀ ▀░░░▀ ▀▀▀ ░ ▀▀▀ 　 ░▒█░░ ▀▀▀ ▀░▀▀ ▀░░░▀ ▀▀▀ ▀░░▀ ▀░░▀ ▀▀▀");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um jogo");
    Console.WriteLine("Digite 2 para mostrar todos os jogos registrados");
    Console.WriteLine("Digite 3 para avaliar um jogo");
    Console.WriteLine("Digite 4 para exibir a avaliação de média do jogo");
    Console.WriteLine("Digite -1 para sair desse programa");

    Console.Write("\nDigite sua opção aqui: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarJogo();
            break;
        case 2: MostrarJogosRegistrados();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Saindo da aplicação");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarJogo()
{

    
    Console.Clear();
    ExibirTituloDaOpcao("Registro de jogos");
    Console.Write("\nDigite aqui o nome do jogo que você deseja registrar: ");
    string nomeDoJogo = Console.ReadLine()!;
    listaDeJogos.Add(nomeDoJogo);
    Console.WriteLine($"{nomeDoJogo} foi cadastrado com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarJogosRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os jogos já cadastrados:");
    foreach(string jogo in listaDeJogos)
    {
        Console.WriteLine($"\n{jogo}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal da aplicação.");
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


ExibirOpcoesDoMenu();