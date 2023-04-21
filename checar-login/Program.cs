using System;

class Program
{
    static void Main(string[] args)
    {
        SistemaDeLogin sistemaDeLogin = new SistemaDeLogin();
        sistemaDeLogin.FazerLogin("admin", "oo2023");
    }
}

class SistemaDeLogin
{
    private string? usuario;
    private string? senha;

    public void FazerLogin(string usuario, string senha)
    {
        // se as credenciais forem nulas ou vazias
        if (string.IsNullOrEmpty(usuario))
        {
            throw new ArgumentException("O nome do usuário não pode ser vazio");
        }
        if (string.IsNullOrEmpty(senha))
        {
            throw new ArgumentException("A senha não pode ser vazia");
        }

        bool credenciaisValidas = VerificarCredenciais(usuario, senha);

        if (!credenciaisValidas)
        {
            throw new Exception("Credenciais inválidas");
        }

        // se as credenciais forem válidas, continue com o login
        // caso contrário, a exceção acima será lançada e a ação será interrompida
    }

    private bool VerificarCredenciais(string usuario, string senha)
    {
        // verificar se o nome do usuário é "admin" e a senha é "oo2023"
        if (usuario == "admin" && senha == "oo2023")
        {
            return true;
        }

        return false; // credenciais inválidas
    }
}
