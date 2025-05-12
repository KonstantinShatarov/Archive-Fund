namespace Архивный_фонд
{
    partial class FormAddUpdWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdWork));
            groupBox1 = new GroupBox();
            textBoxNameWork = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            labelINFO = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNameWork);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(17, 59);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(638, 161);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // textBoxNameWork
            // 
            textBoxNameWork.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxNameWork.Location = new Point(216, 61);
            textBoxNameWork.Multiline = true;
            textBoxNameWork.Name = "textBoxNameWork";
            textBoxNameWork.PlaceholderText = "Название работы*";
            textBoxNameWork.Size = new Size(382, 55);
            textBoxNameWork.TabIndex = 14;
            textBoxNameWork.KeyPress += textBoxNameWork_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 27);
            label1.TabIndex = 13;
            label1.Text = "Название работы*";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 20, 164);
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(355, 230);
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
            labelINFO.Location = new Point(165, 27);
            labelINFO.Margin = new Padding(4, 0, 4, 0);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(326, 27);
            labelINFO.TabIndex = 20;
            labelINFO.Text = "Добавление нового вида работы";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 20, 164);
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(107, 230);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(218, 75);
            button1.TabIndex = 19;
            button1.Text = "           Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAddUpdWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(676, 324);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(labelINFO);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddUpdWork";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работы";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        public Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        public Label labelINFO;
        private Button button1;
        public TextBox textBoxNameWork;
    }
}