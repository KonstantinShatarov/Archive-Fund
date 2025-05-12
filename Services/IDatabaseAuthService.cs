using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Архивный_фонд.Services
{
    public interface IDatabaseAuthService
    {
        bool TryLogin(string login, string password, out UserData user);
    }

    public class UserData
    {
        public string Status { get; set; }
        public string Role { get; set; }
        public string Post { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
}
