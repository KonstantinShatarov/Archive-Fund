namespace Архивный_фонд
{
    public partial class FormAddUpdSpecial : Form
    {
        public FormAddUpdSpecial()
        {
            InitializeComponent();

            this.Opacity = 0;
            timerAnimation.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05) == 1)
                    timerAnimation.Stop();
            });
            timerAnimation.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKod.Text == "" || textBoxNameSpec.Text == "" || textBoxQol.Text == "")
            {
                MessageBox.Show("Вы не заполнили все обязательные поля." +
                    "\r\nПроверьте, пожалуйста, их заполнение и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void textBoxNameSpec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxQol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
