string Perguntar(string mensagem)
{
    Console.Write(mensagem);
    return Console.ReadLine() ?? "";
}

void ExibirMensagem(string nome, string idade)
{
    Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
}

var nome = Perguntar("Digite seu nome: ");
var idade = Perguntar("Digite sua idade: ");
ExibirMensagem(nome, idade);