
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
            
            {
                if (acao == "e")
                {
                    Console.WriteLine("qual nome deseja remover: ");
                    acao = Console.ReadLine();
                    for (int i = 0; i < indice; i++)
                        if (acao == nomeCadastro[i])
                    {
                        nomeCadastro[i] = null;
                        Console.WriteLine("Cadastro removido com sucesso!");
                    }
             
                }
                else if (acao == "b")
                    for (int i = 0; i < indice; i++)
                    {
                    Console.WriteLine("qual nome deseja consultar:");
                    string tempNome;
                    tempNome = Console.ReadLine();

                    if (tempNome == nomeCadastro[i])
                    {
                        Console.WriteLine($"nome {nomeCadastro[i]} esta na lista!");
                    }
                    
                    else
                    {
                        Console.WriteLine("nome inexistente!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("opcao invalida");
                }
                break;

            }

        case 4:
            Console.WriteLine("Saindo do programa...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (opcao == 3)
    {
        Console.WriteLine("Digite o nome do item para buscar ou remover:");
        string nomeItem = Console.ReadLine();
        // Lógica para buscar ou remover o item

    }

}


