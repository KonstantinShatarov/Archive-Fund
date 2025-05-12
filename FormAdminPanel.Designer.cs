namespace Архивный_фонд
{
    partial class FormAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonVostanov = new Button();
            buttonReservCopy = new Button();
            buttonUnLockUser = new Button();
            buttonLockUser = new Button();
            buttonCreateUser = new Button();
            buttonCloseAdmPan = new Button();
            groupBox1 = new GroupBox();
            dataGridViewUsers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            contextMenuStripUsers = new ContextMenuStrip(components);
            редактироватьПользователяToolStripMenuItem = new ToolStripMenuItem();
            удалитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            timerAnim = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            contextMenuStripUsers.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonVostanov);
            panel1.Controls.Add(buttonReservCopy);
            panel1.Controls.Add(buttonUnLockUser);
            panel1.Controls.Add(buttonLockUser);
            panel1.Controls.Add(buttonCreateUser);
            panel1.Controls.Add(buttonCloseAdmPan);
            panel1.Location = new Point(1, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 174);
            panel1.TabIndex = 7;
            // 
            // buttonVostanov
            // 
            buttonVostanov.BackColor = Color.FromArgb(54, 20, 164);
            buttonVostanov.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonVostanov.ForeColor = Color.White;
            buttonVostanov.Image = (Image)resources.GetObject("buttonVostanov.Image");
            buttonVostanov.Location = new Point(888, 9);
            buttonVostanov.Margin = new Padding(5);
            buttonVostanov.Name = "buttonVostanov";
            buttonVostanov.Size = new Size(148, 152);
            buttonVostanov.TabIndex = 14;
            buttonVostanov.Text = "Востановление базы\r\n";
            buttonVostanov.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonVostanov.UseVisualStyleBackColor = false;
            buttonVostanov.Click += buttonVostanov_Click;
            // 
            // buttonReservCopy
            // 
            buttonReservCopy.BackColor = Color.FromArgb(54, 20, 164);
            buttonReservCopy.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReservCopy.ForeColor = Color.White;
            buttonReservCopy.Image = (Image)resources.GetObject("buttonReservCopy.Image");
            buttonReservCopy.Location = new Point(722, 9);
            buttonReservCopy.Margin = new Padding(5);
            buttonReservCopy.Name = "buttonReservCopy";
            buttonReservCopy.Size = new Size(156, 152);
            buttonReservCopy.TabIndex = 13;
            buttonReservCopy.Text = "Резервное копирование базы\r\n";
            buttonReservCopy.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonReservCopy.UseVisualStyleBackColor = false;
            buttonReservCopy.Click += buttonReservCopy_Click;
            // 
            // buttonUnLockUser
            // 
            buttonUnLockUser.BackColor = Color.FromArgb(54, 20, 164);
            buttonUnLockUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonUnLockUser.ForeColor = Color.White;
            buttonUnLockUser.Image = (Image)resources.GetObject("buttonUnLockUser.Image");
            buttonUnLockUser.Location = new Point(561, 9);
            buttonUnLockUser.Margin = new Padding(5);
            buttonUnLockUser.Name = "buttonUnLockUser";
            buttonUnLockUser.Size = new Size(151, 152);
            buttonUnLockUser.TabIndex = 12;
            buttonUnLockUser.Text = "Разблокировать пользователя";
            buttonUnLockUser.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonUnLockUser.UseVisualStyleBackColor = false;
            buttonUnLockUser.Click += buttonUnLockUser_Click;
            // 
            // buttonLockUser
            // 
            buttonLockUser.BackColor = Color.FromArgb(54, 20, 164);
            buttonLockUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLockUser.ForeColor = Color.White;
            buttonLockUser.Image = (Image)resources.GetObject("buttonLockUser.Image");
            buttonLockUser.Location = new Point(416, 9);
            buttonLockUser.Margin = new Padding(5);
            buttonLockUser.Name = "buttonLockUser";
            buttonLockUser.Size = new Size(135, 152);
            buttonLockUser.TabIndex = 11;
            buttonLockUser.Text = "Блокировка пользователя";
            buttonLockUser.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLockUser.UseVisualStyleBackColor = false;
            buttonLockUser.Click += buttonLockUser_Click;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.BackColor = Color.FromArgb(54, 20, 164);
            buttonCreateUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCreateUser.ForeColor = Color.White;
            buttonCreateUser.Image = (Image)resources.GetObject("buttonCreateUser.Image");
            buttonCreateUser.Location = new Point(273, 9);
            buttonCreateUser.Margin = new Padding(5);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(133, 152);
            buttonCreateUser.TabIndex = 10;
            buttonCreateUser.Text = "Добавить пользователя";
            buttonCreateUser.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCreateUser.UseVisualStyleBackColor = false;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // buttonCloseAdmPan
            // 
            buttonCloseAdmPan.BackColor = Color.FromArgb(54, 20, 164);
            buttonCloseAdmPan.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloseAdmPan.ForeColor = Color.White;
            buttonCloseAdmPan.Image = (Image)resources.GetObject("buttonCloseAdmPan.Image");
            buttonCloseAdmPan.Location = new Point(136, 9);
            buttonCloseAdmPan.Margin = new Padding(5);
            buttonCloseAdmPan.Name = "buttonCloseAdmPan";
            buttonCloseAdmPan.Size = new Size(127, 152);
            buttonCloseAdmPan.TabIndex = 9;
            buttonCloseAdmPan.Text = "Выход из админпанели";
            buttonCloseAdmPan.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCloseAdmPan.UseVisualStyleBackColor = false;
            buttonCloseAdmPan.Click += buttonCloseAdmPan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsers);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 192);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1125, 440);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пользователи";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column8, Column4, Column5, Column6, Column7, Column9 });
            dataGridViewUsers.ContextMenuStrip = contextMenuStripUsers;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.GridColor = Color.Silver;
            dataGridViewUsers.Location = new Point(7, 30);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(1111, 403);
            dataGridViewUsers.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "id_user";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Логин";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Роль";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Фамилия";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Имя";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Отчество";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Должность";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Статус";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // contextMenuStripUsers
            // 
            contextMenuStripUsers.BackColor = Color.FromArgb(54, 20, 164);
            contextMenuStripUsers.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            contextMenuStripUsers.ImageScalingSize = new Size(20, 20);
            contextMenuStripUsers.Items.AddRange(new ToolStripItem[] { редактироватьПользователяToolStripMenuItem, удалитьПользователяToolStripMenuItem });
            contextMenuStripUsers.Name = "contextMenuStripUsers";
            contextMenuStripUsers.Size = new Size(326, 60);
            // 
            // редактироватьПользователяToolStripMenuItem
            // 
            редактироватьПользователяToolStripMenuItem.ForeColor = Color.White;
            редактироватьПользователяToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьПользователяToolStripMenuItem.Image");
            редактироватьПользователяToolStripMenuItem.ImageTransparentColor = Color.FromArgb(54, 20, 164);
            редактироватьПользователяToolStripMenuItem.Name = "редактироватьПользователяToolStripMenuItem";
            редактироватьПользователяToolStripMenuItem.Size = new Size(325, 28);
            редактироватьПользователяToolStripMenuItem.Text = "Редактировать пользователя";
            редактироватьПользователяToolStripMenuItem.Click += редактироватьПользователяToolStripMenuItem_Click;
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            удалитьПользователяToolStripMenuItem.ForeColor = Color.White;
            удалитьПользователяToolStripMenuItem.Image = (Image)resources.GetObject("удалитьПользователяToolStripMenuItem.Image");
            удалитьПользователяToolStripMenuItem.ImageTransparentColor = Color.FromArgb(54, 20, 164);
            удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            удалитьПользователяToolStripMenuItem.Size = new Size(325, 28);
            удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            удалитьПользователяToolStripMenuItem.Click += удалитьПользователяToolStripMenuItem_Click;
            // 
            // timerAnim
            // 
            timerAnim.Interval = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(1154, 645);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Админпанель";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            contextMenuStripUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCloseAdmPan;
        private GroupBox groupBox1;
        private Button buttonCreateUser;
        private ContextMenuStrip contextMenuStripUsers;
        private ToolStripMenuItem редактироватьПользователяToolStripMenuItem;
        private ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private Button buttonLockUser;
        private Button buttonUnLockUser;
        private Button buttonVostanov;
        private Button buttonReservCopy;
        public DataGridView dataGridViewUsers;
        private System.Windows.Forms.Timer timerAnim;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
    }
}