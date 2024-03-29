﻿// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Sound Screen";
//cria lista vazia
List<string> bandas = new List<string>();    

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigita uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistraBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você digitou a opção 3");
            break;
        case 4: Console.WriteLine("Você digitou a opção 4");
            break;
        case -1: Console.WriteLine("Até mais! :)");
            break;
        //se inserir qualquer valor que não seja numérico ocorrerá um erro!
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}


void RegistraBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com suceso!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu(); 

}

void MostrarBandasRegistradas()
{
    //for (int i = 0; i < bandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda:{bandas[i]}");
    //}

    //Para cada banda na lista de bandas
    foreach(string banda in bandas)
    {
        Console.WriteLine($"Banda: {banda}"
            
            );
    }

    Console.WriteLine("Digite uma tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

