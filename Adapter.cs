public interface IPaymentProcessor
{
  void ProcessPayment(decimal amount);
}

public class OldPaymentProcessor
{
  public void MakePayment(decimal amount)
  {
    Console.WriteLine($"Pagamento de {amount} foi processado (antigo processo de pagamento).");
  }
}

public class NewPaymentProcessor
{
  public void ExecutePayment(decimal amount)
  {
    Console.WriteLine($"Pagamento de {amount} foi processado (novo processo de pagamento).");
  }
}

public class OldPaymentProcessorAdapter : IPaymentProcessor
{
  private readonly OldPaymentProcessor _oldProcessor;

  public OldPaymentProcessorAdapter(OldPaymentProcessor oldProcessor)
  {
    _oldProcessor = oldProcessor;
  }

  public void ProcessPayment(decimal amount)
  {
    _oldProcessor.MakePayment(amount);
  }
}

public class NewPaymentProcessorAdapter : IPaymentProcessor
{
  private readonly NewPaymentProcessor _newProcessor;

  public NewPaymentProcessorAdapter(NewPaymentProcessor newProcessor)
  {
    _newProcessor = newProcessor;
  }

  public void ProcessPayment(decimal amount)
  {
    _newProcessor.ExecutePayment(amount);
  }
}