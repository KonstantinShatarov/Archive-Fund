namespace Архивный_фонд
{
    public partial class FormAddUpdWork1 : Form
    {
        public FormAddUpdWork1()
        {
            InitializeComponent();
            textBoxGod.Text = DateTime.Now.ToString("yyyy");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeWork.Text == "" || textBoxGod.Text == "" || textBoxGroup.Text == "" || textBoxNumPol.Text == ""
                || textBoxNumStil.Text == "" || textBoxProfMod.Text == "")
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
