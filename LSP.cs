namespace Aula3.Exercicios
{
  public class LSP
  {
    //o código da classe abaixo está violando o principio de Liskov. Reescreva aplicando a correção
  }
  public interface IForma
  {
    int CalcularArea();
  }

  public class Retangulo : IForma
  {
    public int Largura { get; set; }
    public int Altura { get; set; }

    public int CalcularArea()
    {
      return Largura * Altura;
    }
  }

  public class Quadrado : IForma
  {
    public int Lado { get; set; }

    public int CalcularArea()
    {
      return Lado * Lado;
    }
  }
}