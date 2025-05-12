using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Архивный_фонд
{
    public partial class FormAuthorization : Form
    {
        MySqlCommand cmd;
        String line;
        string myConnString = "";
        string sql;
        static public string Surname, NameS, Part, role, Post, Status;

        public FormAuthorization()
        {
            InitializeComponent();
            try
            {
                StreamReader Fileini = new StreamReader("config.ini");
                while ((line = Fileini.ReadLine()) != null)
                {
                    myConnString += line + ";";
                }
                Fileini.Close();
                // Анимация появления окна
                this.Opacity = 0;
                timer.Tick += new EventHandler((sender, e) =>
                {
                    if ((Opacity += 0.05) == 1)
                        timer.Stop();
                });
                timer.Start();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                        "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Number == 1049)
                {
                    DialogResult = MessageBox.Show("На сервере не обнаружена база данных." +
                        "\r\n\r\nЕсли вы желаете создать её автоматически, нажмите «Да»." +
                        "\r\nЕсли вы предпочитаете создать базу данных самостоятельно, то нажмите «Нет», и программа завершит работу, " +
                        "чтобы вы могли приступить к созданию базы данных самостоятельно».", "Сообщение",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(myConnString))
                        {
                            conn.Open();
                            ClassCreateDB createBD = new ClassCreateDB();
                            createBD.CreateDatabaseIfNotExists();
                        }
                    }
                    else { Application.Exit(); }
                }
            }
        }

        public  void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text != "")
                {
                    {
                        using (MySqlConnection conn = new MySqlConnection(myConnString))
                        {
                            conn.Open();
                            sql = "SELECT Status,Rol,Post,Surname,Name,Patronymic,Password,Login " +
                                "FROM user WHERE Login = '" + textBoxLogin.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                if (BCrypt.Net.BCrypt.EnhancedVerify(textBoxPassword.Text, reader["Password"].ToString()))
                                {
                                    Status = reader["Status"].ToString();
                                    if (Status == "Блокировки нет")
                                    {
                                        role = reader["Rol"].ToString();
                                        Post = reader["Post"].ToString();
                                        Surname = reader["Surname"].ToString();
                                        NameS = reader["Name"].ToString();
                                        Part = reader["Patronymic"].ToString();
                                        reader.Close();

                                        this.Hide();
                                        FormDescktop formDescktop = new FormDescktop();
                                        formDescktop.ShowDialog();
                                    }
                                    else
                                    {
                                        reader.Close();
                                        labelERROR.Text = "Пользователь заблокирован, вход не возможен!";
                                    }
                                }
                                else
                                {
                                    labelERROR.Text = "Неверно введен пользователь или пароль, попробуйте ещё раз";
                                    reader.Close();
                                    return;
                                }
                            }
                            else
                            { labelERROR.Text = "Неверно введен пользователь или пароль!"; }
                        }
                    }
                }
                else
                { labelERROR.Text = "Поле с паролем недолжно быть пустым!"; }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                        "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                pictureBoxSeePass.Image = Image.FromFile("..\\..\\..\\Resurses\\visible_6689978.png");
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                pictureBoxSeePass.Image = Image.FromFile("..\\..\\..\\Resurses\\eye-scanner_3262356.png");
            }
        }
    }
}