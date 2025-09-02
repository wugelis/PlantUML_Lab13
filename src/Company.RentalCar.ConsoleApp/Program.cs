using System;
using Company.RentalCar.Domain.Entities;
using Company.RentalCar.Application.UseCases;
using Company.RentalCar.Infrastructure.Repositories;

namespace Company.RentalCar.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountRepo = new AccountRepository();
            var carRepo = new CarRepository();
            // 註冊帳號
            var account = new Account { UserID = "user1", Password = "pass", Name = "王小明" };
            accountRepo.Add(account);
            Console.WriteLine($"註冊帳號: {account.UserID}");

            // 登入
            var loginCmd = new LoginCommand("user1", "pass");
            var loginAccount = accountRepo.FindByUserID(loginCmd.UserID);
            if (loginAccount != null && loginAccount.Password == loginCmd.Password)
            {
                Console.WriteLine($"登入成功: {loginAccount.UserID}");
            }
            else
            {
                Console.WriteLine("登入失敗");
                return;
            }

            // 新增車輛
            var car = new Car { CarType = "SUV", CarInfo = "Toyota RAV4" };
            carRepo.Add(car);
            Console.WriteLine($"可租用車輛: {car.CarInfo}");

            // 租車流程
            var user = new User { UserID = loginAccount.UserID, Account = loginAccount };
            var rentalUseCase = new RentalCarUseCase();
            rentalUseCase.ToRentalCar(user, car, DateTime.Today, DateTime.Today.AddDays(3));
            Console.WriteLine($"{user.UserID} 成功預約 {car.CarInfo} 3 天");
        }
    }
}
