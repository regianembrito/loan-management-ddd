namespace LoanManagement.Application.Dtos
{
    // Usamos record em vez de class porque DTOs geralmente são imutáveis e usados apenas para transporte de dados.
    public record RequestLoanDto(decimal Amount, int TermInMonths, decimal InterestRate, Guid CustomerId)
    {
    }
}
