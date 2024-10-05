namespace Aula3.Exercicios
{
  public class OCP
  {
    //o código da classe abaixo está violando o principio de aberto/fechado. Reescreva aplicando a correção
  }
  public interface IDesconto
  {
    decimal Calcular(decimal valor);
  }

  public class DescontoRegular : IDesconto
  {
    public decimal Calcular(decimal valor)
    {
      return valor * 0.1m;
    }
  }

  public class DescontoPremium : IDesconto
  {
    public decimal Calcular(decimal valor)
    {
      return valor * 0.2m;
    }
  }

  public class DescontoVip : IDesconto
  {
    public decimal Calcular(decimal valor)
    {
      return valor * 0.3m;
    }
  }

  public class CalculadoraDesconto
  {
    public decimal CalcularDesconto(IDesconto desconto, decimal valor)
    {
      return desconto.Calcular(valor);
    }
  }
}