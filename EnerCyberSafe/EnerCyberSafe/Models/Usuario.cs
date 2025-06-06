
namespace EnerCyberSafe // Define o namespace para organizar as classes do sistema.
{
    public class Usuario // Classe pública 'Usuario' que representa o usuário do sistema.
    {
        private string Nome { get; set; } // Propriedade privada 'Nome', somente acessível dentro da classe.
        private string Senha { get; set; } // Propriedade privada 'Senha', somente acessível dentro da classe.

        public Usuario()
        {
            // Construtor da classe: define valores padrão para 'Nome' e 'Senha'.
            Nome = "admin";  // Usuário padrão.
            Senha = "123";   // Senha padrão.
        }

        public bool Autenticar(string nome, string senha)
        {
            // Método público que verifica se os parâmetros 'nome' e 'senha' 
            // correspondem aos valores armazenados nas propriedades.
            return nome == Nome && senha == Senha;
        }
    }
}














