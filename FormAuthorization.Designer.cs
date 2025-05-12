namespace Архивный_фонд
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            groupBox1 = new GroupBox();
            pictureBoxSeePass = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonLogin = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            labelERROR = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBoxSeePass);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 347);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(451, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBoxSeePass
            // 
            pictureBoxSeePass.Image = (Image)resources.GetObject("pictureBoxSeePass.Image");
            pictureBoxSeePass.Location = new Point(396, 161);
            pictureBoxSeePass.Name = "pictureBoxSeePass";
            pictureBoxSeePass.Size = new Size(47, 46);
            pictureBoxSeePass.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSeePass.TabIndex = 6;
            pictureBoxSeePass.TabStop = false;
            pictureBoxSeePass.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 139);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(54, 20, 164);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(113, 214);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(216, 55);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(18, 91);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин";
            textBoxLogin.Size = new Size(372, 36);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Text = "Admin";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(17, 167);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(373, 36);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 136);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(153, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(452, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "";
            pictureBox2.Click += pictureBox2_Click;
            // 
            // timer
            // 
            timer.Interval = 10;
            // 
            // labelERROR
            // 
            labelERROR.AutoSize = true;
            labelERROR.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelERROR.ForeColor = Color.Red;
            labelERROR.Location = new Point(9, 327);
            labelERROR.Name = "labelERROR";
            labelERROR.Size = new Size(0, 24);
            labelERROR.TabIndex = 3;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(481, 643);
            Controls.Add(labelERROR);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormAuthorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Архивный фонд :: Авторизация";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer;
        public Button buttonLogin;
        public TextBox textBoxLogin;
        public TextBox textBoxPassword;
        public PictureBox pictureBoxSeePass;
        public Label labelERROR;
    }
}