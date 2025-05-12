namespace Архивный_фонд
{
    partial class FormAddUpdLichDelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdLichDelo));
            groupBox1 = new GroupBox();
            textBoxGroup = new TextBox();
            label13 = new Label();
            comboBox1 = new ComboBox();
            textBoxFIOStud = new TextBox();
            textBoxNamPolc = new TextBox();
            textBoxNamStel = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            textBoxGodOconObuch = new TextBox();
            label9 = new Label();
            textBoxGodNachObuch = new TextBox();
            label8 = new Label();
            textBoxGodOconLD = new TextBox();
            label7 = new Label();
            textBoxGodNachLD = new TextBox();
            label6 = new Label();
            checkBox = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            textBoxSrockHran = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            radioButtonOchZaoch = new RadioButton();
            radioButtonZaOchno = new RadioButton();
            radioButtonOchno = new RadioButton();
            textBoxKolList = new TextBox();
            label2 = new Label();
            textBoxNumberLichDela = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonCansel = new Button();
            buttonSave = new Button();
            labelINFO = new Label();
            labelForma = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxGroup);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBoxFIOStud);
            groupBox1.Controls.Add(textBoxNamPolc);
            groupBox1.Controls.Add(textBoxNamStel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxGodOconObuch);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxGodNachObuch);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxGodOconLD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxGodNachLD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxSrockHran);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBoxKolList);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxNumberLichDela);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(49, 42);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(634, 642);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxGroup.Location = new Point(256, 507);
            textBoxGroup.MaxLength = 6;
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.PlaceholderText = "Группа";
            textBoxGroup.Size = new Size(360, 30);
            textBoxGroup.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(24, 513);
            label13.Name = "label13";
            label13.Size = new Size(74, 24);
            label13.TabIndex = 39;
            label13.Text = "Группа*";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 22;
            comboBox1.Location = new Point(256, 468);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 30);
            comboBox1.TabIndex = 38;
            // 
            // textBoxFIOStud
            // 
            textBoxFIOStud.Location = new Point(258, 264);
            textBoxFIOStud.MaxLength = 255;
            textBoxFIOStud.Name = "textBoxFIOStud";
            textBoxFIOStud.PlaceholderText = "ФИО студента";
            textBoxFIOStud.Size = new Size(356, 30);
            textBoxFIOStud.TabIndex = 37;
            textBoxFIOStud.KeyPress += textBoxFIOStud_KeyPress;
            // 
            // textBoxNamPolc
            // 
            textBoxNamPolc.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxNamPolc.Location = new Point(256, 584);
            textBoxNamPolc.MaxLength = 5;
            textBoxNamPolc.Name = "textBoxNamPolc";
            textBoxNamPolc.PlaceholderText = "Номер полки";
            textBoxNamPolc.Size = new Size(361, 30);
            textBoxNamPolc.TabIndex = 36;
            // 
            // textBoxNamStel
            // 
            textBoxNamStel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxNamStel.Location = new Point(257, 546);
            textBoxNamStel.MaxLength = 5;
            textBoxNamStel.Name = "textBoxNamStel";
            textBoxNamStel.PlaceholderText = "Номер стелажа";
            textBoxNamStel.Size = new Size(359, 30);
            textBoxNamStel.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 587);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(122, 24);
            label11.TabIndex = 34;
            label11.Text = "Номер полки*\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(24, 547);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 24);
            label12.TabIndex = 33;
            label12.Text = "Номер стелажа*\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 476);
            label10.Name = "label10";
            label10.Size = new Size(143, 24);
            label10.TabIndex = 26;
            label10.Text = "Специальность*";
            // 
            // textBoxGodOconObuch
            // 
            textBoxGodOconObuch.Location = new Point(256, 429);
            textBoxGodOconObuch.MaxLength = 4;
            textBoxGodOconObuch.Name = "textBoxGodOconObuch";
            textBoxGodOconObuch.PlaceholderText = "Год окончания обучения";
            textBoxGodOconObuch.Size = new Size(358, 30);
            textBoxGodOconObuch.TabIndex = 25;
            textBoxGodOconObuch.KeyPress += textBoxGodOconObuch_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 433);
            label9.Name = "label9";
            label9.Size = new Size(215, 24);
            label9.TabIndex = 24;
            label9.Text = "Год окончания обучения\r\n";
            // 
            // textBoxGodNachObuch
            // 
            textBoxGodNachObuch.Location = new Point(256, 388);
            textBoxGodNachObuch.MaxLength = 4;
            textBoxGodNachObuch.Name = "textBoxGodNachObuch";
            textBoxGodNachObuch.PlaceholderText = "Год начала обучения";
            textBoxGodNachObuch.Size = new Size(358, 30);
            textBoxGodNachObuch.TabIndex = 23;
            textBoxGodNachObuch.KeyPress += textBoxGodNachObuch_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(24, 391);
            label8.Name = "label8";
            label8.Size = new Size(191, 24);
            label8.TabIndex = 22;
            label8.Text = "Год начала обучения*";
            // 
            // textBoxGodOconLD
            // 
            textBoxGodOconLD.Enabled = false;
            textBoxGodOconLD.Location = new Point(257, 347);
            textBoxGodOconLD.MaxLength = 4;
            textBoxGodOconLD.Name = "textBoxGodOconLD";
            textBoxGodOconLD.PlaceholderText = "Год закрытия личного дела ";
            textBoxGodOconLD.Size = new Size(358, 30);
            textBoxGodOconLD.TabIndex = 21;
            textBoxGodOconLD.KeyPress += textBoxGodOconLD_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 350);
            label7.Name = "label7";
            label7.Size = new Size(238, 24);
            label7.TabIndex = 20;
            label7.Text = "Год закрытия личного дела\r\n";
            // 
            // textBoxGodNachLD
            // 
            textBoxGodNachLD.Location = new Point(256, 304);
            textBoxGodNachLD.MaxLength = 4;
            textBoxGodNachLD.Name = "textBoxGodNachLD";
            textBoxGodNachLD.PlaceholderText = "Год начала личного дела ";
            textBoxGodNachLD.Size = new Size(358, 30);
            textBoxGodNachLD.TabIndex = 19;
            textBoxGodNachLD.TextChanged += textBoxGodNachLD_TextChanged;
            textBoxGodNachLD.KeyPress += textBoxGodNachLD_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 310);
            label6.Name = "label6";
            label6.Size = new Size(223, 24);
            label6.TabIndex = 18;
            label6.Text = "Год начала личного дела*";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.ForeColor = Color.White;
            checkBox.Location = new Point(484, 46);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(111, 28);
            checkBox.TabIndex = 17;
            checkBox.Text = "Отчислен";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 550);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 270);
            label4.Name = "label4";
            label4.Size = new Size(132, 24);
            label4.TabIndex = 14;
            label4.Text = "ФИО студента*";
            // 
            // textBoxSrockHran
            // 
            textBoxSrockHran.Location = new Point(258, 223);
            textBoxSrockHran.MaxLength = 3;
            textBoxSrockHran.Name = "textBoxSrockHran";
            textBoxSrockHran.PlaceholderText = "Срок хранения";
            textBoxSrockHran.Size = new Size(358, 30);
            textBoxSrockHran.TabIndex = 13;
            textBoxSrockHran.Text = "75";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 223);
            label3.Name = "label3";
            label3.Size = new Size(138, 24);
            label3.TabIndex = 12;
            label3.Text = "Срок хранения*";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonOchZaoch);
            groupBox2.Controls.Add(radioButtonZaOchno);
            groupBox2.Controls.Add(radioButtonOchno);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(24, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 78);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Форма обучения *";
            // 
            // radioButtonOchZaoch
            // 
            radioButtonOchZaoch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonOchZaoch.AutoSize = true;
            radioButtonOchZaoch.Location = new Point(376, 35);
            radioButtonOchZaoch.Name = "radioButtonOchZaoch";
            radioButtonOchZaoch.Size = new Size(145, 28);
            radioButtonOchZaoch.TabIndex = 2;
            radioButtonOchZaoch.TabStop = true;
            radioButtonOchZaoch.Text = "Очно-заочная";
            radioButtonOchZaoch.UseVisualStyleBackColor = true;
            // 
            // radioButtonZaOchno
            // 
            radioButtonZaOchno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonZaOchno.AutoSize = true;
            radioButtonZaOchno.Location = new Point(183, 35);
            radioButtonZaOchno.Name = "radioButtonZaOchno";
            radioButtonZaOchno.Size = new Size(99, 28);
            radioButtonZaOchno.TabIndex = 1;
            radioButtonZaOchno.TabStop = true;
            radioButtonZaOchno.Text = "Заочная";
            radioButtonZaOchno.UseVisualStyleBackColor = true;
            // 
            // radioButtonOchno
            // 
            radioButtonOchno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonOchno.AutoSize = true;
            radioButtonOchno.Location = new Point(38, 35);
            radioButtonOchno.Name = "radioButtonOchno";
            radioButtonOchno.Size = new Size(83, 28);
            radioButtonOchno.TabIndex = 0;
            radioButtonOchno.TabStop = true;
            radioButtonOchno.Text = "Очная";
            radioButtonOchno.UseVisualStyleBackColor = true;
            // 
            // textBoxKolList
            // 
            textBoxKolList.Location = new Point(258, 90);
            textBoxKolList.MaxLength = 3;
            textBoxKolList.Name = "textBoxKolList";
            textBoxKolList.PlaceholderText = "Количество листов";
            textBoxKolList.Size = new Size(358, 30);
            textBoxKolList.TabIndex = 10;
            textBoxKolList.KeyPress += textBoxKolList_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(174, 24);
            label2.TabIndex = 9;
            label2.Text = "Количество листов*";
            // 
            // textBoxNumberLichDela
            // 
            textBoxNumberLichDela.Location = new Point(258, 43);
            textBoxNumberLichDela.MaxLength = 4;
            textBoxNumberLichDela.Name = "textBoxNumberLichDela";
            textBoxNumberLichDela.PlaceholderText = "Номер личного дела";
            textBoxNumberLichDela.Size = new Size(215, 30);
            textBoxNumberLichDela.TabIndex = 8;
            textBoxNumberLichDela.KeyPress += textBoxNumberLichDela_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(174, 24);
            label1.TabIndex = 7;
            label1.Text = "Номер линого дела*";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 19);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonCansel
            // 
            buttonCansel.BackColor = Color.FromArgb(54, 20, 164);
            buttonCansel.ForeColor = Color.White;
            buttonCansel.Image = (Image)resources.GetObject("buttonCansel.Image");
            buttonCansel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCansel.Location = new Point(380, 692);
            buttonCansel.Margin = new Padding(4);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(226, 80);
            buttonCansel.TabIndex = 6;
            buttonCansel.Text = "           Отмена";
            buttonCansel.UseVisualStyleBackColor = false;
            buttonCansel.Click += button2_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(54, 20, 164);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(114, 692);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(214, 80);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "           Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += button1_Click;
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(131, 11);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(473, 27);
            labelINFO.TabIndex = 8;
            labelINFO.Text = "Добавление информации личного дела студента\r\n";
            // 
            // labelForma
            // 
            labelForma.AutoSize = true;
            labelForma.Location = new Point(651, 748);
            labelForma.Name = "labelForma";
            labelForma.Size = new Size(0, 24);
            labelForma.TabIndex = 9;
            labelForma.Visible = false;
            // 
            // FormAddUpdLichDelo
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(727, 801);
            Controls.Add(labelForma);
            Controls.Add(labelINFO);
            Controls.Add(buttonSave);
            Controls.Add(buttonCansel);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAddUpdLichDelo";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonCansel;
        private Button buttonSave;
        private PictureBox pictureBox1;
        public Label labelINFO;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        public Label label11;
        public Label label12;
        public TextBox textBoxNumberLichDela;
        public TextBox textBoxSrockHran;
        public RadioButton radioButtonOchZaoch;
        public RadioButton radioButtonZaOchno;
        public RadioButton radioButtonOchno;
        public TextBox textBoxKolList;
        public TextBox textBoxGodOconLD;
        public TextBox textBoxGodNachLD;
        public TextBox textBoxGodOconObuch;
        public TextBox textBoxGodNachObuch;
        public TextBox textBoxNamPolc;
        public TextBox textBoxNamStel;
        public TextBox textBoxFIOStud;
        public CheckBox checkBox;
        public Label labelForma;
        public ComboBox comboBox1;
        public TextBox textBoxGroup;
        private Label label13;
    }
}