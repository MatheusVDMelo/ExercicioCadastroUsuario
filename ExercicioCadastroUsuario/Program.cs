string[] nomescadastro = new string[1];
int opcao = 0;
int indice = 0;

while (opcao != 4)
{
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1 - Cadastro");
    Console.WriteLine("2 - Listagem e exebição");
    Console.WriteLine("3 - Busca e remoção");
    Console.WriteLine("4 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            { 
                Console.WriteLine("Digite o nome do cadastro");
                nomescadastro[indice] = Console.ReadLine();
                indice++;
            }
            break;
        case 2:
            for (int i = 0; i < nomescadastro.Length; i++)
            {
                Console.WriteLine(nomescadastro[i]);
            }
            break;
        case 3:
            Console.WriteLine("Digite o nome do cadastro para remoção");
            string nomeRemocao = Console.ReadLine();
            for (int i = 0; i < nomescadastro.Length; i++)
            {
                if (nomescadastro[i] == nomeRemocao)
                {
                    nomescadastro[i] = null;
                    Console.WriteLine("Cadastro removido com sucesso!");
                    break;
                }
            }
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}