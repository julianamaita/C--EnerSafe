using System;
namespace EnerCyberSafe // Define um namespace para organizar o código.
{
    class Program // Classe principal do programa.
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa.
        {
            // Exibe mensagem de boas-vindas.
            Console.WriteLine("Bem-vindo ao EnerCyberSafe - Sistema de Monitoramento de Falhas de Energia");

            Usuario usuario = new Usuario(); // Cria um objeto 'usuario' da classe Usuario.
            bool autenticado = false; // Variável para controle de autenticação.

            // Loop até que o usuário seja autenticado corretamente.
            while (!autenticado)
            {
                Console.Write("Usuário: ");
                string nome = Console.ReadLine(); // Lê o nome do usuário.
                Console.Write("Senha: ");
                string senha = Console.ReadLine(); // Lê a senha.

                autenticado = usuario.Autenticar(nome, senha); // Verifica se o usuário e senha são válidos.
                if (!autenticado)
                    Console.WriteLine("Usuário ou senha inválidos."); // Mensagem de erro.
            }

            Console.WriteLine("Login realizado com sucesso!"); // Mensagem de sucesso.

            bool sair = false; // Controle do loop principal do menu.
            while (!sair)
            {
                // Exibe as opções do menu.
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Registrar Falha");
                Console.WriteLine("2 - Gerar Alerta");
                Console.WriteLine("3 - Visualizar Logs");
                Console.WriteLine("4 - Emitir Relatório");
                Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine(); // Lê a opção escolhida pelo usuário.

                try
                {
                    // Executa a ação conforme a opção selecionada.
                    switch (opcao)
                    {
                        case "1":
                            FalhaEnergia falha = new FalhaEnergia(); // Cria um objeto FalhaEnergia.
                            falha.RegistrarFalha(); // Chama o método para registrar falha.
                            break;
                        case "2":
                            AlertaService.EnviarAlerta(); // Chama o método para enviar um alerta.
                            break;
                        case "3":
                            LogService.ExibirLogs(); // Chama o método para exibir os logs.
                            break;
                        case "4":
                            RelatorioService.EmitirRelatorio(); // Chama o método para emitir um relatório.
                            break;
                        case "5":
                            sair = true; // Encerra o loop e o sistema.
                            break;
                        default:
                            Console.WriteLine("Opção inválida."); // Mensagem para opção incorreta.
                            break;
                    }
                }
                catch (Exception ex) // Captura qualquer exceção que ocorra no processamento.
                {
                    Console.WriteLine($"Erro: {ex.Message}"); // Exibe a mensagem de erro.
                }
            }

            Console.WriteLine("Sistema encerrado."); // Mensagem de finalização.
        }
    }
}


