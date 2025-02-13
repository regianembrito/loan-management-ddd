using LoanManagement.Domain.Entities;

namespace LoanManagement.Domain.Services
{
    // Serviços de domínio contêm regras de negócio que não pertencem a uma única entidade.
    public class LoanCalculatorService
    {
        public decimal CalculateMonthlyPayment(Loan loan)
        {
            decimal monthlyRate = loan.InterestRate / 100 / 12;
            int months = loan.TermInMonths;

            return (loan.Amount * monthlyRate) / (1 - (decimal)Math.Pow(1 + (double)monthlyRate, -months));
        }
    }
}
