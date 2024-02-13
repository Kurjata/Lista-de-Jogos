
string mensagemDeBoasVindas = "\nBem vindo ao Terminal interativo de jogos!!! :)";

Dictionary<string, List<int>> jogosRegistrados = new Dictionary<string, List<int>>();
jogosRegistrados.Add("GTA 5", new List<int> { 10, 8, 6 });

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
    Console.WriteLine("Digite 4 para exibir a nota média de um jogo cadastrado");
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
        case 3: AvaliarJogo();
            break;
        case 4: MediaDoJogo();
            break;
        case -1: SairDaAplicacao();
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
    jogosRegistrados.Add(nomeDoJogo, new List<int>());
    Console.WriteLine($"{nomeDoJogo} foi cadastrado com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarJogosRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os jogos já cadastrados:");
    foreach(string jogo in jogosRegistrados.Keys)
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

void AvaliarJogo()
{
    Console.Clear();
    ExibirTituloDaOpcao("Hora de avaliar o jogo");
    Console.Write("Digite o nome do jogo que você deseja atribuir uma nota: ");
    string nomeDoJogo = Console.ReadLine()!;
    Console.WriteLine(nomeDoJogo);
    if (jogosRegistrados.ContainsKey(nomeDoJogo))
    {
        Console.Write($"Digite sua nota para a banda {nomeDoJogo}: ");
        int nota = int.Parse(Console.ReadLine()!);
        jogosRegistrados[nomeDoJogo].Add(nota);
        Console.WriteLine($"\nVocê atribuiu a nota de {nota} para o jogo {nomeDoJogo}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO jogo {nomeDoJogo} não foi registrado!");
        Console.WriteLine("Digite qualquer tecla para cadastrar seu jogo preferido.");
        Console.ReadKey();
        Console.Clear();
        RegistrarJogo();
    }
}

void MediaDoJogo()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir a nota média do jogo");
    Console.Write("Dê a sua nota para um jogo já cadastrado: ");
    string nomeDoJogo = Console.ReadLine();
    if (jogosRegistrados.ContainsKey(nomeDoJogo))
    {
        List<int> notaDoJogo = jogosRegistrados[nomeDoJogo];
        Console.WriteLine($"\nA nota média do jogo {nomeDoJogo} é {notaDoJogo.Average()}.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"O jogo {nomeDoJogo} ainda não foi cadastrado por você.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal e cadastrar seu jogo preferido.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void SairDaAplicacao()
{
    Console.WriteLine("Fechando a aplicação. Tchau Tchau!");
    Thread.Sleep(2000);
    Environment.Exit(0);
}

ExibirOpcoesDoMenu();