using Castle.MicroKernel.SubSystems.Conversion;

namespace Архивный_фонд
{
    public partial class FormAddUpdLichDelo : Form
    {
        public string Otchislen = "Нет";

        public FormAddUpdLichDelo()
        {
            InitializeComponent();
            textBoxGodNachObuch.Text = DateTime.Now.ToString("yyyy");
            textBoxGodNachLD.Text = DateTime.Now.ToString("yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNumberLichDela.Text == "" || textBoxKolList.Text == "" || textBoxFIOStud.Text == ""
                || textBoxGodNachLD.Text == "" || textBoxGodNachObuch.Text == "" || textBoxNamStel.Text == ""
                || textBoxNamPolc.Text == "" || comboBox1.Text == "" || textBoxSrockHran.Text == "")
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!" +
                "\r\nПроверьте все обязательные поля помеченные * и если они пустые, заполните их!",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButtonOchno.Checked == false && radioButtonOchZaoch.Checked == false && radioButtonZaOchno.Checked == false)
                {
                    MessageBox.Show("Вы не выбрали форму обучения студента!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (radioButtonOchno.Checked == true) { labelForma.Text = "Очная"; }
                    if (radioButtonZaOchno.Checked == true) { labelForma.Text = "Заочная"; } else { labelForma.Text = "Очно-заочная"; }
                    if (checkBox.Checked == true) { Otchislen = "Да"; }
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGodNachLD_TextChanged(object sender, EventArgs e)
        {
            int srokHran = Convert.ToInt32(textBoxSrockHran.Text);
            int HranDo = srokHran + Convert.ToInt32(textBoxGodNachLD.Text);
            textBoxGodOconLD.Text = HranDo.ToString();
        }

        private void textBoxNumberLichDela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxKolList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxGodNachLD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxGodOconLD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxGodNachObuch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxGodOconObuch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
