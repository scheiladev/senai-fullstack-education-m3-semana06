namespace Aula2.Exercicios
{
  public class Exercicio3
  {
    public void ProcessarPedido(int pedidoId, string cliente, string endereco, decimal valor, bool pagamentoConfirmado, bool estoqueDisponivel, bool entregaExpressa)
    {
      if (!pagamentoConfirmado)
      {
        Console.WriteLine($"Pedido {pedidoId} para {cliente} não pode ser processado porque o pagamento não foi confirmado.");
        return;
      }

      if (!estoqueDisponivel)
      {
        Console.WriteLine($"Pedido {pedidoId} para {cliente} não pode ser processado devido à falta de estoque.");
        return;
      }

      var tipoEntrega = entregaExpressa ? "expressa" : "normal";
      Console.WriteLine($"Pedido {pedidoId} para {cliente} será enviado para {endereco} com entrega {tipoEntrega}.");
    }
  }
}