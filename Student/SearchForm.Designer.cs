
namespace Student
{
    partial class SearchForm
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
            this.SNAME = new System.Windows.Forms.Label();
            this.SNAMEINPUT = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SNAME
            // 
            this.SNAME.AutoSize = true;
            this.SNAME.Location = new System.Drawing.Point(62, 69);
            this.SNAME.Name = "SNAME";
            this.SNAME.Size = new System.Drawing.Size(51, 20);
            this.SNAME.TabIndex = 0;
            this.SNAME.Text = "Name";
            // 
            // SNAMEINPUT
            // 
            this.SNAMEINPUT.Location = new System.Drawing.Point(181, 69);
            this.SNAMEINPUT.Name = "SNAMEINPUT";
            this.SNAMEINPUT.Size = new System.Drawing.Size(145, 26);
            this.SNAMEINPUT.TabIndex = 1;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(361, 53);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(134, 42);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(791, 393);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SNAMEINPUT);
            this.Controls.Add(this.SNAME);
            this.Name = "SearchForm";
            this.Text = "Student Search Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SNAME;
        private System.Windows.Forms.TextBox SNAMEINPUT;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}