using System.Diagnostics;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Windows.Forms;


namespace Архивный_фонд
{
    public partial class FormAdminPanel : Form
    {
        MySqlCommand cmd;
        String line;
        string myConnString = "";
        string sql;
        string roly = "";
        public string Surname, NameS, Part, role, Post;

        public void fillTable()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableUsers> tableUsers = classListsData.getTable();
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewUsers.RowCount = tableUsers.Count;
            for (int i = 0; i < tableUsers.Count; i++)
            {
                dataGridViewUsers.Rows[i].Cells[0].Value = tableUsers[i].id_user;
                dataGridViewUsers.Rows[i].Cells[1].Value = tableUsers[i].Login;
                dataGridViewUsers.Rows[i].Cells[2].Value = tableUsers[i].Rol;
                dataGridViewUsers.Rows[i].Cells[3].Value = tableUsers[i].Surname;
                dataGridViewUsers.Rows[i].Cells[4].Value = tableUsers[i].Name;
                dataGridViewUsers.Rows[i].Cells[5].Value = tableUsers[i].Patronymic;
                dataGridViewUsers.Rows[i].Cells[6].Value = tableUsers[i].Post;
                dataGridViewUsers.Rows[i].Cells[7].Value = tableUsers[i].Status;
                dataGridViewUsers.Rows[0].Visible = false;
            }
        }

