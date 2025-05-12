namespace Архивный_фонд
{
    partial class FormAddUpdWork1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdWork1));
            buttonCansel = new Button();
            buttonSave = new Button();
            textBoxNumStil = new TextBox();
            textBoxNumPol = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxGod = new TextBox();
            label6 = new Label();
            textBoxGroup = new TextBox();
            label5 = new Label();
            textBoxProfMod = new TextBox();
            label4 = new Label();
            comboBoxTypeWork = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            labelINFO = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCansel
            // 
            buttonCansel.BackColor = Color.FromArgb(54, 20, 164);
            buttonCansel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            buttonCansel.ForeColor = Color.White;
            buttonCansel.Image = (Image)resources.GetObject("buttonCansel.Image");
            buttonCansel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCansel.Location = new Point(353, 310);
            buttonCansel.Margin = new Padding(6, 5, 6, 5);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(214, 75);
            buttonCansel.TabIndex = 22;
            buttonCansel.Text = "           Отмена";
            buttonCansel.UseVisualStyleBackColor = false;
            buttonCansel.Click += buttonCansel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(54, 20, 164);
            buttonSave.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(105, 310);
            buttonSave.Margin = new Padding(6, 5, 6, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(218, 75);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "           Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxNumStil
            // 
            textBoxNumStil.Location = new Point(470, 201);
            textBoxNumStil.MaxLength = 5;
            textBoxNumStil.Name = "textBoxNumStil";
            textBoxNumStil.PlaceholderText = "Номер стилажа";
            textBoxNumStil.Size = new Size(132, 30);
            textBoxNumStil.TabIndex = 38;
            // 
            // textBoxNumPol
            // 
            textBoxNumPol.Location = new Point(181, 200);
            textBoxNumPol.MaxLength = 5;
            textBoxNumPol.Name = "textBoxNumPol";
            textBoxNumPol.PlaceholderText = "Номер полки";
            textBoxNumPol.Size = new Size(123, 30);
            textBoxNumPol.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(309, 202);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 27);
            label8.TabIndex = 37;
            label8.Text = "Номер стилажа*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(35, 201);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 27);
            label7.TabIndex = 35;
            label7.Text = "Номер полки*";
            // 
            // textBoxGod
            // 
            textBoxGod.Location = new Point(181, 158);
            textBoxGod.MaxLength = 4;
            textBoxGod.Name = "textBoxGod";
            textBoxGod.PlaceholderText = "Год";
            textBoxGod.Size = new Size(421, 30);
            textBoxGod.TabIndex = 34;
            textBoxGod.KeyPress += textBoxGod_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(35, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 27);
            label6.TabIndex = 33;
            label6.Text = "Год*";
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(181, 117);
            textBoxGroup.MaxLength = 6;
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.PlaceholderText = "Группа";
            textBoxGroup.Size = new Size(421, 30);
            textBoxGroup.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 119);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 27);
            label5.TabIndex = 31;
            label5.Text = "Группа*";
            // 
            // textBoxProfMod
            // 
            textBoxProfMod.Location = new Point(181, 75);
            textBoxProfMod.MaxLength = 10;
            textBoxProfMod.Name = "textBoxProfMod";
            textBoxProfMod.PlaceholderText = "Профессиональный модуль";
            textBoxProfMod.Size = new Size(421, 30);
            textBoxProfMod.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 77);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 27);
            label4.TabIndex = 29;
            label4.Text = "Проф. модуль*";
            // 
            // comboBoxTypeWork
            // 
            comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeWork.FormattingEnabled = true;
            comboBoxTypeWork.Location = new Point(181, 31);
            comboBoxTypeWork.Name = "comboBoxTypeWork";
            comboBoxTypeWork.Size = new Size(421, 32);
            comboBoxTypeWork.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 27);
            label3.TabIndex = 27;
            label3.Text = "Тип работы*";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNumStil);
            groupBox1.Controls.Add(textBoxNumPol);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxGod);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxGroup);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxProfMod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxTypeWork);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(11, 41);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(638, 259);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(166, 9);
            labelINFO.Margin = new Padding(4, 0, 4, 0);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(322, 27);
            labelINFO.TabIndex = 24;
            labelINFO.Text = "Добавление нового типа работы\r\n";
            // 
            // FormAddUpdWork1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(661, 406);
            Controls.Add(buttonCansel);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Controls.Add(labelINFO);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(661, 406);
            MinimumSize = new Size(661, 406);
            Name = "FormAddUpdWork1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddUpdTypeWork";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCansel;
        private Button buttonSave;
        public TextBox textBoxNumStil;
        public TextBox textBoxNumPol;
        public Label label8;
        public Label label7;
        public TextBox textBoxGod;
        public Label label6;
        public TextBox textBoxGroup;
        public Label label5;
        public TextBox textBoxProfMod;
        public Label label4;
        public ComboBox comboBoxTypeWork;
        public Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        public Label labelINFO;
    }
}