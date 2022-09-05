
namespace Student
{
    partial class StudentRegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SRno = new System.Windows.Forms.Label();
            this.SFirstName = new System.Windows.Forms.Label();
            this.SAge = new System.Windows.Forms.Label();
            this.SBranch = new System.Windows.Forms.Label();
            this.SClg = new System.Windows.Forms.Label();
            this.SRNINPUT = new System.Windows.Forms.TextBox();
            this.SNINPUT = new System.Windows.Forms.TextBox();
            this.SAINPUT = new System.Windows.Forms.TextBox();
            this.SBINPUT = new System.Windows.Forms.TextBox();
            this.SCINPUT = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.GridViewStudent = new System.Windows.Forms.DataGridView();
            this.GenderGroupbox = new System.Windows.Forms.GroupBox();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.StatusgroupBox = new System.Windows.Forms.GroupBox();
            this.UnmarriedradioButton = new System.Windows.Forms.RadioButton();
            this.MarriedradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudent)).BeginInit();
            this.GenderGroupbox.SuspendLayout();
            this.StatusgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // SRno
            // 
            this.SRno.AutoSize = true;
            this.SRno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SRno.Location = new System.Drawing.Point(76, 76);
            this.SRno.Name = "SRno";
            this.SRno.Size = new System.Drawing.Size(64, 20);
            this.SRno.TabIndex = 1;
            this.SRno.Text = "Roll No";
            // 
            // SFirstName
            // 
            this.SFirstName.AutoSize = true;
            this.SFirstName.Location = new System.Drawing.Point(82, 127);
            this.SFirstName.Name = "SFirstName";
            this.SFirstName.Size = new System.Drawing.Size(51, 20);
            this.SFirstName.TabIndex = 2;
            this.SFirstName.Text = "Name";
            // 
            // SAge
            // 
            this.SAge.AutoSize = true;
            this.SAge.Location = new System.Drawing.Point(82, 182);
            this.SAge.Name = "SAge";
            this.SAge.Size = new System.Drawing.Size(38, 20);
            this.SAge.TabIndex = 3;
            this.SAge.Text = "Age";
            // 
            // SBranch
            // 
            this.SBranch.AutoSize = true;
            this.SBranch.Location = new System.Drawing.Point(82, 230);
            this.SBranch.Name = "SBranch";
            this.SBranch.Size = new System.Drawing.Size(60, 20);
            this.SBranch.TabIndex = 4;
            this.SBranch.Text = "Branch";
            // 
            // SClg
            // 
            this.SClg.AutoSize = true;
            this.SClg.Location = new System.Drawing.Point(82, 284);
            this.SClg.Name = "SClg";
            this.SClg.Size = new System.Drawing.Size(62, 20);
            this.SClg.TabIndex = 5;
            this.SClg.Text = "College";
            // 
            // SRNINPUT
            // 
            this.SRNINPUT.Location = new System.Drawing.Point(234, 76);
            this.SRNINPUT.Name = "SRNINPUT";
            this.SRNINPUT.Size = new System.Drawing.Size(126, 26);
            this.SRNINPUT.TabIndex = 6;
            // 
            // SNINPUT
            // 
            this.SNINPUT.Location = new System.Drawing.Point(234, 121);
            this.SNINPUT.Name = "SNINPUT";
            this.SNINPUT.Size = new System.Drawing.Size(126, 26);
            this.SNINPUT.TabIndex = 7;
            // 
            // SAINPUT
            // 
            this.SAINPUT.Location = new System.Drawing.Point(234, 176);
            this.SAINPUT.Name = "SAINPUT";
            this.SAINPUT.Size = new System.Drawing.Size(126, 26);
            this.SAINPUT.TabIndex = 8;
            this.SAINPUT.TextChanged += new System.EventHandler(this.SA_TextChanged);
            // 
            // SBINPUT
            // 
            this.SBINPUT.Location = new System.Drawing.Point(234, 224);
            this.SBINPUT.Name = "SBINPUT";
            this.SBINPUT.Size = new System.Drawing.Size(126, 26);
            this.SBINPUT.TabIndex = 9;
            // 
            // SCINPUT
            // 
            this.SCINPUT.Location = new System.Drawing.Point(234, 278);
            this.SCINPUT.Name = "SCINPUT";
            this.SCINPUT.Size = new System.Drawing.Size(126, 26);
            this.SCINPUT.TabIndex = 10;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(56, 530);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(88, 41);
            this.Addbutton.TabIndex = 11;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(169, 530);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(88, 41);
            this.Updatebutton.TabIndex = 12;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(283, 530);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(88, 41);
            this.Deletebutton.TabIndex = 13;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // GridViewStudent
            // 
            this.GridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewStudent.Location = new System.Drawing.Point(444, 76);
            this.GridViewStudent.Name = "GridViewStudent";
            this.GridViewStudent.RowHeadersWidth = 62;
            this.GridViewStudent.RowTemplate.Height = 28;
            this.GridViewStudent.Size = new System.Drawing.Size(893, 522);
            this.GridViewStudent.TabIndex = 14;
            this.GridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.GridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GenderGroupbox
            // 
            this.GenderGroupbox.Controls.Add(this.FemaleradioButton);
            this.GenderGroupbox.Controls.Add(this.MaleradioButton);
            this.GenderGroupbox.Location = new System.Drawing.Point(80, 326);
            this.GenderGroupbox.Name = "GenderGroupbox";
            this.GenderGroupbox.Size = new System.Drawing.Size(358, 87);
            this.GenderGroupbox.TabIndex = 16;
            this.GenderGroupbox.TabStop = false;
            this.GenderGroupbox.Text = "Gender";
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(204, 25);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(87, 24);
            this.FemaleradioButton.TabIndex = 1;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(89, 25);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(68, 24);
            this.MaleradioButton.TabIndex = 0;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // StatusgroupBox
            // 
            this.StatusgroupBox.Controls.Add(this.UnmarriedradioButton);
            this.StatusgroupBox.Controls.Add(this.MarriedradioButton);
            this.StatusgroupBox.Location = new System.Drawing.Point(80, 419);
            this.StatusgroupBox.Name = "StatusgroupBox";
            this.StatusgroupBox.Size = new System.Drawing.Size(358, 78);
            this.StatusgroupBox.TabIndex = 17;
            this.StatusgroupBox.TabStop = false;
            this.StatusgroupBox.Text = "Status";
            // 
            // UnmarriedradioButton
            // 
            this.UnmarriedradioButton.AutoSize = true;
            this.UnmarriedradioButton.Location = new System.Drawing.Point(204, 25);
            this.UnmarriedradioButton.Name = "UnmarriedradioButton";
            this.UnmarriedradioButton.Size = new System.Drawing.Size(108, 24);
            this.UnmarriedradioButton.TabIndex = 2;
            this.UnmarriedradioButton.TabStop = true;
            this.UnmarriedradioButton.Text = "Unmarried";
            this.UnmarriedradioButton.UseVisualStyleBackColor = true;
            // 
            // MarriedradioButton
            // 
            this.MarriedradioButton.AutoSize = true;
            this.MarriedradioButton.Location = new System.Drawing.Point(89, 25);
            this.MarriedradioButton.Name = "MarriedradioButton";
            this.MarriedradioButton.Size = new System.Drawing.Size(87, 24);
            this.MarriedradioButton.TabIndex = 1;
            this.MarriedradioButton.TabStop = true;
            this.MarriedradioButton.Text = "Married";
            this.MarriedradioButton.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 640);
            this.Controls.Add(this.StatusgroupBox);
            this.Controls.Add(this.GenderGroupbox);
            this.Controls.Add(this.GridViewStudent);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.SCINPUT);
            this.Controls.Add(this.SBINPUT);
            this.Controls.Add(this.SAINPUT);
            this.Controls.Add(this.SNINPUT);
            this.Controls.Add(this.SRNINPUT);
            this.Controls.Add(this.SClg);
            this.Controls.Add(this.SBranch);
            this.Controls.Add(this.SAge);
            this.Controls.Add(this.SFirstName);
            this.Controls.Add(this.SRno);
            this.Controls.Add(this.label1);
            this.Name = "StudentRegistrationForm";
            this.Text = "StudentRegistrationForm";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudent)).EndInit();
            this.GenderGroupbox.ResumeLayout(false);
            this.GenderGroupbox.PerformLayout();
            this.StatusgroupBox.ResumeLayout(false);
            this.StatusgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SRno;
        private System.Windows.Forms.Label SFirstName;
        private System.Windows.Forms.Label SAge;
        private System.Windows.Forms.Label SBranch;
        private System.Windows.Forms.Label SClg;
        private System.Windows.Forms.TextBox SRNINPUT;
        private System.Windows.Forms.TextBox SNINPUT;
        private System.Windows.Forms.TextBox SAINPUT;
        private System.Windows.Forms.TextBox SBINPUT;
        private System.Windows.Forms.TextBox SCINPUT;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DataGridView GridViewStudent;
        private System.Windows.Forms.GroupBox GenderGroupbox;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.GroupBox StatusgroupBox;
        private System.Windows.Forms.RadioButton UnmarriedradioButton;
        private System.Windows.Forms.RadioButton MarriedradioButton;
    }
}

