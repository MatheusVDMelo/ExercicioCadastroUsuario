
using System.ComponentModel.Design;
using System.Numerics;
int opcao = 0;
string[] nomeCadastro = new string[10];
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
                nomeCadastro[indice] = Console.ReadLine();
                indice++;
            }
            break;
        case 2:
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(nomeCadastro[i]);
            }
            break;

        case 3:
            Console.WriteLine("`b` para buscar");
            Console.WriteLine("`e` para excluir");
            string acao = Console.ReadLine();


            if (acao == "e")
            {
                Console.WriteLine("Qual nome deseja remover?");
                string nomeRemover = Console.ReadLine();
                bool removido = false;
                for (int i = 0; i < indice; i++)
                {
                    if (nomeCadastro[i] == nomeRemover)
                    {
                        // Desloca os elementos para não deixar null
                        for (int j = i; j < indice - 1; j++)
                            nomeCadastro[j] = nomeCadastro[j + 1];
                        nomeCadastro[indice - 1] = null;
                        indice--;
                        removido = true;
                        Console.WriteLine("Cadastro removido com sucesso!");
                        break;
                    }
                }
                if (!removido)
                    Console.WriteLine("Nome não encontrado.");
            }
            else if (acao == "b")
            {
                Console.WriteLine("Qual nome deseja consultar?");
                string nomeBuscar = Console.ReadLine();
                bool encontrado = false;
                for (int i = 0; i < indice; i++)
                {
                    if (nomeCadastro[i] == nomeBuscar)
                    {
                        Console.WriteLine($"Nome {nomeCadastro[i]} está na lista!");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                    Console.WriteLine("Nome inexistente!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
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


