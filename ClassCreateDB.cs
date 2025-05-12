using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Архивный_фонд
{
    internal class ClassCreateDB
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        String line;
        string myConnString = "";
        string sql;
        string pass = "admin";   

        public void CreateDatabaseIfNotExists()
        {
            StreamReader Fileini = new StreamReader("config.ini");
            int lineCount = 0;
            while ((line = Fileini.ReadLine()) != null && lineCount < 3)
            {
                myConnString += line + ";";
                lineCount++;
            }
            Fileini.Close();
            conn = new MySqlConnection(myConnString);
            try
            {
                conn.Open();
                sql = " CREATE DATABASE IF NOT EXISTS Archive_fund;" + "USE Archive_fund;" +
                "CREATE TABLE IF NOT EXISTS  Destruction_of_documents ( " +
                    "id_AKT_ynicht int  AUTO_INCREMENT PRIMARY KEY NOT NULL, " +
                    "Prichina_Unich varchar(50) NOT NULL," +
                    "Date_unich varchar(11) NOT NULL, " +
                    "FIO varchar(255) NOT NULL, " +
                    "God_nach_obuch varchar(20) NOT NULL, " +
                    "God_ocon int NOT NULL, " +
                    "`Group` varchar(20) NOT NULL, " +
                    "Namber_personal_del varchar(4) NOT NULL, " +
                    "Kolichestvo_list varchar(3) NOT NULL, " +
                    "Form_obuch varchar(20) NOT NULL, " +
                    "God_nach_LD varchar(4) NOT NULL, " +
                    "God_ocon_LD varchar(4) NOT NULL, " +
                    "Kod varchar(20) NOT NULL, " +
                    "Name_spec char(255) NOT NULL, " +
                    "Qualification varchar(255) NOT NULL, " +
                    "Professional_module varchar(20) NOT NULL, " +
                    "Topic varchar(255) NOT NULL," +
                    "Name_work varchar(50) NOT NULL, " +
                    "Vid_documentd varchar(50) NOT NULL);" +

                "CREATE TABLE IF NOT EXISTS user (" +
                    "id_user int AUTO_INCREMENT PRIMARY KEY," +
                    "Login varchar(255) NOT NULL," +
                    "Password varchar(255) NOT NULL," +
                    "Rol varchar(50) NOT NULL," +
                    "Surname varchar(255) NOT NULL," +
                    "Name varchar(255) NOT NULL," +
                    "Patronymic varchar(255) NOT NULL," +
                    "Post varchar(50) NOT NULL," +
                    "Status varchar(50) NOT NULL);" +

               "CREATE TABLE IF NOT EXISTS Student (" +
                    "id_student int AUTO_INCREMENT PRIMARY KEY," +
                    "FIO varchar(70) NOT NULL," +
                    "God_nach_ob varchar(4) NOT NULL," +
                    "`Group` varchar(8) NOT NULL," +
                    "God_ocon varchar(4) DEFAULT NULL);" +

                "CREATE TABLE IF NOT EXISTS Specialization (" +
                    "id_specialization int AUTO_INCREMENT PRIMARY KEY," +
                    "Kod varchar(9) NOT NULL," +
                    "Name varchar(255) NOT NULL," +
                    "Qualification varchar(255) NOT NULL);" +

                "CREATE TABLE IF NOT EXISTS Type_work (" +
                    "id_type_work int AUTO_INCREMENT PRIMARY KEY," +
                    "Name_work varchar(90) NOT NULL);" +

                "CREATE TABLE IF NOT EXISTS Work (" +
                    "id_work int AUTO_INCREMENT PRIMARY KEY," +
                    "id_type_work int NOT NULL," +
                    "Number_setl int DEFAULT NULL," +
                    "Number_pol int DEFAULT NULL," +
                    "Professional_module varchar(20) DEFAULT NULL," +
                    "`Group` varchar(20) DEFAULT NULL," +
                    "Year varchar(4) DEFAULT NULL," +
                    "FOREIGN KEY (id_type_work) REFERENCES Type_work(id_type_work));" +

                "CREATE TABLE IF NOT EXISTS Work_Stud (" +
                    "id_work_stud int AUTO_INCREMENT PRIMARY KEY," +
                    "Topic varchar(255) NOT NULL," +
                    "id_student int NOT NULL," +
                    "id_work int NOT NULL," +
                    "FOREIGN KEY (`id_student`) REFERENCES `Student`(`id_student`)," +
                    "FOREIGN KEY (id_work) REFERENCES Work(id_work));" +

                "CREATE TABLE IF NOT EXISTS Personal_case (" +
                    "id_personal_delo int AUTO_INCREMENT PRIMARY KEY," +
                    "Number_personal_del int NOT NULL," +
                    "Kolichestvo_list int NOT NULL," +
                    "form_obuch varchar(15) NOT NULL," +
                    "Srock_Hraneniya varchar(2) NOT NULL," +
                    "Number_Shelf int NOT NULL," +
                    "Number_polki int DEFAULT NULL," +
                    "Expelled varchar(3) DEFAULT NULL," +
                    "id_student int NOT NULL," +
                    "God_Nach_LD varchar(4) DEFAULT NULL," +
                    "God_ocon_LD varchar(4) DEFAULT NULL," +
                    "God_nach_obuch varchar(4) DEFAULT NULL," +
                    "God_ocon_obuch varchar(4) DEFAULT NULL," +
                    "id_specialization int NOT NULL," +
                    "FOREIGN KEY (id_specialization) REFERENCES Specialization(id_specialization)," +
                    "FOREIGN KEY (id_student) REFERENCES Student(id_student));" +

                    "CREATE USER IF NOT EXISTS 'Administrator'@'localhost' IDENTIFIED BY WITH MAX_QUERIES_PER_HOUR 0 " +
                    "MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0; GRANT ALL PRIVILEGES ON Archive_fund.*" +

                    "CREATE USER IF NOT EXISTS 'Editor'@'localhost' IDENTIFIED BY WITH MAX_QUERIES_PER_HOUR 0 " +
                    "MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0; GRANT SELECT, INSERT, UPDATE, DELETE PRIVILEGES ON Archive_fund.*" +

                    "CREATE USER IF NOT EXISTS 'User'@'localhost' IDENTIFIED BY WITH MAX_QUERIES_PER_HOUR 0 " +
                    "MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0; GRANT SELECT PRIVILEGES ON Archive_fund.*" +

                "INSERT INTO user (id_user,Login,Password,Rol,Surname,Name,Patronymic,Post,Status) " +
                "VALUES (NULL, 'Admin', '" + BCrypt.Net.BCrypt.EnhancedHashPassword(pass) + "', 'Administrator', '-', '-', '-', " +
                "'Стартовая учетная запись', 'Блокировки нет');";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("База данных успешно создана." +
                "\r\nДля корректного функционирования приложения необходимо пройти процедуру авторизации, " +
                "используя учётную запись администратора, и создать учётные записи для пользователей." +
                "\r\n\r\nДля входа в аккаунт администратора необходимо ввести следующие данные:" +
                "\r\n\r\nЛогин: Admin\r\nПароль: admin","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Ошибка при создании таблиц: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
