using LoanManagement.Domain.Entities;
using LoanManagement.Domain.Repositories;

namespace LoanManagement.Application.UseCases
{
    // Os casos de uso implementam fluxos de negócio da aplicação.
    public class RequestLoan
    {
        private readonly ILoanRepository _loanRepository;

        public RequestLoan(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public async Task<Guid> Execute(decimal amount, int termInMonths, decimal interestRate, Guid customerId)
        {
            var loan = new Loan(amount, termInMonths, interestRate, customerId);
            await _loanRepository.AddAsync(loan);
            return loan.Id;
        }
    }
}
