int opcao = 0;
string[] nomeCadastro = new string[10];
int indice = 0;

while (opcao != 4)
{
    Console.WriteLine(" -------------------------------");
    Console.WriteLine("|    Escolha uma opção:         |");
    Console.WriteLine("|    1 - Cadastro;              |");
    Console.WriteLine("|    2 - Listagem e exebição;   |");
    Console.WriteLine("|    3 - Busca e remoção;       |");
    Console.WriteLine("|    4 - Sair.                  |");
    Console.WriteLine(" ------------------------------- ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                Console.Clear();
                Console.Write("Digite o nome do cadastro:");
                nomeCadastro[indice] = Console.ReadLine();
                indice++;
            }
            break;
        case 2:
            Console.Clear();
            for (int i = 0; i < nomeCadastro.Length; i++)
            {
                Console.WriteLine(nomeCadastro[i]);
            }
            break;
        case 3:
            Console.WriteLine("Digite o nome do cadastro para remoção:");
            string nomeRemocao = Console.ReadLine();
            for (int i = 0; i < indice; i++)
            {
                if (nomeCadastro[i] == nomeRemocao)
                {
                    nomeCadastro[i] = null;
                    Console.WriteLine("Cadastro removido com sucesso!");
                    break;
                }
            }
            break;
        case 4:
            Console.WriteLine("Programa encerrado com sucesso.");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}