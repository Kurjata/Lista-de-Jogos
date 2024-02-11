//Game's Terminal

string mensagemDeBoasVindas = "\nBem vindo ao Terminal interativo de jogos!!! :)";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▄▀█ █▀▀ █ █▀▀ 　 ▀▀█▀▀ █▀▀ █▀▀█ █▀▄▀█ ░▀░ █▀▀▄ █▀▀█ █░░ 
▒█░▄▄ █▄▄█ █░▀░█ █▀▀ ░ ▀▀█ 　 ░▒█░░ █▀▀ █▄▄▀ █░▀░█ ▀█▀ █░░█ █▄▄█ █░░ 
▒█▄▄█ ▀░░▀ ▀░░░▀ ▀▀▀ ░ ▀▀▀ 　 ░▒█░░ ▀▀▀ ▀░▀▀ ▀░░░▀ ▀▀▀ ▀░░▀ ▀░░▀ ▀▀▀");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
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
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
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

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();