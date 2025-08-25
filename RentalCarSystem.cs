using System;
using System.Collections.Generic;

namespace RentalCarSystemLab
{
    public class Account
    {
        public bool RegisterAccount(UserInfo userInfo)
        {
            // 註冊帳號邏輯
            return true;
        }

        public bool Login(string userID, string password)
        {
            // 登入邏輯
            return true;
        }
    }

    public class RentalCarSystem
    {
        private List<Car> cars = new List<Car>();
        public void ToRentalCar(string userID)
        {
            // 租用車輛流程
        }

        public void SelectRentalPeriod(DateTime startDate, DateTime endDate)
        {
            // 選擇租用時間區間
        }

        public decimal CalculateRentalFee(Car carInfo, TimeSpan period)
        {
            // 計算租金邏輯
            return 0m;
        }

        public void ConfirmRental()
        {
            // 確認租用
        }
    }

    public class Car
    {
        public string CarType { get; set; }
        public string CarInfo { get; set; }

        public void SelectCar(string carType)
        {
            // 選擇車型邏輯
            CarType = carType;
        }
    }

    public class User
    {
        public string UserID { get; set; }
        public Account Account { get; set; }
    }

    public class UserInfo
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        // 其他用戶資料欄位
    }
}
