
using System; // Importa funcionalidades básicas, como entrada/saída e manipulação de datas.
using System.Collections.Generic; // Importa a coleção genérica List<T>.

namespace EnerCyberSafe // Namespace para organização do sistema.
{
    public static class LogService // Classe estática para gerenciar o registro de logs.
    {
        // Lista estática para armazenar as mensagens de log.
        private static List<string> Logs = new List<string>();

        // Método público e estático para registrar uma mensagem no log.
        public static void RegistrarLog(string mensagem)
        {
            // Adiciona a mensagem à lista de logs, precedida pelo timestamp atual.
            Logs.Add($"{DateTime.Now}: {mensagem}");
        }

        // Método público e estático para exibir todos os logs registrados.
        public static void ExibirLogs()
        {
            Console.WriteLine("\n--- LOGS DE EVENTOS ---");
            // Itera por todas as mensagens de log e exibe uma por linha.
            foreach (var log in Logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}




