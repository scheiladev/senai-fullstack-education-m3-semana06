namespace Aula3.Exercicios
{
  public class SRP
  {
    //o código da classe abaixo está violando o principio de responsabilidade única. Reescreva aplicando a correção
  }

  public class UsuarioService
  {
    public void AdicionarUsuario(string nome)
    {
      Console.WriteLine($"Usuário {nome} adicionado com sucesso.");
    }
  }

  public class EmailService
  {
    public void EnviarEmail(string email)
    {
      Console.WriteLine($"E-mail enviado para {email}.");
    }
  }
}