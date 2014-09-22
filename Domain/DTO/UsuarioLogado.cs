
namespace Domain.DTO
{
    public static class UsuarioLogado
    {
        public static string Login { get; set; }

        public static string Senha { get; set; }

        public static string Perfil { get; set; }

        public static string BancoDeDados { get; set; }

        public static string Holding { get; set; }

        public static string ObterStringDeConexao()
        {
            return string.Format("Data Source={0}; User Id={1}; Password={2};", BancoDeDados, Login, Senha);
        }

        public static string ObterStringDeConexaoODBC()
        {
            return string.Format("ODBD;DSN={0}; UID={1}; PWD={2}; SERVER={3};", BancoDeDados, Login, Senha, BancoDeDados);
        }
    }
}
