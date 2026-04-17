int opcao = 0;
string[] nomeCadastro = new string[10];
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Buscar ou remover");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("cadastrar nome de usuario: ");
            for (int i = 0; i < nomeCadastro.Length; i++)
                nomeCadastro[i] = Console.Readline();
            break;
        
        case 2:
            Console.WriteLine("Listar selecionado.");
            // Lógica para listar
            break;
        
        case 3:
            Console.WriteLine("Buscar e remoção selecionada");
            break;
        
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} 