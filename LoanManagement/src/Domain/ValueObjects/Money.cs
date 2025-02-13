namespace LoanManagement.Domain.ValueObjects
{
    // Objetos de valor não possuem identidade e são imutáveis.
    public class Money
    {
        public decimal Amount { get; }
        public decimal Currency { get; }

        public Money(decimal amount, decimal currency)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative");
            Amount = amount;
            Currency = currency;
        }
    }
}
