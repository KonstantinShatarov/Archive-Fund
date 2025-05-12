
using System.Diagnostics;
namespace Архивный_фонд.Services
{
    public class AuthServiceTests
    {
        private readonly IDatabaseAuthService _authService;

        public AuthServiceTests(IDatabaseAuthService authService)
        {
            _authService = authService;
        }

        public void RunAllTests()
        {
            TestValidCredentials();
            TestInvalidCredentials();
        }

        private void TestValidCredentials()
        {
            var result = _authService.TryLogin("test", "1234", out var user);
            Debug.Assert(result && user != null && user.Role == "Admin", "Тест верных данных пройден");
            MessageBox.Show("Тест верных данных: " + result, 
                "Результат теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TestInvalidCredentials()
        {
            var result = _authService.TryLogin("wrong", "wrong", out var user);
            Debug.Assert(!result, "Тест неверных данных пройден");
            MessageBox.Show("Тест неверных данных: " + result, 
                "Результат теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