        public FormAdminPanel()
        {
            InitializeComponent();

            // Анимация появления окна
            this.Opacity = 0;
            timerAnim.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05) == 1)
                    timerAnim.Stop();
            });
            timerAnim.Start();

            StreamReader Fileini = new StreamReader("config.ini");
            while ((line = Fileini.ReadLine()) != null)
            {
                myConnString += line + ";";
            }
            Fileini.Close();
            fillTable();
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonCloseAdmPan_Click(object sender, EventArgs e)
        {
            FormDescktop formDescktop = new FormDescktop();
            formDescktop.ShowDialog();
            this.Close();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            FormAddUpdUsers formAddUpdUsers = new FormAddUpdUsers();
            if (formAddUpdUsers.ShowDialog() == DialogResult.OK)
            {
                if (formAddUpdUsers.radioButtonAdm.Checked == true) { roly = "`Administrator`"; }
                else if (formAddUpdUsers.radioButtonEdit.Checked == true) { roly = "Editor"; } else { roly = "`User`"; }
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "INSERT INTO user (id_user, Login, Password, Rol, Surname, Name, Patronymic, Post, Status) " +
                        "VALUES (NULL,'" + formAddUpdUsers.textBoxLogin.Text +
                        "','" + BCrypt.Net.BCrypt.EnhancedHashPassword(formAddUpdUsers.textBoxPassword.Text) +
                        "','" + roly + "','" + formAddUpdUsers.textBoxSurname.Text +
                        "','" + formAddUpdUsers.textBoxName.Text + "','" + formAddUpdUsers.textBoxPatronymic.Text +
                        "','" + formAddUpdUsers.textBoxPost.Text + "','Блокировки нет');";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен!",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    fillTable();
                }
            }
        }

        private void редактироватьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdUsers formAddUpdUsers = new FormAddUpdUsers();
            formAddUpdUsers.labelStatus.Visible = true;
            try
            {
                int indRow = dataGridViewUsers.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridViewUsers.Rows[indRow].Cells[0].Value);
                formAddUpdUsers.textBoxLogin.Text = dataGridViewUsers.Rows[indRow].Cells[1].Value.ToString();
                formAddUpdUsers.textBoxPassword.Text = "12345";
                string roly = dataGridViewUsers.Rows[indRow].Cells[2].Value.ToString();
                if (roly == "`Administrator`"){formAddUpdUsers.radioButtonAdm.Checked = true;} else 
                if (roly == "Editor"){ formAddUpdUsers.radioButtonEdit.Checked = true;}
                else {formAddUpdUsers.radioButtonUser.Checked = true;}
                formAddUpdUsers.textBoxSurname.Text = dataGridViewUsers.Rows[indRow].Cells[3].Value.ToString();
                formAddUpdUsers.textBoxName.Text = dataGridViewUsers.Rows[indRow].Cells[4].Value.ToString();
                formAddUpdUsers.textBoxPatronymic.Text = dataGridViewUsers.Rows[indRow].Cells[5].Value.ToString();
                formAddUpdUsers.textBoxPost.Text = dataGridViewUsers.Rows[indRow].Cells[6].Value.ToString();
                formAddUpdUsers.labelStatus.Text = "Статус учетной записи: " + dataGridViewUsers.Rows[indRow].Cells[7].Value.ToString();

                if (dataGridViewUsers.Rows.Count > 0)
                {
                    if (formAddUpdUsers.ShowDialog() == DialogResult.OK)
                    {
                        if (formAddUpdUsers.radioButtonAdm.Checked == true) { roly = "`Administrator`"; }
                        if (formAddUpdUsers.radioButtonEdit.Checked == true) { roly = "Editor"; } else { roly = "`User`"; }

                        using (MySqlConnection conn = new MySqlConnection(myConnString))
                        {
                            conn.Open();
                            if (formAddUpdUsers.textBoxPassword.Text != "12345")
                            {
                                sql = "UPDATE user SET Login = '" + formAddUpdUsers.textBoxLogin.Text +
                                      "', Password = '" + BCrypt.Net.BCrypt.HashPassword(formAddUpdUsers.textBoxPassword.Text) +
                                      "', Rol = '" + roly +
                                      "', Surname = '" + formAddUpdUsers.textBoxSurname.Text +
                                      "', Name = '" + formAddUpdUsers.textBoxName.Text +
                                      "', Patronymic = '" + formAddUpdUsers.textBoxPatronymic.Text +
                                      "', Post = '" + formAddUpdUsers.textBoxPost.Text +
                                      "' WHERE id_user = '" + id + "'";
                            }
                            else
                            {
                                sql = "UPDATE user SET Login = '" + formAddUpdUsers.textBoxLogin.Text +
                                      "', Rol = '" + roly +
                                      "', Surname = '" + formAddUpdUsers.textBoxSurname.Text +
                                      "', Name = '" + formAddUpdUsers.textBoxName.Text +
                                      "', Patronymic = '" + formAddUpdUsers.textBoxPatronymic.Text +
                                      "', Post = '" + formAddUpdUsers.textBoxPost.Text +
                                      "' WHERE id_user = '" + id + "'";
                            }

                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTable();
                        }
                        MessageBox.Show("Данные пользователя успешно обновлены!", 
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют пользователи для редактирования!", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали пользователя для редактирования!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int indRow = dataGridViewUsers.CurrentRow.Index;
                if (dataGridViewUsers.Rows.Count > 0)
                {
                    DialogResult DRDellUser = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (DRDellUser == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(myConnString))
                        {
                            conn.Open();
                            int id = Convert.ToInt32(dataGridViewUsers.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM user WHERE id_user= '" + id + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTable();
                        }
                        MessageBox.Show("Пользователь успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else { MessageBox.Show("Отсутствуют пользователи для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали пользователя для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLockUser_Click(object sender, EventArgs e)
        {
            try
            {
                int indRow = dataGridViewUsers.CurrentRow.Index;
                if (dataGridViewUsers.Rows.Count > 0)
                {
                    string znachval = Convert.ToString(dataGridViewUsers.Rows[indRow].Cells[7].Value);
                    if (znachval == "Блокировки нет")
                    {
                        DialogResult DRLock = MessageBox.Show("Вы уверенны, что хотите заблокировать данного пользователя?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DRLock == DialogResult.Yes)
                        {
                            using (MySqlConnection conn = new MySqlConnection(myConnString))
                            {
                                conn.Open();
                                int id = Convert.ToInt32(dataGridViewUsers.Rows[indRow].Cells[0].Value);
                                sql = "UPDATE user SET Status= 'Заблокирован' WHERE id_user= '" + id + "'";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();
                                fillTable();
                            }
                            MessageBox.Show("Пользователь успешно заблокирован!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    { MessageBox.Show("Выбранный пользователь уже заблокирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Отсутствуют пользователи для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали пользователя для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnLockUser_Click(object sender, EventArgs e)
        {
            try
            {
                int indRow = dataGridViewUsers.CurrentRow.Index;
                if (dataGridViewUsers.Rows.Count > 0)
                {
                    string znachval = Convert.ToString(dataGridViewUsers.Rows[indRow].Cells[7].Value);
                    if (znachval == "Заблокирован")
                    {
                        DialogResult DRUnLock = MessageBox.Show("Вы уверенны, что хотите разблокировать данного пользователя?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DRUnLock == DialogResult.Yes)
                        {
                            using (MySqlConnection conn = new MySqlConnection(myConnString))
                            {
                                conn.Open();
                                int id = Convert.ToInt32(dataGridViewUsers.Rows[indRow].Cells[0].Value);
                                sql = "UPDATE user SET Status= 'Блокировки нет' WHERE id_user= '" + id + "'";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();
                                fillTable();
                            }
                            MessageBox.Show("Пользователь успешно разблокирован!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    { MessageBox.Show("Выбранный пользователь не имеет блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Отсутствуют пользователи для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали пользователя для блокировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportBD(string myConnString, string outfile)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                var exp = new MySqlBackup(cmd);
                exp.ExportInfo.AddCreateDatabase = false;
                exp.ExportInfo.ExportTableStructure = true;
                exp.ExportInfo.ExportRows = true;
                exp.ExportInfo.ExportFunctions = true;
                exp.ExportInfo.ExportProcedures = true;
                exp.ExportToFile(outfile);
            }
        }

        private void buttonReservCopy_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "SQL files (*.sql)|*.sql";
            saveFileDialog1.FileName = "Резервная копия базы даннных " + DateTime.Now.ToString("d");
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            string outFile = saveFileDialog1.FileName;
            ExportBD(myConnString, outFile);
            MessageBox.Show("Резервная копия базы данных успешно создана.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImportBD(string myConnString, string infile)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                var import = new MySqlBackup(cmd);
                import.ImportInfo.IgnoreSqlError = true;
                import.ImportFromFile(infile);
            }
        }

        private void buttonVostanov_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SQL files (*.sql)|*.sql";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string inFile = openFileDialog1.FileName;
            ImportBD(myConnString, inFile);
            MessageBox.Show("Востановление базы данных успешно завершено.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
