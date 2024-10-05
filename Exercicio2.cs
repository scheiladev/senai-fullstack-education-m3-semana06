
namespace Aula2.Exercicios
{
  public class Exercicio2
  {
    public decimal Valor { get; set; }
    public bool ClienteVip { get; set; }
    public bool PrimeiraCompra { get; set; }
    public bool CupomDesconto { get; set; }

    public decimal CalcularDesconto()
    {
      if (ClienteVip)
      {
        return PrimeiraCompra ? Valor * 0.20m : Valor * 0.10m;
      }

      if (PrimeiraCompra)
      {
        return Valor * 0.05m;
      }

      if (CupomDesconto)
      {
        return Valor * 0.15m;
      }

      return Valor * 0.02m;
    }
  }
}