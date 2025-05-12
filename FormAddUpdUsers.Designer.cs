namespace Архивный_фонд
{
    partial class FormAddUpdUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdUsers));
            button2 = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxPatronymic = new TextBox();
            textBoxPost = new TextBox();
            label6 = new Label();
            labelINFO = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonSave = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            pictureBoxSeePass = new PictureBox();
            labelStatus = new Label();
            groupBox2 = new GroupBox();
            radioButtonEdit = new RadioButton();
            radioButtonUser = new RadioButton();
            radioButtonAdm = new RadioButton();
            timerAnim = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeePass).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 20, 164);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(373, 590);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(214, 75);
            button2.TabIndex = 0;
            button2.Text = "           Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(208, 38);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин";
            textBoxLogin.Size = new Size(336, 30);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(208, 77);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(336, 30);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(208, 280);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Фамилия";
            textBoxSurname.Size = new Size(336, 30);
            textBoxSurname.TabIndex = 6;
            textBoxSurname.KeyPress += textBoxSurname_KeyPress;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(208, 319);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Имя";
            textBoxName.Size = new Size(336, 30);
            textBoxName.TabIndex = 7;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(208, 358);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.PlaceholderText = "Отчество";
            textBoxPatronymic.Size = new Size(336, 30);
            textBoxPatronymic.TabIndex = 8;
            textBoxPatronymic.KeyPress += textBoxPatronymic_KeyPress;
            // 
            // textBoxPost
            // 
            textBoxPost.Location = new Point(208, 398);
            textBoxPost.Name = "textBoxPost";
            textBoxPost.PlaceholderText = "Должность";
            textBoxPost.Size = new Size(336, 30);
            textBoxPost.TabIndex = 9;
            textBoxPost.KeyPress += textBoxPost_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 398);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 27);
            label6.TabIndex = 18;
            label6.Text = "Должность*";
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(179, 22);
            labelINFO.Margin = new Padding(4, 0, 4, 0);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(335, 27);
            labelINFO.TabIndex = 16;
            labelINFO.Text = "Добавление нового пользователя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 358);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 27);
            label5.TabIndex = 17;
            label5.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 280);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 27);
            label3.TabIndex = 15;
            label3.Text = "Фамилия*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 14;
            label2.Text = "Пароль*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 27);
            label1.TabIndex = 13;
            label1.Text = "Логин*";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 18);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(54, 20, 164);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(125, 590);
            buttonSave.Margin = new Padding(6, 5, 6, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(218, 75);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "           Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(77, 319);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 27);
            label4.TabIndex = 16;
            label4.Text = "Имя*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxSeePass);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxPatronymic);
            groupBox1.Controls.Add(textBoxPost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(31, 54);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(638, 526);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // pictureBoxSeePass
            // 
            pictureBoxSeePass.Image = (Image)resources.GetObject("pictureBoxSeePass.Image");
            pictureBoxSeePass.Location = new Point(550, 74);
            pictureBoxSeePass.Name = "pictureBoxSeePass";
            pictureBoxSeePass.Size = new Size(44, 37);
            pictureBoxSeePass.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSeePass.TabIndex = 27;
            pictureBoxSeePass.TabStop = false;
            pictureBoxSeePass.Click += pictureBoxSeePass_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(77, 459);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(202, 24);
            labelStatus.TabIndex = 26;
            labelStatus.Text = "Статус учетной записи:";
            labelStatus.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonEdit);
            groupBox2.Controls.Add(radioButtonUser);
            groupBox2.Controls.Add(radioButtonAdm);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(143, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 150);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Группа пользователей";
            // 
            // radioButtonEdit
            // 
            radioButtonEdit.AutoSize = true;
            radioButtonEdit.Location = new Point(95, 70);
            radioButtonEdit.Name = "radioButtonEdit";
            radioButtonEdit.Size = new Size(106, 28);
            radioButtonEdit.TabIndex = 4;
            radioButtonEdit.TabStop = true;
            radioButtonEdit.Text = "Редактор";
            radioButtonEdit.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Location = new Point(95, 104);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(147, 28);
            radioButtonUser.TabIndex = 5;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "Пользователь";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdm
            // 
            radioButtonAdm.AutoSize = true;
            radioButtonAdm.Location = new Point(95, 36);
            radioButtonAdm.Name = "radioButtonAdm";
            radioButtonAdm.Size = new Size(158, 28);
            radioButtonAdm.TabIndex = 3;
            radioButtonAdm.TabStop = true;
            radioButtonAdm.Text = "Администратор";
            radioButtonAdm.UseVisualStyleBackColor = true;
            // 
            // timerAnim
            // 
            timerAnim.Interval = 10;
            // 
            // FormAddUpdUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(698, 682);
            Controls.Add(button2);
            Controls.Add(labelINFO);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAddUpdUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddUpdUsers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeePass).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        public Label label6;
        public Label labelINFO;
        public Label label5;
        public Label label3;
        public Label label2;
        public Label label1;
        private PictureBox pictureBox1;
        private Button buttonSave;
        public Label label4;
        private GroupBox groupBox1;
        public Label labelStatus;
        private System.Windows.Forms.Timer timerAnim;
        public TextBox textBoxLogin;
        public TextBox textBoxPassword;
        public TextBox textBoxSurname;
        public TextBox textBoxName;
        public TextBox textBoxPatronymic;
        public TextBox textBoxPost;
        public GroupBox groupBox2;
        public RadioButton radioButtonEdit;
        public RadioButton radioButtonUser;
        public RadioButton radioButtonAdm;
        private PictureBox pictureBoxSeePass;
    }
}