namespace Архивный_фонд
{
    public partial class FormAddUpdWorkStud : Form
    {
        public FormAddUpdWorkStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFIOStud.Text == "" || textBoxTopic.Text == "" || comboBoxTypeWork.Text == "")
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFIOStud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
