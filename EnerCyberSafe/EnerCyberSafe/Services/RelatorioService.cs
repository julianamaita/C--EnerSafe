using System; // Importa funcionalidades básicas como entrada e saída.

namespace EnerCyberSafe // Namespace para organização do sistema.
{
    // Classe estática responsável pela geração de relatórios.
    public static class RelatorioService
    {
        // Método público e estático que emite um relatório no console.
        public static void EmitirRelatorio()
        {
            Console.WriteLine("\n--- RELATÓRIO DE STATUS ---");

            // Exibe informações fictícias sobre o status do sistema.
            Console.WriteLine("Total de eventos registrados: (número fictício)");
            Console.WriteLine("Última falha registrada: (detalhes fictícios)");
            Console.WriteLine("Sistema funcionando normalmente.");

            // Registra no log que um relatório foi emitido.
            LogService.RegistrarLog("Relatório emitido.");
        }
    }
}
