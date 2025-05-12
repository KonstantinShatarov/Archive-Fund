namespace Архивный_фонд.Services
{
    public class FakeAuthService : IDatabaseAuthService
    {
        public bool TryLogin(string login, string password, out UserData user)
        {
            user = null;
            if (login == "test" && password == "1234")
            {
                user = new UserData
                {
                    Status = "Блокировки нет",
                    Role = "Admin",
                    Post = "Developer",
                    Surname = "Иванов",
                    Name = "Иван",
                    Patronymic = "Иванович"
                };
                return true;
            }
            return false;
        }
    }
}
