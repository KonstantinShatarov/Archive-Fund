namespace Архивный_фонд
{
    partial class FormAddUpdSpecial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdSpecial));
            groupBox1 = new GroupBox();
            textBoxQol = new TextBox();
            textBoxNameSpec = new TextBox();
            textBoxKod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            labelINFO = new Label();
            button1 = new Button();
            button2 = new Button();
            timerAnimation = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxQol);
            groupBox1.Controls.Add(textBoxNameSpec);
            groupBox1.Controls.Add(textBoxKod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(14, 78);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(694, 376);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // textBoxQol
            // 
            textBoxQol.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxQol.Location = new Point(322, 278);
            textBoxQol.MaxLength = 255;
            textBoxQol.Name = "textBoxQol";
            textBoxQol.PlaceholderText = "Квалификация";
            textBoxQol.Size = new Size(304, 30);
            textBoxQol.TabIndex = 18;
            textBoxQol.KeyPress += textBoxQol_KeyPress;
            // 
            // textBoxNameSpec
            // 
            textBoxNameSpec.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxNameSpec.Location = new Point(322, 129);
            textBoxNameSpec.MaxLength = 255;
            textBoxNameSpec.Multiline = true;
            textBoxNameSpec.Name = "textBoxNameSpec";
            textBoxNameSpec.PlaceholderText = "Название специальности";
            textBoxNameSpec.Size = new Size(304, 127);
            textBoxNameSpec.TabIndex = 17;
            textBoxNameSpec.KeyPress += textBoxNameSpec_KeyPress;
            // 
            // textBoxKod
            // 
            textBoxKod.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxKod.Location = new Point(322, 82);
            textBoxKod.MaxLength = 9;
            textBoxKod.Name = "textBoxKod";
            textBoxKod.PlaceholderText = "Код специальности";
            textBoxKod.Size = new Size(304, 30);
            textBoxKod.TabIndex = 16;
            textBoxKod.KeyPress += textBoxKod_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 278);
            label4.Name = "label4";
            label4.Size = new Size(159, 27);
            label4.TabIndex = 15;
            label4.Text = "Квалификация*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 175);
            label3.Name = "label3";
            label3.Size = new Size(257, 27);
            label3.TabIndex = 14;
            label3.Text = "Название специальности*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 80);
            label2.Name = "label2";
            label2.Size = new Size(205, 27);
            label2.TabIndex = 13;
            label2.Text = "Код специальности*";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 19);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(678, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(156, 34);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(421, 27);
            labelINFO.TabIndex = 12;
            labelINFO.Text = "Добавление информации о специальности";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 20, 164);
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(118, 473);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(214, 80);
            button1.TabIndex = 11;
            button1.Text = "           Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 20, 164);
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(384, 473);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(226, 80);
            button2.TabIndex = 10;
            button2.Text = "           Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timerAnimation
            // 
            timerAnimation.Interval = 10;
            // 
            // FormAddUpdSpecial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(725, 569);
            Controls.Add(groupBox1);
            Controls.Add(labelINFO);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddUpdSpecial";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        public Label labelINFO;
        public TextBox textBoxQol;
        public TextBox textBoxNameSpec;
        public TextBox textBoxKod;
        private System.Windows.Forms.Timer timerAnimation;
    }
}