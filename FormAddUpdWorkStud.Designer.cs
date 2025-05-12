namespace Архивный_фонд
{
    partial class FormAddUpdWorkStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdWorkStud));
            textBoxTopic = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxTypeWork = new ComboBox();
            label3 = new Label();
            textBoxFIOStud = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            labelINFO = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTopic
            // 
            textBoxTopic.Location = new Point(188, 46);
            textBoxTopic.MaxLength = 255;
            textBoxTopic.Multiline = true;
            textBoxTopic.Name = "textBoxTopic";
            textBoxTopic.PlaceholderText = "Тема работы";
            textBoxTopic.Size = new Size(402, 157);
            textBoxTopic.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxTypeWork);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxFIOStud);
            groupBox1.Controls.Add(textBoxTopic);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 68);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(629, 352);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // comboBoxTypeWork
            // 
            comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeWork.FormattingEnabled = true;
            comboBoxTypeWork.Location = new Point(188, 272);
            comboBoxTypeWork.Name = "comboBoxTypeWork";
            comboBoxTypeWork.Size = new Size(402, 32);
            comboBoxTypeWork.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 27;
            label3.Text = "Вид работы*";
            // 
            // textBoxFIOStud
            // 
            textBoxFIOStud.Location = new Point(188, 222);
            textBoxFIOStud.MaxLength = 255;
            textBoxFIOStud.Name = "textBoxFIOStud";
            textBoxFIOStud.PlaceholderText = "ФИО студента";
            textBoxFIOStud.Size = new Size(402, 30);
            textBoxFIOStud.TabIndex = 26;
            textBoxFIOStud.KeyPress += textBoxFIOStud_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 27);
            label2.TabIndex = 14;
            label2.Text = "ФИО студента*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 27);
            label1.TabIndex = 13;
            label1.Text = "Тема работы*";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 20, 164);
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(365, 430);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(214, 75);
            button2.TabIndex = 18;
            button2.Text = "           Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(177, 36);
            labelINFO.Margin = new Padding(4, 0, 4, 0);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(354, 27);
            labelINFO.TabIndex = 20;
            labelINFO.Text = "Добавление новой работы студента";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 20, 164);
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(117, 430);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(218, 75);
            button1.TabIndex = 19;
            button1.Text = "           Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAddUpdWorkStud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(671, 518);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(labelINFO);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddUpdWorkStud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работы студентов";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        public Label label2;
        public Label label1;
        private Button button2;
        public Label labelINFO;
        private Button button1;
        private PictureBox pictureBox1;
        public Label label3;
        public TextBox textBoxTopic;
        public ComboBox comboBoxTypeWork;
        public TextBox textBoxFIOStud;
    }
}