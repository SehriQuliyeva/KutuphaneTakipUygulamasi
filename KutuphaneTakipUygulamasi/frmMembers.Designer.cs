namespace KutuphaneTakipUygulamasi
{
    partial class frmMembers
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
            gbxInsertMember = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            btnInsert = new Button();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            tbxStudentId = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgwMembers = new DataGridView();
            tbxMember = new TextBox();
            gbxUpdate = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            tbxUpdateRoles = new TextBox();
            lblUpdateRoles = new Label();
            tbxUpdateStudentId = new TextBox();
            tbxUpdateLastName = new TextBox();
            tbxUpdateName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnMain = new Button();
            gbxInsertMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMembers).BeginInit();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // gbxInsertMember
            // 
            gbxInsertMember.Controls.Add(dtpBirthDate);
            gbxInsertMember.Controls.Add(btnInsert);
            gbxInsertMember.Controls.Add(rbWoman);
            gbxInsertMember.Controls.Add(rbMan);
            gbxInsertMember.Controls.Add(tbxStudentId);
            gbxInsertMember.Controls.Add(tbxLastName);
            gbxInsertMember.Controls.Add(tbxFirstName);
            gbxInsertMember.Controls.Add(label4);
            gbxInsertMember.Controls.Add(label3);
            gbxInsertMember.Controls.Add(label2);
            gbxInsertMember.Controls.Add(label1);
            gbxInsertMember.Location = new Point(385, 40);
            gbxInsertMember.Name = "gbxInsertMember";
            gbxInsertMember.Size = new Size(377, 387);
            gbxInsertMember.TabIndex = 1;
            gbxInsertMember.TabStop = false;
            gbxInsertMember.Text = "Üye Ekle";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(121, 146);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(143, 276);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(124, 42);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Kaydet";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Location = new Point(84, 203);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(68, 24);
            rbWoman.TabIndex = 2;
            rbWoman.TabStop = true;
            rbWoman.Text = "Kadın";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Location = new Point(264, 203);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(65, 24);
            rbMan.TabIndex = 3;
            rbMan.TabStop = true;
            rbMan.Text = "Erkek";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // tbxStudentId
            // 
            tbxStudentId.Location = new Point(121, 102);
            tbxStudentId.Name = "tbxStudentId";
            tbxStudentId.Size = new Size(250, 27);
            tbxStudentId.TabIndex = 6;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(121, 66);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(250, 27);
            tbxLastName.TabIndex = 5;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(121, 29);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(250, 27);
            tbxFirstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 146);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 109);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 73);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // dgwMembers
            // 
            dgwMembers.BackgroundColor = SystemColors.Control;
            dgwMembers.ColumnHeadersHeight = 29;
            dgwMembers.GridColor = SystemColors.Menu;
            dgwMembers.Location = new Point(12, 273);
            dgwMembers.Name = "dgwMembers";
            dgwMembers.RowHeadersWidth = 51;
            dgwMembers.Size = new Size(367, 154);
            dgwMembers.TabIndex = 0;
            dgwMembers.CellClick += dgwMembers_CellClick;
            // 
            // tbxMember
            // 
            tbxMember.Location = new Point(50, 243);
            tbxMember.Name = "tbxMember";
            tbxMember.Size = new Size(125, 27);
            tbxMember.TabIndex = 2;
            tbxMember.TextChanged += tbxMember_TextChanged;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnDelete);
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxUpdateRoles);
            gbxUpdate.Controls.Add(lblUpdateRoles);
            gbxUpdate.Controls.Add(tbxUpdateStudentId);
            gbxUpdate.Controls.Add(tbxUpdateLastName);
            gbxUpdate.Controls.Add(tbxUpdateName);
            gbxUpdate.Controls.Add(label5);
            gbxUpdate.Controls.Add(label6);
            gbxUpdate.Controls.Add(label7);
            gbxUpdate.Location = new Point(12, 28);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(347, 206);
            gbxUpdate.TabIndex = 17;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Güncelle";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(140, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUpdateRoles
            // 
            tbxUpdateRoles.Location = new Point(97, 137);
            tbxUpdateRoles.Name = "tbxUpdateRoles";
            tbxUpdateRoles.Size = new Size(250, 27);
            tbxUpdateRoles.TabIndex = 24;
            // 
            // lblUpdateRoles
            // 
            lblUpdateRoles.AutoSize = true;
            lblUpdateRoles.Location = new Point(57, 141);
            lblUpdateRoles.Name = "lblUpdateRoles";
            lblUpdateRoles.Size = new Size(34, 20);
            lblUpdateRoles.TabIndex = 23;
            lblUpdateRoles.Text = "Rol:";
            // 
            // tbxUpdateStudentId
            // 
            tbxUpdateStudentId.Location = new Point(97, 100);
            tbxUpdateStudentId.Name = "tbxUpdateStudentId";
            tbxUpdateStudentId.Size = new Size(250, 27);
            tbxUpdateStudentId.TabIndex = 22;
            // 
            // tbxUpdateLastName
            // 
            tbxUpdateLastName.Location = new Point(97, 64);
            tbxUpdateLastName.Name = "tbxUpdateLastName";
            tbxUpdateLastName.Size = new Size(250, 27);
            tbxUpdateLastName.TabIndex = 21;
            // 
            // tbxUpdateName
            // 
            tbxUpdateName.Location = new Point(97, 27);
            tbxUpdateName.Name = "tbxUpdateName";
            tbxUpdateName.Size = new Size(250, 27);
            tbxUpdateName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 104);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 19;
            label5.Text = "Öğrenci No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 68);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 18;
            label6.Text = "Soyad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 31);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 17;
            label7.Text = "Ad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 250);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 18;
            label8.Text = "Ara:";
            // 
            // btnMain
            // 
            btnMain.Location = new Point(694, 12);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(94, 29);
            btnMain.TabIndex = 19;
            btnMain.Text = "ANA SAYFA";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += btnMain_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMain);
            Controls.Add(label8);
            Controls.Add(gbxUpdate);
            Controls.Add(tbxMember);
            Controls.Add(dgwMembers);
            Controls.Add(gbxInsertMember);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekle";
            Load += frmMembers_Load;
            gbxInsertMember.ResumeLayout(false);
            gbxInsertMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMembers).EndInit();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxInsertMember;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbxStudentId;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Button btnInsert;
        private DateTimePicker dtpBirthDate;
        private DataGridView dgwMembers;
        private TextBox tbxMember;
        private GroupBox gbxUpdate;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox tbxUpdateRoles;
        private Label lblUpdateRoles;
        private TextBox tbxUpdateStudentId;
        private TextBox tbxUpdateLastName;
        private TextBox tbxUpdateName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnMain;
    }
}