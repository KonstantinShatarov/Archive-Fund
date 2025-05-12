using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Архивный_фонд
{
    public partial class FormAddUpdUsers : Form
    {
        public FormAddUpdUsers()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminPanel formAdminPanel = new FormAdminPanel();
            formAdminPanel.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == ""
                || textBoxSurname.Text == "" || textBoxPatronymic.Text == "" || textBoxPost.Text == "")
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButtonAdm.Checked == false && radioButtonEdit.Checked == false && radioButtonUser.Checked == false)
                {
                    MessageBox.Show("Вы не назначили добавляемому пользователю права!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { DialogResult = DialogResult.OK; }
            }
        }

        private void pictureBoxSeePass_Click(object sender, EventArgs e)
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

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
