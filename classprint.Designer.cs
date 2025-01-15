namespace kwa
{
    partial class classprint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.datagridview_class = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_teacher = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_grade = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_class)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 41);
            this.panel1.TabIndex = 104;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(347, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Print";
            // 
            // textBox_sub
            // 
            this.textBox_sub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBox_sub.Location = new System.Drawing.Point(601, 50);
            this.textBox_sub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(77, 21);
            this.textBox_sub.TabIndex = 130;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Orange;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(676, 49);
            this.button_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(83, 23);
            this.button_search.TabIndex = 129;
            this.button_search.Text = "Subject";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // datagridview_class
            // 
            this.datagridview_class.AllowUserToAddRows = false;
            this.datagridview_class.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.datagridview_class.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.datagridview_class.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridview_class.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview_class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_class.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_class.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_class.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.datagridview_class.ColumnHeadersHeight = 24;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_class.DefaultCellStyle = dataGridViewCellStyle24;
            this.datagridview_class.EnableHeadersVisualStyles = false;
            this.datagridview_class.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_class.Location = new System.Drawing.Point(13, 81);
            this.datagridview_class.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datagridview_class.Name = "datagridview_class";
            this.datagridview_class.RowHeadersVisible = false;
            this.datagridview_class.RowTemplate.DividerHeight = 1;
            this.datagridview_class.RowTemplate.Height = 80;
            this.datagridview_class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_class.Size = new System.Drawing.Size(746, 415);
            this.datagridview_class.TabIndex = 128;
            this.datagridview_class.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_class.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_class.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_class.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_class.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_class.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.datagridview_class.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_class.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_class.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_class.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_class.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_class.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_class.ThemeStyle.HeaderStyle.Height = 24;
            this.datagridview_class.ThemeStyle.ReadOnly = false;
            this.datagridview_class.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_class.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_class.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_class.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_class.ThemeStyle.RowsStyle.Height = 80;
            this.datagridview_class.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_class.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // textBox_day
            // 
            this.textBox_day.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBox_day.Location = new System.Drawing.Point(400, 49);
            this.textBox_day.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(112, 21);
            this.textBox_day.TabIndex = 133;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(510, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 132;
            this.button1.Text = "Day";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_teacher
            // 
            this.textBox_teacher.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBox_teacher.Location = new System.Drawing.Point(165, 49);
            this.textBox_teacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_teacher.Name = "textBox_teacher";
            this.textBox_teacher.Size = new System.Drawing.Size(142, 21);
            this.textBox_teacher.TabIndex = 135;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(305, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 134;
            this.button2.Text = "Teacher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBox3.Location = new System.Drawing.Point(16, 48);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 21);
            this.textBox3.TabIndex = 137;
            // 
            // button_grade
            // 
            this.button_grade.BackColor = System.Drawing.Color.Orange;
            this.button_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grade.ForeColor = System.Drawing.Color.White;
            this.button_grade.Location = new System.Drawing.Point(69, 47);
            this.button_grade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_grade.Name = "button_grade";
            this.button_grade.Size = new System.Drawing.Size(83, 23);
            this.button_grade.TabIndex = 136;
            this.button_grade.Text = "Grade";
            this.button_grade.UseVisualStyleBackColor = false;
            this.button_grade.Click += new System.EventHandler(this.button_grade_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(627, 516);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(132, 42);
            this.button_upload.TabIndex = 138;
            this.button_upload.Text = "Print";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // classprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 588);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_grade);
            this.Controls.Add(this.textBox_teacher);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_sub);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.datagridview_class);
            this.Controls.Add(this.panel1);
            this.Name = "classprint";
            this.Text = "classprint";
            this.Load += new System.EventHandler(this.classprint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.Button button_search;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_class;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_teacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_grade;
        private System.Windows.Forms.Button button_upload;
    }
}