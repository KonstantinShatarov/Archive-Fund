namespace Архивный_фонд
{
    partial class FormDescktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescktop));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            statusStrip = new StatusStrip();
            toolStripStatusLabelPost = new ToolStripStatusLabel();
            toolStripStatusLabelFIOStaff = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripDropDownButtonFAQ = new ToolStripDropDownButton();
            toolStripDropDownButtonHelp = new ToolStripDropDownButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonTypeWork = new Button();
            pictureBox4 = new PictureBox();
            buttonCloseSession = new Button();
            buttonAdmPan = new Button();
            buttonDelDoc = new Button();
            buttonStudents = new Button();
            buttonVidWork = new Button();
            buttonSpecial = new Button();
            buttonWorkStud = new Button();
            buttonLichDel = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            checkBoxWorkStud = new CheckBox();
            checkBoxLD = new CheckBox();
            pictureBoxImport = new PictureBox();
            dataGridViewAll = new DataGridView();
            contextMenuAddUpd = new ContextMenuStrip(components);
            добавитьСпециальностьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьСпециальностьToolStripMenuItem = new ToolStripMenuItem();
            удалитьСпециальностьToolStripMenuItem = new ToolStripMenuItem();
            добавитьЛичноеДелоСтудентаToolStripMenuItem = new ToolStripMenuItem();
            редактироватьЛичноеДелоСтудентаToolStripMenuItem = new ToolStripMenuItem();
            удалитьЛичноеДелоToolStripMenuItem = new ToolStripMenuItem();
            добавитьРаботуСтудентаToolStripMenuItem = new ToolStripMenuItem();
            редактироватьРаботуСтудентаToolStripMenuItem = new ToolStripMenuItem();
            удалитьРаботуСтудентаToolStripMenuItem = new ToolStripMenuItem();
            добавитьВидРаботыToolStripMenuItem = new ToolStripMenuItem();
            редактироватьВидРаботыToolStripMenuItem = new ToolStripMenuItem();
            удалитьВидРаботыToolStripMenuItem = new ToolStripMenuItem();
            добавитьТипРаботыToolStripMenuItem = new ToolStripMenuItem();
            редактироватьТипРаботыToolStripMenuItem = new ToolStripMenuItem();
            удалитьТипРаботыToolStripMenuItem = new ToolStripMenuItem();
            labelText = new Label();
            checkBoxSroc = new CheckBox();
            groupBox1 = new GroupBox();
            textBoxGroup = new TextBox();
            buttonSearch = new Button();
            labelINFO = new Label();
            textBoxTopic = new TextBox();
            textBoxFIOS = new TextBox();
            labelTopic = new Label();
            labelGroup = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            timerTime = new System.Windows.Forms.Timer(components);
            timerAnimation = new System.Windows.Forms.Timer(components);
            splitContainer1 = new SplitContainer();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            contextMenuAddUpd.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(54, 20, 164);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPost, toolStripStatusLabelFIOStaff, toolStripStatusLabel2, toolStripDropDownButtonFAQ, toolStripDropDownButtonHelp });
            statusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip.Location = new Point(0, 652);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.RenderMode = ToolStripRenderMode.Professional;
            statusStrip.Size = new Size(1273, 30);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPost
            // 
            toolStripStatusLabelPost.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripStatusLabelPost.ForeColor = Color.White;
            toolStripStatusLabelPost.Name = "toolStripStatusLabelPost";
            toolStripStatusLabelPost.Size = new Size(111, 24);
            toolStripStatusLabelPost.Text = "Должность: ";
            // 
            // toolStripStatusLabelFIOStaff
            // 
            toolStripStatusLabelFIOStaff.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            toolStripStatusLabelFIOStaff.ForeColor = Color.White;
            toolStripStatusLabelFIOStaff.Name = "toolStripStatusLabelFIOStaff";
            toolStripStatusLabelFIOStaff.Size = new Size(64, 24);
            toolStripStatusLabelFIOStaff.Text = " ФИО: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(116, 24);
            toolStripStatusLabel2.Text = "Время: Дата:";
            // 
            // toolStripDropDownButtonFAQ
            // 
            toolStripDropDownButtonFAQ.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButtonFAQ.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            toolStripDropDownButtonFAQ.ForeColor = Color.White;
            toolStripDropDownButtonFAQ.Image = (Image)resources.GetObject("toolStripDropDownButtonFAQ.Image");
            toolStripDropDownButtonFAQ.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonFAQ.Name = "toolStripDropDownButtonFAQ";
            toolStripDropDownButtonFAQ.Size = new Size(148, 28);
            toolStripDropDownButtonFAQ.Text = "О программе";
            toolStripDropDownButtonFAQ.Click += toolStripDropDownButton1_Click;
            // 
            // toolStripDropDownButtonHelp
            // 
            toolStripDropDownButtonHelp.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButtonHelp.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            toolStripDropDownButtonHelp.ForeColor = Color.White;
            toolStripDropDownButtonHelp.Image = (Image)resources.GetObject("toolStripDropDownButtonHelp.Image");
            toolStripDropDownButtonHelp.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonHelp.Name = "toolStripDropDownButtonHelp";
            toolStripDropDownButtonHelp.Size = new Size(110, 28);
            toolStripDropDownButtonHelp.Text = "Справка";
            toolStripDropDownButtonHelp.Click += toolStripDropDownButtonHelp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 172);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1265, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTypeWork);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(buttonCloseSession);
            panel1.Controls.Add(buttonAdmPan);
            panel1.Controls.Add(buttonDelDoc);
            panel1.Controls.Add(buttonStudents);
            panel1.Controls.Add(buttonVidWork);
            panel1.Controls.Add(buttonSpecial);
            panel1.Controls.Add(buttonWorkStud);
            panel1.Controls.Add(buttonLichDel);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 163);
            panel1.TabIndex = 6;
            // 
            // buttonTypeWork
            // 
            buttonTypeWork.BackColor = Color.FromArgb(54, 20, 164);
            buttonTypeWork.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTypeWork.ForeColor = Color.White;
            buttonTypeWork.Image = (Image)resources.GetObject("buttonTypeWork.Image");
            buttonTypeWork.Location = new Point(711, 32);
            buttonTypeWork.Margin = new Padding(4);
            buttonTypeWork.Name = "buttonTypeWork";
            buttonTypeWork.Size = new Size(144, 128);
            buttonTypeWork.TabIndex = 11;
            buttonTypeWork.Text = "Типы работ";
            buttonTypeWork.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonTypeWork.UseVisualStyleBackColor = false;
            buttonTypeWork.Click += buttonTypeWork_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1243, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "";
            pictureBox4.Click += pictureBox4_Click;
            // 
            // buttonCloseSession
            // 
            buttonCloseSession.BackColor = Color.FromArgb(54, 20, 164);
            buttonCloseSession.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloseSession.ForeColor = Color.White;
            buttonCloseSession.Image = (Image)resources.GetObject("buttonCloseSession.Image");
            buttonCloseSession.Location = new Point(4, 32);
            buttonCloseSession.Margin = new Padding(4);
            buttonCloseSession.Name = "buttonCloseSession";
            buttonCloseSession.Size = new Size(142, 127);
            buttonCloseSession.TabIndex = 9;
            buttonCloseSession.Text = "Покинуть сессию";
            buttonCloseSession.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCloseSession.UseVisualStyleBackColor = false;
            buttonCloseSession.Click += buttonCloseSession_Click;
            // 
            // buttonAdmPan
            // 
            buttonAdmPan.BackColor = Color.FromArgb(54, 20, 164);
            buttonAdmPan.Enabled = false;
            buttonAdmPan.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdmPan.ForeColor = Color.White;
            buttonAdmPan.Image = (Image)resources.GetObject("buttonAdmPan.Image");
            buttonAdmPan.Location = new Point(1135, 33);
            buttonAdmPan.Margin = new Padding(4);
            buttonAdmPan.Name = "buttonAdmPan";
            buttonAdmPan.Size = new Size(130, 128);
            buttonAdmPan.TabIndex = 8;
            buttonAdmPan.Text = "Админпанель";
            buttonAdmPan.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonAdmPan.UseVisualStyleBackColor = false;
            buttonAdmPan.Click += buttonAdmPan_Click;
            // 
            // buttonDelDoc
            // 
            buttonDelDoc.BackColor = Color.FromArgb(54, 20, 164);
            buttonDelDoc.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDelDoc.ForeColor = Color.White;
            buttonDelDoc.Image = (Image)resources.GetObject("buttonDelDoc.Image");
            buttonDelDoc.Location = new Point(993, 32);
            buttonDelDoc.Margin = new Padding(4);
            buttonDelDoc.Name = "buttonDelDoc";
            buttonDelDoc.Size = new Size(139, 128);
            buttonDelDoc.TabIndex = 7;
            buttonDelDoc.Text = "Удаленные документы";
            buttonDelDoc.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDelDoc.UseVisualStyleBackColor = false;
            buttonDelDoc.Click += buttonDelDoc_Click;
            // 
            // buttonStudents
            // 
            buttonStudents.BackColor = Color.FromArgb(54, 20, 164);
            buttonStudents.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStudents.ForeColor = Color.White;
            buttonStudents.Image = (Image)resources.GetObject("buttonStudents.Image");
            buttonStudents.Location = new Point(431, 32);
            buttonStudents.Margin = new Padding(4);
            buttonStudents.Name = "buttonStudents";
            buttonStudents.Size = new Size(132, 127);
            buttonStudents.TabIndex = 5;
            buttonStudents.Text = "Студенты";
            buttonStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonStudents.UseVisualStyleBackColor = false;
            buttonStudents.Click += buttonStudents_Click;
            // 
            // buttonVidWork
            // 
            buttonVidWork.BackColor = Color.FromArgb(54, 20, 164);
            buttonVidWork.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonVidWork.ForeColor = Color.White;
            buttonVidWork.Image = (Image)resources.GetObject("buttonVidWork.Image");
            buttonVidWork.Location = new Point(856, 33);
            buttonVidWork.Margin = new Padding(4);
            buttonVidWork.Name = "buttonVidWork";
            buttonVidWork.Size = new Size(134, 128);
            buttonVidWork.TabIndex = 4;
            buttonVidWork.Text = "Виды работы";
            buttonVidWork.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonVidWork.UseVisualStyleBackColor = false;
            buttonVidWork.Click += buttonTypeWork_Click;
            // 
            // buttonSpecial
            // 
            buttonSpecial.BackColor = Color.FromArgb(54, 20, 164);
            buttonSpecial.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSpecial.ForeColor = Color.White;
            buttonSpecial.Image = (Image)resources.GetObject("buttonSpecial.Image");
            buttonSpecial.Location = new Point(148, 32);
            buttonSpecial.Margin = new Padding(4);
            buttonSpecial.Name = "buttonSpecial";
            buttonSpecial.Size = new Size(145, 127);
            buttonSpecial.TabIndex = 3;
            buttonSpecial.Text = "Специальности";
            buttonSpecial.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSpecial.UseVisualStyleBackColor = false;
            buttonSpecial.Click += buttonSpecial_Click;
            // 
            // buttonWorkStud
            // 
            buttonWorkStud.BackColor = Color.FromArgb(54, 20, 164);
            buttonWorkStud.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWorkStud.ForeColor = Color.White;
            buttonWorkStud.Image = (Image)resources.GetObject("buttonWorkStud.Image");
            buttonWorkStud.Location = new Point(565, 32);
            buttonWorkStud.Margin = new Padding(4);
            buttonWorkStud.Name = "buttonWorkStud";
            buttonWorkStud.Size = new Size(144, 128);
            buttonWorkStud.TabIndex = 2;
            buttonWorkStud.Text = "Работы студентов";
            buttonWorkStud.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonWorkStud.UseVisualStyleBackColor = false;
            buttonWorkStud.Click += buttonWorkStud_Click;
            // 
            // buttonLichDel
            // 
            buttonLichDel.BackColor = Color.FromArgb(54, 20, 164);
            buttonLichDel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLichDel.ForeColor = Color.White;
            buttonLichDel.Image = (Image)resources.GetObject("buttonLichDel.Image");
            buttonLichDel.Location = new Point(294, 32);
            buttonLichDel.Margin = new Padding(4);
            buttonLichDel.Name = "buttonLichDel";
            buttonLichDel.Size = new Size(135, 127);
            buttonLichDel.TabIndex = 1;
            buttonLichDel.Text = "Личные дела";
            buttonLichDel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLichDel.UseVisualStyleBackColor = false;
            buttonLichDel.Click += buttonLichDel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(checkBoxWorkStud);
            panel2.Controls.Add(checkBoxLD);
            panel2.Controls.Add(pictureBoxImport);
            panel2.Controls.Add(dataGridViewAll);
            panel2.Controls.Add(labelText);
            panel2.Controls.Add(checkBoxSroc);
            panel2.Location = new Point(7, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 461);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1200, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // checkBoxWorkStud
            // 
            checkBoxWorkStud.AutoSize = true;
            checkBoxWorkStud.ForeColor = Color.White;
            checkBoxWorkStud.Location = new Point(749, 12);
            checkBoxWorkStud.Name = "checkBoxWorkStud";
            checkBoxWorkStud.Size = new Size(183, 28);
            checkBoxWorkStud.TabIndex = 13;
            checkBoxWorkStud.Text = "Работы студентов";
            checkBoxWorkStud.UseVisualStyleBackColor = true;
            checkBoxWorkStud.CheckedChanged += checkBoxWorkStud_CheckedChanged;
            // 
            // checkBoxLD
            // 
            checkBoxLD.AutoSize = true;
            checkBoxLD.ForeColor = Color.White;
            checkBoxLD.Location = new Point(606, 12);
            checkBoxLD.Name = "checkBoxLD";
            checkBoxLD.Size = new Size(137, 28);
            checkBoxLD.TabIndex = 12;
            checkBoxLD.Text = "Личное дело";
            checkBoxLD.UseVisualStyleBackColor = true;
            checkBoxLD.CheckedChanged += checkBoxLD_CheckedChanged;
            // 
            // pictureBoxImport
            // 
            pictureBoxImport.Image = (Image)resources.GetObject("pictureBoxImport.Image");
            pictureBoxImport.Location = new Point(1146, 5);
            pictureBoxImport.Name = "pictureBoxImport";
            pictureBoxImport.Size = new Size(49, 49);
            pictureBoxImport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImport.TabIndex = 10;
            pictureBoxImport.TabStop = false;
            pictureBoxImport.Click += pictureBoxImport_Click;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.AllowUserToAddRows = false;
            dataGridViewAll.AllowUserToDeleteRows = false;
            dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAll.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAll.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.ContextMenuStrip = contextMenuAddUpd;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAll.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAll.Location = new Point(0, 58);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.ReadOnly = true;
            dataGridViewAll.RowHeadersWidth = 51;
            dataGridViewAll.Size = new Size(1249, 392);
            dataGridViewAll.TabIndex = 0;
            // 
            // contextMenuAddUpd
            // 
            contextMenuAddUpd.BackColor = Color.FromArgb(54, 20, 164);
            contextMenuAddUpd.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            contextMenuAddUpd.ImageScalingSize = new Size(20, 20);
            contextMenuAddUpd.Items.AddRange(new ToolStripItem[] { добавитьСпециальностьToolStripMenuItem, редактироватьСпециальностьToolStripMenuItem, удалитьСпециальностьToolStripMenuItem, добавитьЛичноеДелоСтудентаToolStripMenuItem, редактироватьЛичноеДелоСтудентаToolStripMenuItem, удалитьЛичноеДелоToolStripMenuItem, добавитьРаботуСтудентаToolStripMenuItem, редактироватьРаботуСтудентаToolStripMenuItem, удалитьРаботуСтудентаToolStripMenuItem, добавитьВидРаботыToolStripMenuItem, редактироватьВидРаботыToolStripMenuItem, удалитьВидРаботыToolStripMenuItem, добавитьТипРаботыToolStripMenuItem, редактироватьТипРаботыToolStripMenuItem, удалитьТипРаботыToolStripMenuItem });
            contextMenuAddUpd.Name = "contextMenuStrip1";
            contextMenuAddUpd.Size = new Size(392, 424);
            // 
            // добавитьСпециальностьToolStripMenuItem
            // 
            добавитьСпециальностьToolStripMenuItem.ForeColor = Color.White;
            добавитьСпециальностьToolStripMenuItem.Image = (Image)resources.GetObject("добавитьСпециальностьToolStripMenuItem.Image");
            добавитьСпециальностьToolStripMenuItem.Name = "добавитьСпециальностьToolStripMenuItem";
            добавитьСпециальностьToolStripMenuItem.Size = new Size(391, 28);
            добавитьСпециальностьToolStripMenuItem.Text = "Добавить специальность";
            добавитьСпециальностьToolStripMenuItem.Click += добавитьСпециальностьToolStripMenuItem_Click;
            // 
            // редактироватьСпециальностьToolStripMenuItem
            // 
            редактироватьСпециальностьToolStripMenuItem.ForeColor = Color.White;
            редактироватьСпециальностьToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьСпециальностьToolStripMenuItem.Image");
            редактироватьСпециальностьToolStripMenuItem.Name = "редактироватьСпециальностьToolStripMenuItem";
            редактироватьСпециальностьToolStripMenuItem.Size = new Size(391, 28);
            редактироватьСпециальностьToolStripMenuItem.Text = "Редактировать специальность";
            редактироватьСпециальностьToolStripMenuItem.Click += редактироватьСпециальностьToolStripMenuItem_Click;
            // 
            // удалитьСпециальностьToolStripMenuItem
            // 
            удалитьСпециальностьToolStripMenuItem.ForeColor = Color.White;
            удалитьСпециальностьToolStripMenuItem.Image = (Image)resources.GetObject("удалитьСпециальностьToolStripMenuItem.Image");
            удалитьСпециальностьToolStripMenuItem.Name = "удалитьСпециальностьToolStripMenuItem";
            удалитьСпециальностьToolStripMenuItem.Size = new Size(391, 28);
            удалитьСпециальностьToolStripMenuItem.Text = "Удалить специальность";
            удалитьСпециальностьToolStripMenuItem.Click += удалитьСпециальностьToolStripMenuItem_Click;
            // 
            // добавитьЛичноеДелоСтудентаToolStripMenuItem
            // 
            добавитьЛичноеДелоСтудентаToolStripMenuItem.ForeColor = Color.White;
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("добавитьЛичноеДелоСтудентаToolStripMenuItem.Image");
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Name = "добавитьЛичноеДелоСтудентаToolStripMenuItem";
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Size = new Size(391, 28);
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Text = "Добавить личное дело студента";
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
            добавитьЛичноеДелоСтудентаToolStripMenuItem.Click += добавитьЛичноеДелоСтудентаToolStripMenuItem_Click;
            // 
            // редактироватьЛичноеДелоСтудентаToolStripMenuItem
            // 
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.ForeColor = Color.White;
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьЛичноеДелоСтудентаToolStripMenuItem.Image");
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Name = "редактироватьЛичноеДелоСтудентаToolStripMenuItem";
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Size = new Size(391, 28);
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Text = "Редактировать личное дело студента";
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
            редактироватьЛичноеДелоСтудентаToolStripMenuItem.Click += редактироватьЛичноеДелоСтудентаToolStripMenuItem_Click;
            // 
            // удалитьЛичноеДелоToolStripMenuItem
            // 
            удалитьЛичноеДелоToolStripMenuItem.ForeColor = Color.White;
            удалитьЛичноеДелоToolStripMenuItem.Image = (Image)resources.GetObject("удалитьЛичноеДелоToolStripMenuItem.Image");
            удалитьЛичноеДелоToolStripMenuItem.Name = "удалитьЛичноеДелоToolStripMenuItem";
            удалитьЛичноеДелоToolStripMenuItem.Size = new Size(391, 28);
            удалитьЛичноеДелоToolStripMenuItem.Text = "Удалить личное дело";
            удалитьЛичноеДелоToolStripMenuItem.Click += удалитьЛичноеДелоToolStripMenuItem_Click;
            // 
            // добавитьРаботуСтудентаToolStripMenuItem
            // 
            добавитьРаботуСтудентаToolStripMenuItem.ForeColor = Color.White;
            добавитьРаботуСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("добавитьРаботуСтудентаToolStripMenuItem.Image");
            добавитьРаботуСтудентаToolStripMenuItem.Name = "добавитьРаботуСтудентаToolStripMenuItem";
            добавитьРаботуСтудентаToolStripMenuItem.Size = new Size(391, 28);
            добавитьРаботуСтудентаToolStripMenuItem.Text = "Добавить работу студента";
            добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
            добавитьРаботуСтудентаToolStripMenuItem.Click += добавитьРаботуСтудентаToolStripMenuItem_Click;
            // 
            // редактироватьРаботуСтудентаToolStripMenuItem
            // 
            редактироватьРаботуСтудентаToolStripMenuItem.ForeColor = Color.White;
            редактироватьРаботуСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьРаботуСтудентаToolStripMenuItem.Image");
            редактироватьРаботуСтудентаToolStripMenuItem.Name = "редактироватьРаботуСтудентаToolStripMenuItem";
            редактироватьРаботуСтудентаToolStripMenuItem.Size = new Size(391, 28);
            редактироватьРаботуСтудентаToolStripMenuItem.Text = "Редактировать работу студента";
            редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
            редактироватьРаботуСтудентаToolStripMenuItem.Click += редактироватьРаботуСтудентаToolStripMenuItem_Click;
            // 
            // удалитьРаботуСтудентаToolStripMenuItem
            // 
            удалитьРаботуСтудентаToolStripMenuItem.ForeColor = Color.White;
            удалитьРаботуСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("удалитьРаботуСтудентаToolStripMenuItem.Image");
            удалитьРаботуСтудентаToolStripMenuItem.Name = "удалитьРаботуСтудентаToolStripMenuItem";
            удалитьРаботуСтудентаToolStripMenuItem.Size = new Size(391, 28);
            удалитьРаботуСтудентаToolStripMenuItem.Text = "Удалить работу студента";
            удалитьРаботуСтудентаToolStripMenuItem.Click += удалитьРаботуСтудентаToolStripMenuItem_Click;
            // 
            // добавитьВидРаботыToolStripMenuItem
            // 
            добавитьВидРаботыToolStripMenuItem.ForeColor = Color.White;
            добавитьВидРаботыToolStripMenuItem.Image = (Image)resources.GetObject("добавитьВидРаботыToolStripMenuItem.Image");
            добавитьВидРаботыToolStripMenuItem.Name = "добавитьВидРаботыToolStripMenuItem";
            добавитьВидРаботыToolStripMenuItem.Size = new Size(391, 28);
            добавитьВидРаботыToolStripMenuItem.Text = "Добавить вид работы";
            добавитьВидРаботыToolStripMenuItem.Click += добавитьВидРаботыToolStripMenuItem_Click;
            // 
            // редактироватьВидРаботыToolStripMenuItem
            // 
            редактироватьВидРаботыToolStripMenuItem.ForeColor = Color.White;
            редактироватьВидРаботыToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьВидРаботыToolStripMenuItem.Image");
            редактироватьВидРаботыToolStripMenuItem.Name = "редактироватьВидРаботыToolStripMenuItem";
            редактироватьВидРаботыToolStripMenuItem.Size = new Size(391, 28);
            редактироватьВидРаботыToolStripMenuItem.Text = "Редактировать вид работы";
            редактироватьВидРаботыToolStripMenuItem.Click += редактироватьВидРаботыToolStripMenuItem_Click;
            // 
            // удалитьВидРаботыToolStripMenuItem
            // 
            удалитьВидРаботыToolStripMenuItem.ForeColor = Color.White;
            удалитьВидРаботыToolStripMenuItem.Image = (Image)resources.GetObject("удалитьВидРаботыToolStripMenuItem.Image");
            удалитьВидРаботыToolStripMenuItem.Name = "удалитьВидРаботыToolStripMenuItem";
            удалитьВидРаботыToolStripMenuItem.Size = new Size(391, 28);
            удалитьВидРаботыToolStripMenuItem.Text = "Удалить вид работы";
            удалитьВидРаботыToolStripMenuItem.Click += удалитьВидРаботыToolStripMenuItem_Click;
            // 
            // добавитьТипРаботыToolStripMenuItem
            // 
            добавитьТипРаботыToolStripMenuItem.ForeColor = Color.White;
            добавитьТипРаботыToolStripMenuItem.Image = (Image)resources.GetObject("добавитьТипРаботыToolStripMenuItem.Image");
            добавитьТипРаботыToolStripMenuItem.Name = "добавитьТипРаботыToolStripMenuItem";
            добавитьТипРаботыToolStripMenuItem.Size = new Size(391, 28);
            добавитьТипРаботыToolStripMenuItem.Text = "Добавить тип работы";
            добавитьТипРаботыToolStripMenuItem.Click += добавитьТипРаботыToolStripMenuItem_Click;
            // 
            // редактироватьТипРаботыToolStripMenuItem
            // 
            редактироватьТипРаботыToolStripMenuItem.ForeColor = Color.White;
            редактироватьТипРаботыToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьТипРаботыToolStripMenuItem.Image");
            редактироватьТипРаботыToolStripMenuItem.Name = "редактироватьТипРаботыToolStripMenuItem";
            редактироватьТипРаботыToolStripMenuItem.Size = new Size(391, 28);
            редактироватьТипРаботыToolStripMenuItem.Text = "Редактировать тип работы";
            редактироватьТипРаботыToolStripMenuItem.Click += редактироватьТипРаботыToolStripMenuItem_Click;
            // 
            // удалитьТипРаботыToolStripMenuItem
            // 
            удалитьТипРаботыToolStripMenuItem.ForeColor = Color.White;
            удалитьТипРаботыToolStripMenuItem.Image = (Image)resources.GetObject("удалитьТипРаботыToolStripMenuItem.Image");
            удалитьТипРаботыToolStripMenuItem.Name = "удалитьТипРаботыToolStripMenuItem";
            удалитьТипРаботыToolStripMenuItem.Size = new Size(391, 28);
            удалитьТипРаботыToolStripMenuItem.Text = "Удалить тип работы";
            удалитьТипРаботыToolStripMenuItem.Click += удалитьТипРаботыToolStripMenuItem_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.ForeColor = Color.White;
            labelText.Location = new Point(5, 13);
            labelText.Name = "labelText";
            labelText.Size = new Size(322, 24);
            labelText.TabIndex = 1;
            labelText.Text = "Список утелизированных документов";
            // 
            // checkBoxSroc
            // 
            checkBoxSroc.AutoSize = true;
            checkBoxSroc.ForeColor = Color.White;
            checkBoxSroc.Location = new Point(938, 14);
            checkBoxSroc.Name = "checkBoxSroc";
            checkBoxSroc.Size = new Size(202, 28);
            checkBoxSroc.TabIndex = 2;
            checkBoxSroc.Text = "Истек срок хранения";
            checkBoxSroc.UseVisualStyleBackColor = true;
            checkBoxSroc.CheckedChanged += checkBoxSroc_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxGroup);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(labelINFO);
            groupBox1.Controls.Add(textBoxTopic);
            groupBox1.Controls.Add(textBoxFIOS);
            groupBox1.Controls.Add(labelTopic);
            groupBox1.Controls.Add(labelGroup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(13, 5);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(539, 449);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxGroup.Location = new Point(224, 136);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.PlaceholderText = "Группа";
            textBoxGroup.Size = new Size(279, 30);
            textBoxGroup.TabIndex = 24;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(54, 20, 164);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch.Location = new Point(187, 360);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(208, 71);
            buttonSearch.TabIndex = 23;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelINFO
            // 
            labelINFO.AutoSize = true;
            labelINFO.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINFO.ForeColor = Color.White;
            labelINFO.Location = new Point(200, 44);
            labelINFO.Name = "labelINFO";
            labelINFO.Size = new Size(207, 27);
            labelINFO.TabIndex = 16;
            labelINFO.Text = "Расширенный поиск";
            // 
            // textBoxTopic
            // 
            textBoxTopic.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxTopic.Location = new Point(224, 193);
            textBoxTopic.Multiline = true;
            textBoxTopic.Name = "textBoxTopic";
            textBoxTopic.PlaceholderText = "Тема работы";
            textBoxTopic.Size = new Size(279, 138);
            textBoxTopic.TabIndex = 22;
            // 
            // textBoxFIOS
            // 
            textBoxFIOS.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            textBoxFIOS.Location = new Point(224, 79);
            textBoxFIOS.Name = "textBoxFIOS";
            textBoxFIOS.PlaceholderText = "ФИО";
            textBoxFIOS.Size = new Size(279, 30);
            textBoxFIOS.TabIndex = 18;
            // 
            // labelTopic
            // 
            labelTopic.AutoSize = true;
            labelTopic.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            labelTopic.ForeColor = Color.White;
            labelTopic.Location = new Point(13, 196);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(117, 24);
            labelTopic.TabIndex = 17;
            labelTopic.Text = "Тема работы";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            labelGroup.ForeColor = Color.White;
            labelGroup.Location = new Point(13, 136);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(68, 24);
            labelGroup.TabIndex = 16;
            labelGroup.Text = "Группа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 82);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 13;
            label1.Text = "Фамилия, имя, отчество";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 31);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(513, 410);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // timerTime
            // 
            timerTime.Enabled = true;
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // timerAnimation
            // 
            timerAnimation.Enabled = true;
            timerAnimation.Interval = 10;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 172);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2Collapsed = true;
            splitContainer1.Size = new Size(1273, 458);
            splitContainer1.SplitterDistance = 703;
            splitContainer1.TabIndex = 14;
            splitContainer1.Visible = false;
            // 
            // FormDescktop
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 66, 80);
            ClientSize = new Size(1273, 682);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(statusStrip);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(1273, 682);
            MinimumSize = new Size(1273, 682);
            Name = "FormDescktop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Архивный фонд";
            FormClosing += FormDescktop_FormClosing;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            contextMenuAddUpd.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelPost;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonWorkStud;
        private Button buttonLichDel;
        private Button buttonStudents;
        private Button buttonVidWork;
        private Button buttonSpecial;
        private Button buttonAdmPan;
        private Button buttonDelDoc;
        private Button buttonCloseSession;
        private Panel panel2;
        private Label labelText;
        private DataGridView dataGridViewAll;
        private CheckBox checkBoxSroc;
        private ContextMenuStrip contextMenuAddUpd;
        private ToolStripMenuItem добавитьЛичноеДелоСтудентаToolStripMenuItem;
        private ToolStripMenuItem редактироватьЛичноеДелоСтудентаToolStripMenuItem;
        private ToolStripMenuItem добавитьРаботуСтудентаToolStripMenuItem;
        private ToolStripMenuItem редактироватьРаботуСтудентаToolStripMenuItem;
        private ToolStripMenuItem добавитьСпециальностьToolStripMenuItem;
        private ToolStripMenuItem редактироватьСпециальностьToolStripMenuItem;
        private ToolStripMenuItem добавитьВидРаботыToolStripMenuItem;
        private ToolStripMenuItem редактироватьВидРаботыToolStripMenuItem;
        private ToolStripMenuItem удалитьЛичноеДелоToolStripMenuItem;
        private ToolStripMenuItem удалитьРаботуСтудентаToolStripMenuItem;
        private ToolStripMenuItem удалитьСпециальностьToolStripMenuItem;
        private ToolStripMenuItem удалитьВидРаботыToolStripMenuItem;
        private GroupBox groupBox1;
        public Label labelTopic;
        public Label labelGroup;
        public Label label1;
        private PictureBox pictureBox2;
        public Label labelINFO;
        private ToolStripDropDownButton toolStripDropDownButtonHelp;
        private ToolStripDropDownButton toolStripDropDownButtonFAQ;
        private ToolStripStatusLabel toolStripStatusLabelFIOStaff;
        private System.Windows.Forms.Timer timerTime;
        private Button buttonSearch;
        private PictureBox pictureBox4;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private PictureBox pictureBoxImport;
        private System.Windows.Forms.Timer timerAnimation;
        private Button buttonTypeWork;
        private ToolStripMenuItem добавитьТипРаботыToolStripMenuItem;
        private ToolStripMenuItem редактироватьТипРаботыToolStripMenuItem;
        private ToolStripMenuItem удалитьТипРаботыToolStripMenuItem;
        public TextBox textBoxTopic;
        public TextBox textBoxFIOS;
        public TextBox textBoxGroup;
        public CheckBox checkBoxWorkStud;
        public CheckBox checkBoxLD;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox3;
    }
}
