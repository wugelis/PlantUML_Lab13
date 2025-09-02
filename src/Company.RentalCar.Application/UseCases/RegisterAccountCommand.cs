using Company.RentalCar.Domain.Entities;

namespace Company.RentalCar.Application.UseCases
{
    public class RegisterAccountCommand
    {
        public Account Account { get; }
        public RegisterAccountCommand(Account account) => Account = account;
    }
}
