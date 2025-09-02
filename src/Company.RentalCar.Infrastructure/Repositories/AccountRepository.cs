using Company.RentalCar.Domain.Entities;
using System.Collections.Generic;

namespace Company.RentalCar.Infrastructure.Repositories
{
    public class AccountRepository
    {
        private readonly List<Account> _accounts = new();
        public void Add(Account account) => _accounts.Add(account);
        public Account? FindByUserID(string userID) => _accounts.Find(a => a.UserID == userID);
    }
}
