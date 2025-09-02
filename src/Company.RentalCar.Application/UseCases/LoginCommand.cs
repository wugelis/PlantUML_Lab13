namespace Company.RentalCar.Application.UseCases
{
    public class LoginCommand
    {
        public string UserID { get; }
        public string Password { get; }
        public LoginCommand(string userID, string password) => (UserID, Password) = (userID, password);
    }
}
