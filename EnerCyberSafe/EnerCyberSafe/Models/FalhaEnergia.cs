using System;

namespace EnerCyberSafe // Namespace para organizar a estrutura do sistema.
{
    public class FalhaEnergia // Classe pública que representa uma falha de energia.
    {
        public DateTime DataHora { get; set; } // Propriedade para armazenar a data e hora da falha.
        public string Local { get; set; }      // Propriedade para armazenar o local da falha.
        public string Causa { get; set; }      // Propriedade para armazenar a causa da falha.

        public void RegistrarFalha() // Método para registrar uma falha de energia.
        {
            try
            {
                // Solicita o local da falha ao usuário.
                Console.Write("Local da falha: ");
                Local = Console.ReadLine();
                // Validação: não permite local vazio ou apenas espaços.
                if (string.IsNullOrWhiteSpace(Local))
                    throw new Exception("Local inválido.");

                // Solicita a causa da falha.
                Console.Write("Causa da falha: ");
                Causa = Console.ReadLine();
                // Validação: não permite causa vazia ou apenas espaços.
                if (string.IsNullOrWhiteSpace(Causa))
                    throw new Exception("Causa inválida.");

                // Registra a data e hora atuais.
                DataHora = DateTime.Now;

                // Confirmação ao usuário.
                Console.WriteLine($"Falha registrada: {DataHora} - {Local} - {Causa}");

                // Registra o log utilizando um serviço externo.
                LogService.RegistrarLog($"Falha registrada em {Local} com causa: {Causa}");
            }
            catch (Exception ex)
            {
                // Captura e exibe qualquer erro ocorrido no processo.
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
            }
        }
    }
}
