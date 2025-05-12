using MySql.Data.MySqlClient;
using Архивный_фонд.Services;

namespace Архивный_фонд
{
    public class DatabaseAuthService : IDatabaseAuthService
    {
        private readonly string _connectionString;

        public DatabaseAuthService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool TryLogin(string login, string password, out UserData user)
        {
            user = null;
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    var sql = "SELECT Status, Rol, Post, Surname, Name, Patronymic, Password FROM user WHERE Login = @login";
                    using var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    using var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        var hashedPassword = reader["Password"].ToString();
                        if (BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword))
                        {
                            if (reader["Status"].ToString() != "Блокировки нет")
                                return false;

                            user = new UserData
                            {
                                Status = reader["Status"].ToString(),
                                Role = reader["Rol"].ToString(),
                                Post = reader["Post"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Name = reader["Name"].ToString(),
                                Patronymic = reader["Patronymic"].ToString()
                            };
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
