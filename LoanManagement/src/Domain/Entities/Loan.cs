namespace LoanManagement.Domain.Entities
{
    // Uma entidade possui identidade única e representa um empréstimo bancário.
    public class Loan
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public int TermInMonths { get; private set; }
        public decimal InterestRate { get; private set; }
        public Guid CustomerId { get; private set; }

        private Loan() { } // Required by EF Core

        public Loan(decimal amount, int termInMonths, decimal interestRate, Guid customerId)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            TermInMonths = termInMonths;
            InterestRate = interestRate;
            CustomerId = customerId;
        }

        public decimal CalculateTotalAmount()
        {
            return Amount + (Amount * (InterestRate / 100) * TermInMonths / 12);
        }
    }
}
