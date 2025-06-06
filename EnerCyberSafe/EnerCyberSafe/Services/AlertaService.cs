using System; // Importa funcionalidades básicas, como entrada/saída e exceções.

namespace EnerCyberSafe // Namespace para organização do sistema.
{
    public static class AlertaService // Classe estática para fornecer serviços de alerta.
    {
        public static void EnviarAlerta() // Método estático para enviar um alerta.
        {
            // Solicita ao usuário a mensagem do alerta.
            Console.Write("Digite a mensagem do alerta: ");
            string mensagem = Console.ReadLine();

            // Validação: verifica se a mensagem não é nula, vazia ou composta apenas por espaços.
            if (string.IsNullOrWhiteSpace(mensagem))
                throw new Exception("Mensagem inválida.");

            // Exibe a confirmação de envio do alerta.
            Console.WriteLine($"Alerta enviado: {mensagem}");

            // Registra o envio do alerta no log.
            LogService.RegistrarLog($"Alerta enviado: {mensagem}");
        }
    }
}





